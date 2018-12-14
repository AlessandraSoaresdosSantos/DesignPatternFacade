using System;
 

namespace Facade_ExampleOne
{
      class PrincipalSystem
    {
        static void Main(string[] args) { 
            FacadeSystem facade = new FacadeSystem();

            facade.MethodA();

            Console.ReadKey();
        }
    }
}
