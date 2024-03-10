//Degiskenler();

using Business.Concrete;
using Entities.Concrete;

Vatandas vatandas1 = new Vatandas();

SelamVer("Ömer");
SelamVer("Ayşe");
SelamVer("Engin");
SelamVer();

int sonuc = Topla(3, 5);

// Diziler /Arrays

string ogrenci1 = "Engin";
string ogrenci2 = "Berkay";
string ogrenci3 = "Deniz";

Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci3);
Console.WriteLine(ogrenci2);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Berkay";
ogrenciler[2] = "Deniz";
// ogrencilerr[3] = "Kerem";

ogrenciler = new string[4];
ogrenciler[3] = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
//sehirler2[4] = "Selami";
foreach (string s in sehirler2)
{
    Console.WriteLine(sehirler2);
}
sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "Ömer";
person1.LastName = "Yıldırım";
person1.NationalIdentity = 69376189504;
person1.DateOfBirthYear = 1999;

Person person2 = new Person();
person2.FirstName = "Engin";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Ankara");
foreach (var item in yeniSehirler1)
{
    Console.WriteLine(item);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);







static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba" + " " + isim);
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam" + " " + sonuc);
    return sonuc;
}

static void Degiskenler()
{
    string mesaj = "Selam";
    double tutar = 100000; // db'den gelir.
    int sayi1 = 100;
    bool girisYapmisMi = false;

    string ad = "Ömer";
    string soyad = "Yıldırım";
    int dogumYili = 1999;
    long tcNo = 12121211212;


    Console.WriteLine(mesaj);
    Console.WriteLine(mesaj);
}

// Pascal Casing
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}
