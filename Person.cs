using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGI
{
    class Person
    {
        private double life = 100;
        private double attack;
        private readonly double defence;
        string name;

        public double hurt(int attacked)
        {
            double decLife = attacked * defence;
            life -= decLife;
            return decLife;
        }
    }
}
