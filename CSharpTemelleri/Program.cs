
void IsimAlmaPratigi()
{
    Console.WriteLine("Lütfen Adınızı Giriniz = ");
    //Boş bırakılabilir karakter dizisi (Nullable String) anlamına gelir.
    // var da kullanabilirsin. Sağdaki değere bakıp türü otomatik belirler (string ise string, int ise int yapar) ve o türde sabit kalır.
    string? name = Console.ReadLine();
    Console.WriteLine("Merhaba " + name);
}
void NullableOrnek()
{
    var age = 18;
    var name = "Ali";
    Console.WriteLine("Age değişkeninin türü: " + age.GetType());
    Console.WriteLine("Name değişkeninin türü: " + name.GetType());
    string nullable = null; // Eğer ki böyle çalışırsa hata verir çünkü burada nullablenin içi boş. Hata vermesini önlemek için değişkenin yanına "?" eklenmelidir.
    Console.WriteLine("Büyük Harf : " + nullable?.ToUpper());
    Console.WriteLine("Kullanıcı Adı : " + (nullable ?? "Bilinmiyor"));//?? ise eğerki soldaki (nullable) değer null değil ise onu kullan eğer null ise "Bilinmiyor" sağındakini kullan.
    Console.WriteLine("Yaş : " + age);
}

void Degiskenler()
{
    //Tam Sayı Değişkeni.
    int age = 18;
    Console.WriteLine($"Yaş : {age}");

    //Ondalıklı Sayı Değişkeni.
    const double piValue = 3.14; // Const Değiştirilemezdir. Yani artık bu piValue'nin değeri sabit kalacaktır.
    Console.WriteLine($"Pi Değeri: {piValue}");

    //String İfadesi.
    var city = "Samsun";
    string city1 = "İstanbul";
    Console.WriteLine($"Şehir: {city}");
    
    //Tarih İfadesi.

    var time=DateTime.Now;
    Console.WriteLine($"Tarih : {time}");
}
void AritmetikOperatorler()
{

    int a = 5;
    int b = 2;
    int c = a*b;
    int d = a / b;
    int f= a % b;
    // Toplama
    Console.WriteLine($"Toplam : {a}+{b} = {a + b}");
    // Fark
    Console.WriteLine($"Fark : {a}-{b} = {a - b}");
    // Çarpım
    Console.WriteLine($"Çarpım : {a}*{b} = {c}");
    // Bölme
    Console.WriteLine($"Bölme : {a}/{b} = {d}");
    // Mod
    Console.WriteLine($"Mod : {a}%{b} = {f}");
}

