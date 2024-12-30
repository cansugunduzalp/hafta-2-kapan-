// using System;

class Program
{
    static void Main()
    {
        // İstenilen çıktıyı yazdırma
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın ?");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın ?");
    }

}









using System;

class 
    
    Program
{
    static void Main()
    {
        // Metinsel veri için değişken
        string metin = "Merhaba Dünya!";

        // Tam sayı veri için değişken
        int sayi = 42;

        // Değişkenlerin değerlerini ekrana yazdırma
        Console.WriteLine("Metin: " + metin);
        Console.WriteLine("Sayı: " + sayi);
    }
}








using System;

class Program
{
    static void Main()
    {
        // 20 sayısını ekrana yazdırma
        Console.WriteLine(20);
    }
}







using System;

class Program
{
    static void Main()
    {
        // 15 sayısının 3'e bölümünden kalanı bulma
        int sayi = 15;
        int kalan = sayi % 3;

        // Kalanı ekrana yazdırma
        Console.WriteLine("15 sayısının 3'e bölümünden kalan: " + kalan);
    }
}
  




using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan yaşını al
        Console.Write("Yaşınızı girin: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        // Yaşın 18'den büyük mü, küçük mü olduğunu kontrol et
        if (yas > 18)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}











using System;

class Program
{
    static void Main()
    {
        // 10 defa aynı metni yazdırmak için bir döngü kullanıyoruz
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
        }
    }
}









using System;

class Program
{
    static void Main()
    {
        // Sabit isimler
        string isim1 = "Gülse Birsel";
        string isim2 = "Demet Evgar";

        // İsimlerin yerlerini değiştirme
        Console.WriteLine($"İlk isim: {isim2}, İkinci isim: {isim1}");
    }
}








using System;

class Program
{
    static void Main()
    {
        // Metodu çağırıyoruz
        BenDegerDondurmem();
    }

    // Değer döndürmeyen metot
    static void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma.");
    }
}







using System;

class Program
{
    static void Main()
    {
        // Metodu çağırarak toplamı alıyoruz
        int toplam = ToplamHesapla(4, 5);

        // Toplamı ekrana yazdırıyoruz
        Console.WriteLine("Toplam: " + toplam);
    }

    // 2 sayının toplamını döndüren metot
    static int ToplamHesapla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
}














using System;

class Program
{
    static void Main()
    {
        // 10, 20 ve 30 yaşındaki kişilerin yaşlarını alıyoruz
        int yas1 = 10;
        int yas2 = 20;
        int yas3 = 30;

        // En yaşlı kişinin yaşını bulmak için metodu çağırıyoruz
        int enYasli = EnYasliYas(yas1, yas2, yas3);

        // Sonucu ekrana yazdırıyoruz
        Console.WriteLine("En yaşlı kişinin yaşı: " + enYasli);
    }

    // 3 kişinin yaşını alıp en yaşlı olanının yaşını döndüren metot
    static int EnYasliYas(int yas1, int yas2, int yas3)
    {
        // En büyük yaşı bulmak için Math.Max kullanıyoruz
        int enYasli = Math.Max(yas1, Math.Max(yas2, yas3));
        return enYasli;
    }
}










