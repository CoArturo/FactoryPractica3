using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory___Practica_2
{
    class RegistroTickets
    {
        public static RegistroTickets? instance = null;
        public static readonly object lockObject = new object();
        public string logFileName = "registro_operaciones.txt";

        private RegistroTickets() { }

        public static RegistroTickets Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new RegistroTickets();
                    }
                    return instance;
                }
            }
        }

        public void AgregarRegistro(string usuario, string rango, string incidencia, string detalle)
        {
            string logLine = @$"====================================================================
Fecha de reporte: {DateTime.Now}
Usuario:  {usuario} ({rango})
Tipo de incidencia: {incidencia}
Detalle: {detalle}                                                  
====================================================================
";

            using (StreamWriter writer = new StreamWriter(logFileName, true))
            {
                writer.WriteLine(logLine);
            }
        }
    }
}
