using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public  class Facade
    {
        private Telephone telephone;
        public Facade(Telephone telephone)
        {
            this.telephone= telephone;
        }
        public void On()
        {
            telephone.MakeVibration();
            telephone.MakeSound();
            telephone.ShowLoadingScreen();
        }
        public void Off()
        {
            telephone.CloseEverything();
            telephone.Sleep();
        }
    }
}
