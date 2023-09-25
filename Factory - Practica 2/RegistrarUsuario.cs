using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Factory___Practica_2
{
    public class RegistrarUsuario
    {
        private const string archivoUsuarios = "usuario.json";
        public static List<Registro> usuario;
        List<Registro> usuarios;
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
                usuarios = CargarUsuario.CargarUsuarios();
                usuario = new List<Registro>();
                usuarios.Add(new Registro("Waniel", "5656", "Empleado"));
                usuarios.Add(new Registro("Abel", "1234", "Administrador"));
                usuarios.Add(new Registro("Engel", "5678", "Proveedor"));
                usuarios.Add(new Registro("Jose", "4321", "Cliente"));
                usuarios.Add(new Registro("Juan Rosario", "4565", "Administrador"));

                GuardarUsuario.GuardarUsuarios(usuarios);
            }
        }
    }
}
