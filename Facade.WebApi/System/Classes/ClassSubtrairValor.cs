using FacadeWebApi.System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadeWebApi.System.Classes
{
    public class ClassSubtrairValor: IClassSubtrairValor
    {
        public ClassSubtrairValor() { }

        public double SubtrairValor(double valorA, double valorB)
        {
            if (valorA < valorB)
            {
                return valorB - valorA;
            }

            return valorA - valorB;
        }
    }
}
