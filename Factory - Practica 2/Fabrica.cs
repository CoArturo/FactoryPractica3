using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory___Practica_2
{
    public class Fabrica
    {
        public static IRango GetRango(string tipos)
        {
            switch (tipos)
            {
                case "empleado":
                    return new Empleado();

                case "cliente":
                    return new Cliente();

                case "administrador":
                    return new Administrador();

                case "proveedor":
                    return new Proveedor();

                default: return null;

            }
        }
    }
}
