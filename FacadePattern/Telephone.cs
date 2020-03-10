using System;

namespace FacadePattern
{
  
        public class Telephone
        {
            public void MakeVibration()
            {
             Console.WriteLine("Dr....");
            }

            public void MakeSound()
            {
                Console.WriteLine("Tun Tun");
            }

            public void ShowLoadingScreen()
            {
                Console.WriteLine("Loading...");
            }

            public void CloseEverything()
            {
                Console.WriteLine("tuz");
            }

            public void Sleep()
            {
                Console.WriteLine("uiktaimiz");
            }
        }
    
}
