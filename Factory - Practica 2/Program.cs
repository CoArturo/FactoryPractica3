using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Factory___Practica_2
{
    class Programa
    {
        static void Main(string[] args)
        {
            List<Registro> usuarios = CargarUsuario.CargarUsuarios();
            Iniciarsesion.IniciarSesion(usuarios);
            Console.Clear();
            string valor = Iniciarsesion.UsuarioActual.Rango.ToLower();
            IRango rango = Fabrica.GetRango(valor);

            rango.MenuRango();
            Console.ReadKey();
            Main(args);

        }
    }
}

