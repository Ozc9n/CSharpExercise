using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager tasitKredi = new TasitKrediManager();
            IKrediManager ihtiyacKredi = new IhtiyacKrediManager();
            IKrediManager konutKredi = new KonutKrediManager();
            //kredi1.Hesapla();

            ILoggerService smsLoggerService = new SmsLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKredi,new SmsLoggerService());
            //basvuruManager.BasvuruYap(ihtiyacKredi,new DatabaseLoggerService());
            //basvuruManager.BasvuruYap(konutKredi,new SmsLoggerService());
            // --------------------------------------------------------
            basvuruManager.BasvuruYap(tasitKredi,smsLoggerService);
            basvuruManager.BasvuruYap(ihtiyacKredi,databaseLoggerService);
            basvuruManager.BasvuruYap(konutKredi,fileLoggerService);
            // SOLID prensipinin O harfi güncellemelerin kodları etkilememesi
            basvuruManager.BasvuruYap(new EsnafKrediManager(), smsLoggerService);



            // !!!İnterfaceleri birbirinin alternatifi fakat içeriği farklı olan operasyonlar için kullanılır...!!!


            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKredi,ihtiyacKredi,konutKredi};
            //basvuruManager.KrediBilgilendir(krediler);


        }
    }
}
