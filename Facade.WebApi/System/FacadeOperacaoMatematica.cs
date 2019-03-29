using FacadeWebApi.System.Classes;
using FacadeWebApi.System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadeWebApi.System
{
    public class FacadeOperacaoMatematica : IFacadeOperacaoMatematica
    {
        IClassDividirValor _classDividirValor;
        IClassMultiplicarValor _classmultiplicarValor;
        IClassSomarValor _classSomarValor;
        IClassSubtrairValor _classSubtrairValor;


        public FacadeOperacaoMatematica()
        {
            _classDividirValor = new ClassDividirValor();
            _classmultiplicarValor = new ClassMultiplicarValor();
            _classSomarValor = new ClassSomarValor();
            _classSubtrairValor = new ClassSubtrairValor();
        }

        public double Dividir(double valorA, double valorB)
        {
            return _classDividirValor.DividirValor(valorA, valorB);
        }

        public double Multiplicar(double valorA, double valorB)
        {
            return _classmultiplicarValor.MultiplicarValor(valorA, valorB);
        }

        public double Somar(double valorA, double valorB)
        {
            return _classSomarValor.SomarValor(valorA, valorB);
        }

        public double Subtrair(double valorA, double valorB)
        {
            return _classSubtrairValor.SubtrairValor(valorA, valorB);
        }

    }
}
