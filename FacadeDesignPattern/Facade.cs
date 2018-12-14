using FacadeDesignPattern.System;
using FacadeDesignPattern.System.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
   public class Facade
    {
        ISubSystemOne _systemOne;
        ISubSystemTwo _systemTwo;


        public Facade() {
            _systemOne = new SubSystemOne();
            _systemTwo = new SubSystemTwo();
        }

        public void Funcionalities() {
            Console.WriteLine("-- Funcionalities ==> Method SystemOne ---");
            _systemOne.MethodOne();

            Console.WriteLine("-- Funcionalities ==> Method Systemtwo ---");
            _systemTwo.MethodTwo();
        }

    }
}
