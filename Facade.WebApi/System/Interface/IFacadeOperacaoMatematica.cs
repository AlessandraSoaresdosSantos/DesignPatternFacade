using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadeWebApi.System.Interface
{
    public interface IFacadeOperacaoMatematica
    {
        double Dividir(double valorA, double valorB);

        double Multiplicar(double valorA, double valorB);

        double Somar(double valorA, double valorB);

        double Subtrair(double valorA, double valorB);
    }
}
