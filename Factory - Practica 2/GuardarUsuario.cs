using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Factory___Practica_2
{
    class GuardarUsuario
    {
        private const string archivoUsuarios = "usuario.json";
        public static List<Registro> usuario = new List<Registro>();
        public static void GuardarUsuarios(List<Registro> usuarios)
        {
            string json = JsonConvert.SerializeObject(usuarios);
            File.WriteAllText(archivoUsuarios, json);
        }
    }
}