// int.Parse -> null veya harf gelirse hata verir.
// Convert.ToInt32 -> null gelirse 0 döner ama harf gelirse hata verir.
// int.TryParse -> null veya harf fark etmez, asla hata vermez (false döner).
void KarsilastirmaOperatorleri()
{
    Console.WriteLine("Birinci Sayıyı Giriniz = ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("İkinci Sayıyı Giriniz = ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{a}!={b} = {a!=b}");
    Console.WriteLine(a + "==" + b + " = " + (a == b));
    Console.WriteLine($"{a}>{b} = {a>b}");
    Console.WriteLine(a + "<" + b + " = " + (a < b));
}

void TryParseMantigi()
{
    Console.Write("Bir sayı giriniz: ");
    if(int.TryParse(Console.ReadLine(),out int sonuc)) // Başarılı olursa 'out int sonuc' içine sayıyı atar ve true döner, başarısızsa false döner.
    {
        Console.WriteLine($"Geçerli Sayı = {sonuc}" );
    }
    else
    {
        Console.WriteLine($"Lütfen geçerli bir sayı giriniz");
    }
}
void MantiksalOperatorler()
{
    string? reportInput;
    int yas;
    Console.WriteLine("Lütfen Yaşınızı Giriniz: ");
    while (!int.TryParse(Console.ReadLine(), out  yas)) // Yaşa null bir değer atanma olasılığından dolayı null değeri kesinlikle kabul etmiyorum
                                                        // ve geçerli yaş girene kadar while döngüsünde devam ediyor.
    {
        Console.WriteLine("Lütfen Geçerli Bir Yaş giriniz.");
    }
    while(true) //Burada ise sağlık raporu evet veya hayır olana kadar while döngüsünde tutuyorum aksi taktirde sürmeye devam ediyor.
    {
        Console.WriteLine("Sağlık Raporunuz Var mı? (Evet/Hayır)");
        reportInput = Console.ReadLine()?.Trim().ToLower();
        if (reportInput == "evet" || reportInput == "hayır")
        {
            break;
        }
        Console.WriteLine("Hatalı Giriş! Lütfen sadece 'evet' veya 'hayır' yazınız \n");
    }
    if(reportInput!="evet")
    {
        Console.WriteLine("Sağlık Raporu Olmadan İşleme Devam Edemezsiniz.");
        return;
    }
    if (yas >= 18 && reportInput == "evet")
    {
        Console.WriteLine("Ehliyet Alabilirsiniz");
    }
    else
    {
        Console.WriteLine("Ehliyet Alma şartlarını sağlamıyorsunuz");
    }
}

void HesapMakinesi()
{
    double sayi1, sayi2;
    Console.WriteLine("Birinci Sayıyı Giriniz = ");
    while(!double.TryParse(Console.ReadLine(), out sayi1))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz.");
        Console.ResetColor();
    }
    Console.WriteLine("İkinci Sayıyı Giriniz = ");
    while(!double.TryParse(Console.ReadLine(), out sayi2))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
        Console.ResetColor();
    }
    double toplama = sayi1 + sayi2;
    double fark = sayi1 - sayi2;
    double carpim = sayi1 * sayi2;


    Console.WriteLine("\n--- Sonuçlar ---");
    Console.WriteLine($"Toplam : {toplama}");
    Console.WriteLine($"Fark : {fark}");
    Console.WriteLine($"Çarpım : {carpim}");

    if(sayi2!=0)
    {
        double bolum = sayi1 / sayi2;
        Console.WriteLine($"Bölüm : {bolum:0.00}");
    }
    else
    {
        Console.WriteLine("Bölüm  : Tanimsiz (Sifira bolunemez)");
    }
}
void GecmeNotuHesaplama()
{
    int vize, final;
    Console.WriteLine("Vize Notunu Giriniz : ");
    while(!int.TryParse(Console.ReadLine(), out vize))
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Lütfen Geçerli Bir Not Giriniz.");
        Console.ResetColor();
    }
    Console.WriteLine("Final Notunu Giriniz : ");
    while(!int.TryParse(Console.ReadLine(),out final))
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Lütfen Geçerli Bir Not Giriniz");
        Console.ResetColor();
    }
    double finalGrade = (vize * 0.4) + (final * 0.6);
    Console.WriteLine($"Nihai Notunuz : {finalGrade}");
    if(finalGrade>=50)
    {
        Console.WriteLine("Tebrikler Geçtiniz");
    }
    else
    {
        Console.WriteLine("Kaldınız");
    }

}
static double SayiAl(string mesaj, double min = double.MinValue, double max = double.MaxValue)
{
    double sayi;
    while (true)
    {
        Console.Write(mesaj);
        
        // 1. Sayı mı girildi?
        if (!double.TryParse(Console.ReadLine(), out sayi))
        {
            Console.WriteLine("Hata: Lütfen geçerli bir sayı giriniz!");
            continue;
        }

        // 2. İstenen aralıkta mı? (Sınır verilmediyse burası hep geçer)
        if (sayi < min || sayi > max)
        {
            Console.WriteLine($"Hata: Değer {min} ile {max} arasında olmalıdır!");
            continue;
        }

        return sayi;
    }
}
//-------------------------VERİ TİPLERİ----------------------------------
void KurSistemi()
{
    //Kur bilgileri ve tarih

    var dollarRate = 47.20m; //Özellikle decimal olması için. d olur ise double, f olur ise float olur.
    decimal euroRate = 55.30m;
    decimal goldRate = 6200m;
    DateTime dateTime = DateTime.Now;
    decimal amountInTL = (decimal)SayiAl("TL miktarını giriniz");

    //Menü
    Console.WriteLine("\nDönüştürme Seçenekleri");

    Console.WriteLine("1- Dolar");
    Console.WriteLine("2- Euro");
    Console.WriteLine("3- Altın");
    int choice = (int)SayiAl("\n Seçiminizi yapınız (1/2/3)", 1, 3);
    decimal result = 0;
    string currency = "";
    bool gecerlisecim = false;
    while (!gecerlisecim)
    {
        switch (choice)
        {
            case 1:
                result = amountInTL / dollarRate;
                currency = "USD";
                gecerlisecim = true;
                break;
            case 2:
                result = amountInTL / euroRate;
                currency = "EUR";
                gecerlisecim = true;
                break;
            case 3:
                result = amountInTL / goldRate;
                currency = "Gram Altın";
                gecerlisecim = true;
                break;
            default:
                Console.WriteLine("Geçersiz Giriş! Tekrar Deneyin.");
                gecerlisecim = true;
                break;
        }
    }
    Console.WriteLine($"\nTarih : {dateTime}");
    Console.WriteLine($"Girilen Miktar : {amountInTL} TL");
    Console.WriteLine($"Dönüşüm Sonucu : {result:F2} {currency}");

    Console.WriteLine("\n--------Kurlar-------");
    Console.WriteLine($"Dolar : {dollarRate} USD");
    Console.WriteLine($"Euro : {euroRate} EUR");
    Console.WriteLine($"Gram Altın : {goldRate} TL");

}

// İşaretsiz ve işaretli veri tipleri.

// İşaretsiz Byte
Console.WriteLine($"Min Value = {byte.MinValue}");
Console.WriteLine($"Min Value = {byte.MaxValue}");
// İşaretli Byte
Console.WriteLine($"Min Value = {sbyte.MinValue}");
Console.WriteLine($"Min Value = {sbyte.MaxValue}");









