using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeMechine
{
    class Milk
    {
        private int neto = 0;
        private int oneCupCoffe = 100;

        public Milk(int neto)
        {
            this.neto = neto;
        }

        public Boolean isAvailable()
        {
            return this.neto >= this.oneCupCoffe;
        }

        public void makeOneCup()
        {
            this.neto = this.neto - oneCupCoffe;
        }

        public int getNeto()
        {
            return this.neto;
        }
    }
}
