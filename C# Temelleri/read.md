# 🚀 Sıfırdan C# Öğrenim Günlüğüm & Türkçe Rehber

Merhaba! Ben Esmanur. Bu repo, **Bilişim Güvenliği Teknolojisi** eğitimi alırken sıfırdan **C#** programlama dilini öğrenme sürecimde tuttuğim düzenli notları, kod bloklarını ve pratik örnekleri içermektedir.

Amacım; hem kendi öğrenme yolculuğumu kalıcı hale getirmek hem de C# temellerini öğrenmek isteyenler için temiz bir Türkçe kaynak oluşturmaktır.

---

## 📌 İçindekiler / Konu Başlıkları

1. **Giriş ve Temel Komutlar** (`Console.WriteLine`, `Beep` vb.)
2. **Değişkenler ve Veri Tipleri** (`int`, `string`, `double`, `bool`, `const`)
3. **Kullanıcı Girişi Alma** (`Console.ReadLine` kullanımı)
4. **Tür Dönüşümleri** (`Convert.ToInt32`)
5. **Matematiksel İşlemler** (Temel operatörler ve tam sayı/ondalık bölme farkları)
6. **Matematik Fonksiyonları** (`Math.Pow`, `Math.Sqrt`, `Math.Round`, `Math.Ceiling` vb.)
7. **Koşullu İfadeler** (`if`, `else`, `else if`)
8. **Karşılaştırma Operatörleri** (`>=`, `<=`, `==`)
9. **Mantıksal Operatörler** (`&&` ve `||`)
10. **Döngüler** (`while` döngüsü ve sayfa sayaçları)

---

## 💻 Örnek Kod Yapısından Bir Kesit

Projelerimde konuları `#region` blokları ile düzenleyerek çalışmayı kolaylaştırdım:

```csharp
#region KULLANICI GİRİŞİ
string isim;
Console.Write("Lütfen isminizi giriniz: ");      
isim = Console.ReadLine();     
Console.WriteLine("Merhaba " + isim);  
#endregion