using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.LSP.Bad
{
    // Dikdörtgen ile ilgili hesaplama
    public class BadRentangle
    {
        // virtual: Inherit edildiği yerde override edilebilir demektir!
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }
}
