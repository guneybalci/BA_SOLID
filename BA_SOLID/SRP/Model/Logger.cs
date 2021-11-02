using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.SRP.Model
{
    public class Logger
    {
        public void LogFile(string path, string log)
        {
            File.WriteAllText(path, log);
        }

        public string BuildLog(string information)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Tarih :");
            sb.AppendLine();
            sb.Append(DateTime.Now);
            sb.AppendLine();
            sb.Append("Info : ").Append(information);
            return sb.ToString();
        }
    }
}
