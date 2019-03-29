using FacadeWebApi.System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadeWebApi.System.Classes
{
    public class ClassMultiplicarValor: IClassMultiplicarValor
    {
        public ClassMultiplicarValor() { }

        public double MultiplicarValor(double valorA, double valorB)
        {

            return valorA * valorB;
        }

    }
}
