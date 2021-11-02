using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP.Bad
{
    public enum CoffeType
    {
        Latte,
        Espresso,
        Americano
    }
    public class BadCoffee
    {
        public double KahveFiyati(double miktar, CoffeType type)
        {
            double toplamFiyat = 0;

            // Bad Code: Böyle bir yapı kurarsak her seferinde bir ürün eklendiğinde yeni bir else-if eklememiz gerekicekti. (Örn: Macchiato) bunun çözümü ise bir Abstrach Class yapısı kurarak yeni bir class ekleyerek işlemi çözebiliriz.

         
            if (type == CoffeType.Latte)
            {
                toplamFiyat = miktar * 4;
            }
            else if (type == CoffeType.Espresso)
            {
                toplamFiyat = miktar * 4.5;
            }
            else if (type == CoffeType.Americano)
            {
                toplamFiyat = miktar * 5.25;
            }


            return toplamFiyat;
        }
    }
}
