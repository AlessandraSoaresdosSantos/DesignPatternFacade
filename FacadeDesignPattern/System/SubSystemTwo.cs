using FacadeDesignPattern.System.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern.System
{
    public class SubSystemTwo: ISubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("SubSystem Two");
        }
    }
}
