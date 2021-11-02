using BA_SOLID.SRP.Entity;
using BA_SOLID.SRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.SRP.Good
{
    public class GoodEmployeeProcessor
    {
        Logger _logger;
        string _log;
        public GoodEmployeeProcessor()
        {
            // Dependy olma söz konusu; Ancak Dependency Inversion yoktur.
            _logger = new Logger();
        }

        public bool InsertEmployee(Employee newEmployee)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append(newEmployee.Id);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.LastName);
                sb.AppendLine();
                sb.Append(newEmployee.HireDate);
                _log = _logger.BuildLog(sb.ToString());
                _logger.LogFile(@"C:\inetpub\MyLogs\EmployeeInsert.txt", _log);

                sb = new StringBuilder();
                sb.Append("Eklenme Tarihi : ");
                sb.AppendLine();
                sb.Append(DateTime.Now);
                sb.AppendLine();
                sb.Append("ID : ");
                sb.Append(newEmployee.Id);
                _log = _logger.BuildLog(sb.ToString());
                // C:\ dizini altında boş oluşturduğumuz txt dosyası Log tutması için yaptık.
                _logger.LogFile(@"C:\inetpub\MyLogs\Logs.txt", _log);
                return true;
            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Hata Tarihi : ");
                sb.AppendLine();
                sb.Append(DateTime.Now);
                sb.AppendLine();
                sb.Append("Hata Mesajı : ");
                sb.Append(ex.Message);
                _log = _logger.BuildLog(sb.ToString());
                // C:\ dizini altında boş oluşturduğumuz txt dosyası Log tutması için yaptık.
                _logger.LogFile(@"C:\inetpub\MyLogs\Logs.txt", _log);
                Console.WriteLine("Kayıt işleminde hata oluştu.");
                return false;
            }
        }
    }
}
