using SQLite;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio1._3.Models
{
    public class Personas
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
    }
}
