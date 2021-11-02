using BA_SOLID.OCP.Good.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP.Good.Concrete
{
    public class Americano : GoodCoffee
    {
        public override double FiyatHesapla(double miktar)
        {

            return miktar * 5.25;
        }
    }
}
