using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.LSP.Good
{
    // Daire ile ilgili hesaplama
    public class Square : Shape
    {
        public int Width { get; set; }
        
        public double Hesapla()
        {
            return Width * Width;
        }
    }
}
