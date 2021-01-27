using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {

            // Çok önemli bir nokta
            krediManager.Hesapla();
            // dependincies injection 
            loggerService.Log();
            // Bütün hesaplamalar taşıt kredisi üzerinden yapılır.new yapmaktan çekin !!!
            //TasitKrediManager kredi1 = new TasitKrediManager();
            //kredi1.Hesapla();
        }
        public void KrediBilgilendir(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
