using BA_SOLID.SRP.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.SRP.Bad
{
    public class BadEmployeeProcessor
    {

        public void InsertEmployee(Employee newEmployee)
        {
            // Yanlış Kullanım Sebebi : Hem veriyi kaydetme, hem loglama, hem hata işlemi yapmasıdır.
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
                // C:\ dizini altında boş oluşturduğumuz txt dosyası Log tutması için yaptık.
                File.WriteAllText(@"C:\inetpub\MyLogs\EmployeeInsert.txt", sb.ToString());

                sb = new StringBuilder();
                sb.Append("Eklenme Tarihi : ");
                sb.AppendLine();
                sb.Append(DateTime.Now);
                sb.AppendLine();
                sb.Append("ID : ");
                sb.Append(newEmployee.Id);
                // C:\ dizini altında boş oluşturduğumuz txt dosyası Log tutması için yaptık.
                File.WriteAllText(@"C:\inetpub\MyLogs\Logs.txt", sb.ToString());


                Console.WriteLine("Çalışan Başarı ile kaydedildi.");
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
                // C:\ dizini altında boş oluşturduğumuz txt dosyası Log tutması için yaptık.
                File.WriteAllText(@"C:\inetpub\MyLogs\Logs.txt", sb.ToString());

                Console.WriteLine("Kayıt işleminde hata oluştu.");
            }
        }
    }
}
