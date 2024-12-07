# Üniversite Öğrenci Paneli Projesi

**Proje Hakkında**  
Bu proje, Kastamonu Üniversitesi Bilgisayar Mühendisliği bölümü Veri Tabanı Yönetim Sistemleri dersi kapsamında geliştirilmiştir. Proje, üniversite öğrencilerinin ders seçimi, not görüntüleme, ayar yapma gibi ihtiyaçlarını karşılayan bir panel uygulamasıdır.

## İçindekiler
- [Projenin Amacı](#projenin-amacı)
- [Teknolojiler](#teknolojiler)
- [Veritabanı Yapısı](#veritabanı-yapısı)
  - [ER Diyagram](#er-diyagram)
  - [Tablo Açıklamaları](#tablo-açıklamaları)
- [Uygulama Özellikleri](#uygulama-özellikleri)
  - [Giriş Sistemi](#giriş-sistemi)
  - [Ders Seçimi](#ders-seçimi)
  - [Not Görüntüleme](#not-görüntüleme)
  - [Ayarlar Menüsü](#ayarlar-menüsü)
  - [Öğretmen İletişim Modülü](#öğretmen-iletişim-modülü)
- [Kod Detayları](#kod-detayları)
  - [SQL Sorguları](#sql-sorguları)
  - [Trigger ve Saklı Yordam Kullanımı](#trigger-ve-saklı-yordam-kullanımı)
- [Kurulum](#kurulum)
- [Ekran Görüntüleri](#ekran-görüntüleri)
- [Geliştirici Bilgileri](#geliştirici-bilgileri)

---

## Projenin Amacı
Bu projede amaç, bir üniversite öğrencisi için kullanıcı dostu bir panel geliştirmektir. Proje, öğrencilerin:
- Kendi bilgilerini görüntülemesini,
- Ders seçimi yapmasını,
- Notlarını takip etmesini,
- Ayarlarını değiştirmesini ve güncellemesini,
- İletişim için öğretmen bilgilerine erişmesini sağlamayı hedefler.

---

## Teknolojiler
Bu projede kullanılan teknolojiler ve araçlar:
- **Programlama Dili:** C#
- **Veritabanı:** Microsoft SQL Server
- **Araçlar:** Visual Studio IDE
- **Veritabanı İlişkileri:** INNER JOIN, LEFT JOIN, TRIGGER, STORED PROCEDURE (Saklı Yordam)
- **UI:** Windows Forms

---

## Veritabanı Yapısı

### ER Diyagram
Projede kullanılan tablolar ve ilişkiler, aşağıdaki ER diyagramında gösterilmiştir.

![image](https://github.com/user-attachments/assets/a730c6b1-2c3c-4f35-a351-9d4780cf1c5c)



### Tablo Açıklamaları
- **TblDers**: Ders bilgileri. `DersID` otomatik artar (100'den başlayarak 1'er 1'er artar).
- **TblBolum**: Bölüm bilgileri. `BolumID` otomatik artar (300'den başlayarak 1'er 1'er artar).
- **TblOgrenci**: Öğrenci bilgileri. `OgrNo` otomatik artar (1000'den başlayarak).
- **TblNot**: Öğrencilerin ders ve not bilgileri.
- **TblOgretmen**: Öğretmen bilgileri.

**İlişkiler:**
- `TblOgrenci` → `Tblil` (Foreign Key: `ilID`)
- `TblNot` → `TblDers` (Foreign Key: `DersID`)
- `TblDers` → `TblOgretmen` (Foreign Key: `OgretmenID`)

---

## Uygulama Özellikleri

### Giriş Sistemi
Kullanıcılar, öğrenci numarası ve şifreleri ile sisteme giriş yapabilir. Giriş işlemi sırasında:
- Kullanıcının veritabanında var olup olmadığı kontrol edilir.
- Başarılı girişlerde kullanıcı bilgileri bir sonraki sayfaya aktarılır.

**SQL Örneği:**
```csharp
cmd.CommandText = "SELECT * FROM TblOgrenci WHERE OgrNo='" + _ogrencino + "' AND Sifre LIKE'" + _sifre + "'";
