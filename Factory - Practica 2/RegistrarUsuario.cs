using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Factory___Practica_2
{
    class RegistrarUsuario
    {
        private const string archivoUsuarios = "usuario.json";
        public static List<Registro> usuario = new List<Registro>();
        List<Registro> usuarios = CargarUsuario.CargarUsuarios();
        public static void Registrarse(List<Registro> usuarios)
        {
            if (usuarios.Any(u => u.Nombre != null))
            {
                Console.Clear();
                Console.WriteLine("Los usuarios ya fueron cargados previamente.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                usuarios.Add(new Registro("Waniel", "5656", "Empleado"));
                usuarios.Add(new Registro("Abel", "1234", "Administrador"));
                usuarios.Add(new Registro("Engel", "5678", "Proveedor"));
                usuarios.Add(new Registro("Jose", "4321", "Cliente"));
                GuardarUsuario.GuardarUsuarios(usuarios);
            }
        }
    }
}
