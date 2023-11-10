using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    internal class CalculadoraServidor
    {
        public int Sumar(int x, int y)
        {
            return x + y;
        }

        public int Restar(int x, int y)
        {
            return x - y;
        }

        public int Multiplicar(int x, int y)
        {
            return x * y;
        }

        public int Dividir(int x, int y)
        {
            return x / y;
        }
    }
}
