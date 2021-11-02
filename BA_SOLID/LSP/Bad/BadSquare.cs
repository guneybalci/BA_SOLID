using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.LSP.Bad
{
    // Daire ile ilgili hesaplama
    public class BadSquare : BadRentangle
    {
        int _height;
        int _widht;

        public override int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                _widht = value;
            }
        }


        public override int Width
        {
            get
            {
                return _widht;
            }
            set
            {
                _height = value;
                _widht = value;
            }

        }
