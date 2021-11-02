using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP.Good.Abstract
{
    public abstract class GoodCoffee
    {
        /*Abstract class Member'i abstrach ise uygulanmak zorunda kalanlardır*/
        // virtual: ile method imzalanırsa Inherit edildiği yerde override edilebilir demektir!
        public abstract double FiyatHesapla(double miktar);
    }
}
