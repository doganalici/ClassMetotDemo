using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Bankamıza Hoşgeldiniz Sayın : "+musteri.MusteriAdi+""+musteri.MusteriSoyadi );
            Console.WriteLine();
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine();
            Console.WriteLine("Müşteri Adı : "+musteri.MusteriAdi+"\n"+"Müşteri Soyadı : "+musteri.MusteriSoyadi+"\n"+
                                "Müşteri Yaşı : "+musteri.MusteriYasi+"\n"+"Müşteri Şehri : "+musteri.MusteriSehir+"\n");
        }
        public void Deletion(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşterinin ; \n"+"\n"+ "Adı : "+musteri.MusteriAdi+"\n"+"Soyadı : "+musteri.MusteriSoyadi+"\n"+
                                "Yaşı : "+musteri.MusteriYasi+"\n");
        }

    }
}


