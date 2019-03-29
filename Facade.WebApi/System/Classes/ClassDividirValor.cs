using FacadeWebApi.System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadeWebApi.System.Classes
{
    public class ClassDividirValor: IClassDividirValor
    {
        public ClassDividirValor() { }

        public double DividirValor(double valorA, double valorB)
        {
            return valorA / valorB;
        }

    }
}
