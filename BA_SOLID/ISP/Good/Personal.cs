using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.ISP.Good
{
    public class Personal : IDisposable
    {
        public string AdSoyad { get; set; }

        public void Dispose()
        {
            // Log, Mail, Sms >>> Verinin Son Halini Kaydetme Yöntemi.
            throw new NotImplementedException();
        }
    }
}
