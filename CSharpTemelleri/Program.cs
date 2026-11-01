
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
MantiksalOperatorler();








