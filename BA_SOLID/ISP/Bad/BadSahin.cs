using BA_SOLID.ISP.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.ISP.Bad
{
    public class BadSahin : IFly /*IBird*/
    {
        public string Fly()
        {
            throw new NotImplementedException();
        }
    }
}
