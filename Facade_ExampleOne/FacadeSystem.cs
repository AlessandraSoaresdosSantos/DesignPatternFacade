using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_ExampleOne
{
      class FacadeSystem
    {
        private SubSystemOne _one;

        public FacadeSystem() {
            _one = new SubSystemOne();
        }

        public void MethodA() {
            Console.WriteLine("\n FacadeSystem - MethodA");
            _one.MethodOne();
        }
    }
}
