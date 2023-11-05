
namespace Ejercicio1._3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            var person = new Models.Personas
            {
                nombres = _nombre.Text,
                apellidos = _apellidos.Text,
                edad = Convert.ToInt32(_edad.Text),
                correo = _correo.Text,
                direccion = _direccion.Text
            };

            if (await MauiProgram.Instancia.AddPeople(person) > 0)
            {
                await DisplayAlert("INFORMACION", "Registro Hecho Exitosamente", "ACEPTAR");
                clean();
            }
            else
            {
                await DisplayAlert("ERROR", "Ha Ocurrido un Error", "OK");
            }
        }

        private void clean()
        {
            _nombre.Text = "";
            _apellidos.Text = "";
            _edad.Text = "";
            _correo.Text = "";
            _direccion.Text = "";

        }
    }
}