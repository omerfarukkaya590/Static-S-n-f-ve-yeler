System.Console.WriteLine("Çalışan Sayısı : {0}", Calısan.CalısanSayısı1);

Calısan calisan1= new Calısan("Ömer Arda", "Kurt","Makine Donanımı");
System.Console.WriteLine("Çalışan Sayısı : {0}", Calısan.CalısanSayısı1);
Calısan calisan2= new Calısan("Ömer Faruk", "Kaya","Yazılım Mühendisliği");
Calısan calisan3= new Calısan("Ege", "Eskenazi","CEO");
System.Console.WriteLine("Çalışan Sayısı : {0}", Calısan.CalısanSayısı1);

System.Console.WriteLine("Toplama işlemi sonucunuz: {0}",işlemler.Topla(110,130));   
System.Console.WriteLine("Toplama işlemi sonucunuz: {0}", işlemler.Çıkar(20,100)); 

class Calısan
{
    private static int calısanSayısı;

    public static int CalısanSayısı1 { get => calısanSayısı; }

    private string Isim;
    private string Soyisim;
    private string Departman;

    static Calısan()
    {
        calısanSayısı=0;

    }

    public Calısan(string ısim, string soyisim, string departman)
    {
        Isim = ısim;
        Soyisim = soyisim;
        Departman = departman;
        calısanSayısı++;
    }
}

static class işlemler
{
    public static long Topla(int sayı1, int sayı2)
    {
        return sayı1+ sayı2;
    }
    public static long Çıkar(int sayı1, int sayı2)
    {
        return sayı1-sayı2;
    }
} 