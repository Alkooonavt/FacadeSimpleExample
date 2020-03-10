using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var telephone = new Facade(new Telephone());
            telephone.On();
            Console.WriteLine();
            telephone.Off();
        }
    }
}
