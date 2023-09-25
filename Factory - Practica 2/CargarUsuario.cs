using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Factory___Practica_2
{
    public class CargarUsuario
    {
        private const string archivoUsuarios = "usuario.json";
        public static List<Registro> usuario = new List<Registro>();
        public static List<Registro> CargarUsuarios()
        {
            string json = File.ReadAllText(archivoUsuarios);
            List<Registro>? usuarios = JsonConvert.DeserializeObject<List<Registro>>(json);
            return usuarios ?? new List<Registro>();
        }
    }
}
