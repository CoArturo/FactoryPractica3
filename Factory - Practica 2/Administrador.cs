using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory___Practica_2
{
    public class Administrador: IRango
    {
        public static RegistroTickets? registro = RegistroTickets.Instance;
        List<Registro> usuarios = CargarUsuario.CargarUsuarios();
        public void MenuRango()
        {
            string[] lines = File.ReadAllLines(registro.logFileName);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            
            Console.ReadLine();
        }
    }
}
