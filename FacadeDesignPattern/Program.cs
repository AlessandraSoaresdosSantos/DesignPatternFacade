using System;



namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.Funcionalities();

            Console.ReadKey();
            
        }
    }
}
