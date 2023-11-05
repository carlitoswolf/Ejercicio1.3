using Microsoft.Extensions.Logging;

namespace Ejercicio1._3
{
    public static class MauiProgram
    {
        static Controllers.FuntionsApiController db;
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static Controllers.FuntionsApiController Instancia
        {
            get
            {
                if (db == null)
                {
                    string dbname = "PersonasDB.db3";
                    string dbpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    string dbfull = Path.Combine(dbpath, dbname);
                    db = new Controllers.FuntionsApiController(dbfull);
                }

                return db;
            }
        }
    }
}