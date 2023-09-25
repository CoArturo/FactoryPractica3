using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory___Practica_2
{
    class Cliente: IRango
    {
        public static RegistroTickets registro = RegistroTickets.Instance;
        List<Registro> usuarios = CargarUsuario.CargarUsuarios();
        public void MenuRango()
        {
            string[] ClientesProblemas = { "Problemas con productos o servicios adquiridos.", "Problemas de facturación o pagos.", "Problemas de atención al cliente.", "Sugerencias para mejorar productos o servicios." };
            int num = 1;
            while (true)
            {
                Console.WriteLine($"Beinvenido {Iniciarsesion.UsuarioActual?.Rango} {Iniciarsesion.UsuarioActual?.Nombre} al sistema de reportes de incidencias.");
                Console.WriteLine();
                Console.WriteLine("Que incidencia le gustaria reportar.");
                Console.WriteLine();
                foreach (string problema in ClientesProblemas)
                {
                    Console.WriteLine(num + "- " + $"{ClientesProblemas[num - 1]}");
                    num++;
                }
                Console.WriteLine();
                Console.Write("Opcion: ");
                int op = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine($"Asunto: {ClientesProblemas[op - 1]}");
                Console.WriteLine("Detalle de incidencia:");
                string detalle = Console.ReadLine();
                while (string.IsNullOrEmpty(detalle))
                {
                    Console.Clear();
                    Console.WriteLine("Por favor, ingrese un detalle válido de la incidencia:");
                    Console.WriteLine("Detalle de incidencia:");
                    detalle = Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("Reporte hecho");
                registro.AgregarRegistro(Iniciarsesion.UsuarioActual.Nombre, $"{Iniciarsesion.UsuarioActual.Rango}", $"{ClientesProblemas[op - 1]}", $"{detalle}");
                Console.ReadLine();
            }
        }
    }
}