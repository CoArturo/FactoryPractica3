using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Factory___Practica_2
{

    public class Iniciarsesion
    {
        private const string archivoUsuarios = "usuario.json";
        public static List<Registro> usuario = new List<Registro>();
        List<Registro> usuarios = CargarUsuario.CargarUsuarios();
        public static Registro? UsuarioActual;
        public static void IniciarSesion(List<Registro> usuarios)
        {
            Console.Clear();
            CargarUsuario.CargarUsuarios();
            Console.WriteLine(@"====================================
|Usuarios registrados y disponibles|
====================================");
            foreach (Registro registro in usuarios)
            {
                Console.WriteLine(@$"Nombre: {registro.Nombre} 
Contraseña: {registro.Contraseña} 
Rango: {registro.Rango}
");
            }

            Console.Write("Ingresa tu nombre de usuario: ");
            string nombreUsuario = Console.ReadLine();

            Console.Write("Ingresa tu contraseña: ");
            string contraseña = Console.ReadLine();

            Registro usuario = usuarios.Find(u => u.Nombre == nombreUsuario && u.Contraseña == contraseña);

            if (usuario != null)
            {
                Console.Clear();
                UsuarioActual = usuario;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nombre de usuario o contraseña incorrectos.");
                Console.ReadLine();
                IniciarSesion(usuarios);
            }
        }
    }
}
