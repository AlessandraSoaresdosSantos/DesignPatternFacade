using FacadeWebApi.System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadeWebApi.System.Classes
{
    public class ClassSomarValor: IClassSomarValor
    {
        public ClassSomarValor() { }

        public double SomarValor(double valorA, double valorB)
        {
            return valorA + valorB;
        }

    }
}
