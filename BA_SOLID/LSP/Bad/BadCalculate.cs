using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.LSP.Bad
{
    public class BadCalculate
    {
        public static double HesaplaArea(BadRentangle badRentangle)
        {
            return badRentangle.Width * badRentangle.Height;
        }

        public static double HesaplaArea(BadSquare badSquare)
        {
            return badSquare.Width * badSquare.Height;
        }
    }
}
