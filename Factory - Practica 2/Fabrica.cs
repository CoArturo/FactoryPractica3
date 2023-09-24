using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory___Practica_2
{
    class Fabrica
    {
        public static IRango GetRango(string tipos)
        {
            if (tipos == "empleado")
            {
                return new Empleado();
            }
            else if (tipos == "cliente")
            {
                return new Cliente();
            }
            else if (tipos == "proveedor")
            {
                return new Proveedor();
            }
            else
            {
                throw new ArgumentException("Valor no válido para tipos");
            }
        }
    }
}
