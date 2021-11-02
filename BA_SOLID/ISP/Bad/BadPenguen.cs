using BA_SOLID.ISP.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.ISP.Bad
{
    public class BadPenguen : IWalk /*IBird*/
    {
        public string Walk()
        {
            throw new NotImplementedException();
        }
    }
    //{
    //    public string Fly()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public string Walk()
    //    {
    //        throw new NotImplementedException();
    //    }
}
}
