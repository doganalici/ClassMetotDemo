using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Doğan";
            musteri1.MusteriSoyadi = "Alıcı";
            musteri1.MusteriYasi = 23;
            musteri1.MusteriSehir = "Malatya";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Abdullah";
            musteri2.MusteriSoyadi = "Göçeren";
            musteri2.MusteriYasi = 21;
            musteri2.MusteriSehir = "Konya";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Murat Can";
            musteri3.MusteriSoyadi = "Tetik";
            musteri3.MusteriYasi = 22;
            musteri3.MusteriSehir = "Ankara";

            Console.WriteLine("------------------EKLENEN MÜŞTERİLER------------------\n");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            Console.WriteLine("------------------MÜŞTERİ LİSTESİ------------------\n");
            musteriManager.List(musteri1);
            musteriManager.List(musteri2);
            musteriManager.List(musteri3);

            Console.WriteLine("------------------SİLİNEN MÜŞTERİ LİSTESİ------------------");
            musteriManager.Deletion(musteri2);
        }
    }
}
