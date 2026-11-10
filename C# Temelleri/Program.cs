#region GİRİŞ
//Console.WriteLine("Merhaba C#");        //çıktı verir
//Console.WriteLine("C# ile kod yazıyorum");      //çıktı verir
//Console.Beep();     //bip sesi verir
#endregion

#region DEĞİŞKENLER
//kaydedeceğimiz değer eğerki tam sayı ise int
//int x=29;
//değişkenimiz ondalıklı bir sayı ise double
//double x=18.76;
//değişkenimiz metin ise string
//string x="kedi";
//değişkenimiz true yada false ise bool
//bool x=true;

//string renk="sarı";
//int sayi=10;
//int yeniSayi=20;
//double pi=3.14;
//bool durum=true;

//sayi=yeniSayi;
//Console.WriteLine(sayi);     //sayi değişkeni artık 20 olur ve ekrana 20 yazdırır.

//int yas; diye bir değişken atayıp ileride yas=10; diye değiştirebiliriz (başına tekrar int yazılmaz)
//int yas=5; olsa ama ileride yas=12; diye değiştirebiliriz
//eğer ki "const" double pi yazarsan const değişkeni sebebiyle sabit kalır
#endregion

#region KULLANICI GİRİŞİ
//string isim;
//Console.Write("Lütfen isminizi giriniz: ");      //writeline bir satırı kapladığı için alt satıra geçer write ise alt satıra geçmez
//isim=Console.ReadLine();     //kullanıcıdan isim değişkenine değer ataması yapar
//Console.WriteLine("Merhaba "+isim);  
#endregion

#region TÜR DEĞİŞİMİ
//Console.Write("Lütfen isminizi giriniz: ");
//string isim=Console.ReadLine();
//Console.Write("Lütfen yaşınızı giriniz: ");
//int yas=Convert.ToInt32(Console.ReadLine());        // Veriyi (genelde string'i) int türüne dönüştürür.
//Console.WriteLine(isim + " " + yas + " yaşında.");
#endregion

#region MATEMATİKSEL İŞLEMLER
//int x=7;
//int y=3;
//Console.WriteLine(x+y);       //toplama işlemi
//Console.WriteLine(x-y);       //çıkarma işlemi
//Console.WriteLine(x*y);       //çarpma işlemi
//Console.WriteLine(x/y);       //bölme işlemi
//x=7 ve y=3 ise x/y işlemi 2.3333 değil 2 olarak çıkar çünkü int türünde bölme işlemi yapıyoruz
//eğer ki x ve y değişkenlerinden birini bile double türünde tanımlarsak x/y işlemi 2.3333 olarak çıkar
//Console.WriteLine(x%y);       //mod alma işlemi
#endregion

#region MATEMATİK FONKSİYONLARI
//Console.Write(Math.Pow(2,3));       //2 üzeri 3 işlemi yapar ve ekrana 8 yazdırır
//Console.Write(Math.Sqrt(9));        //9 un karekökünü alır ve ekrana 3 yazdırır
//Console.Write(Math.Abs(-5));        //mutlak değer alır ve ekrana 5 yazdırır
//Console.Write(Math.Round(3.14));        //3.14 ü yuvarlar ve ekrana 3 yazdırır
//Console.Write(Math.Round(3.54));        //3.54 ü yuvarlar ve ekrana 4 yazdırır
//Console.Write(Math.Ceiling(3.14));      //3.14 ü yukarı yuvarlar ve ekrana 4 yazdırır
//Console.Write(Math.Floor(3.54));        //3.54 ü aşağı yuvarlar ve ekrana 3 yazdırır
//Console.Write(Math.Max(3,5));        //3 ve 5 in en büyüğünü alır ve ekrana 5 yazdırır
//Console.Write(Math.Min(3,5));        //3 ve 5 in en küçüğünü alır ve ekrana 3 yazdırır
#endregion

#region KOŞULLU İFADELER
//bool resitMi=true;       //resitMi değişkeni true ise if bloğu çalışır, false ise else bloğu çalışır

//if (resitMi==true){
    //Console.WriteLine("Siteye hoşgeldiniz");
//}

//else
//{
    //Console.WriteLine("Siteye giremezsiniz");
//}
#endregion

#region KARŞILAŞTIRMA OPERATÖRLERİ
//Console.Write("Lütfen yaşınızı giriniz: ");
//int yas=Convert.ToInt32(Console.ReadLine());        //kullanıcıdan yaşını alır ve int türüne dönüştürür

//if(yas>=18)        //eğer yaş 18 veya daha büyük ise if bloğu çalışır
//{
    //Console.WriteLine("Siteye hoşgeldiniz");
//}
//else if(yas<=0)   
//{
    //Console.WriteLine("Yanlış bir değer girdiniz");
//}
//else        //eğer yaş 18 den küçük ise else bloğu çalışır
//{
    //Console.WriteLine("Siteye giremezsiniz");
//}
#endregion

#region MANTIKSAL OPERATÖRLER
//Console.Write("Ehliyetiniz var mı? (evet:e, hayır:h): ");
//string ehliyet=Console.ReadLine();
//Console.Write("Arabanız var mı? (evet:e, hayır:h): ");
//string araba=Console.ReadLine();
//if(araba=="e" && ehliyet=="e")        // && operatörü ile iki koşulun da doğru olması gerekir kısaca ve anlamına gelir
//{
    //Console.WriteLine("Araba kullanabilirsiniz");
//}
//else if(ehliyet=="e" || araba=="e")        // || operatörü ile iki koşuldan birinin doğru olması yeterlidir kısaca veya anlamına gelir
//{
    //Console.WriteLine("Araba kullanmanıza az kaldı");
//}
//else
//{
    //Console.WriteLine("Araba kullanamazsınız");
//}
#endregion

#region DÖNGÜLER
//int sayi=1;
//while(sayi<=5)      //Koşul doğru olduğu sürece döngü çalışır
//{
    //Console.WriteLine(sayi);
    //sayi++;     //sayi değişkenini 1 artırır
//}
#endregion