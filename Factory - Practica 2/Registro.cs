using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory___Practica_2
{
    public class Registro
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Rango { get; set; }
        public Registro(string nombre, string contraseña, string rango)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            Rango = rango;
        }
    }
}
