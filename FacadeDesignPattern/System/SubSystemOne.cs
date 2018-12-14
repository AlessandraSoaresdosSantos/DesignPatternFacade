using FacadeDesignPattern.System.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern.System
{
    public class SubSystemOne: ISubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("SubSystem One");
        }

    }
}
