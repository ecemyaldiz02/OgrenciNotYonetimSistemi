using System;
using System.Collections.Generic;

public class Ogrenci
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Not { get; set; }
}

class Program
{
    static List<Ogrenci> ogrenciler = new List<Ogrenci>();

    static void Main(string[] args)
    {
        MenuGoster();
    }

    static void MenuGoster()
    {
        while (true)
        {
            Console.WriteLine("\n--- Öğrenci Not Yönetim Sistemi ---");
            Console.WriteLine("1. Öğrenci Ekle");
            Console.WriteLine("2. Öğrenci Listesini Göster");
            Console.WriteLine("3. Not Ortalamasını Hesapla");
            Console.WriteLine("4. Çıkış");

            Console.Write("Seçiminizi yapın (1-4): ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    OgrenciEkle();
                    break;
                case "2":
                    OgrenciListesiniGoster();
                    break;
                case "3":
                    NotOrtalamasiHesapla();
                    break;
                case "4":
                    Console.WriteLine("Programdan çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Tekrar deneyin.");
                    break;
            }
        }
    }

    static void OgrenciEkle()
    {
        Console.Write("Öğrenci adı: ");
        string ad = Console.ReadLine();

        Console.Write("Öğrenci soyadı: ");
        string soyad = Console.ReadLine();

        Console.Write("Öğrenci notu (0-100): ");
        int not = int.Parse(Console.ReadLine());

        ogrenciler.Add(new Ogrenci { Ad = ad, Soyad = soyad, Not = not });
        Console.WriteLine("Öğrenci başarıyla eklendi.");
    }

    static void OgrenciListesiniGoster()
    {
        Console.WriteLine("\n--- Öğrenci Listesi ---");

        if (ogrenciler.Count == 0)
        {
            Console.WriteLine("Henüz öğrenci eklenmedi.");
            return;
        }

        foreach (var ogrenci in ogrenciler)
        {
            Console.WriteLine($"Ad: {ogrenci.Ad}, Soyad: {ogrenci.Soyad}, Not: {ogrenci.Not}");
        }
    }

    static void NotOrtalamasiHesapla()
    {
        if (ogrenciler.Count == 0)
        {
            Console.WriteLine("Henüz öğrenci eklenmedi.");
            return;
        }

        double toplam = 0;

        foreach (var ogrenci in ogrenciler)
        {
            toplam += ogrenci.Not;
        }

        double ortalama = toplam / ogrenciler.Count;
        Console.WriteLine($"Sınıfın not ortalaması: {ortalama:F2}");
    }
}
