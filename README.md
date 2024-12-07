# Üniversite Öğrenci Paneli Projesi

Bu proje, **Kastamonu Üniversitesi Bilgisayar Mühendisliği** bölümü "Veri Tabanı Yönetim Sistemleri" dersi kapsamında geliştirilmiştir. Projede bir üniversite öğrenci paneli oluşturulmuş, öğrenciler için giriş, ders seçimi, not görüntüleme ve ayarlar gibi işlevler sunulmuştur.

## İçindekiler
- [ER Diyagram](#er-diyagram)
- [Tablolar ve İlişkiler](#tablolar-ve-ilişkiler)
- [Kod Açıklamaları](#kod-açıklamaları)
  - [Öğrenci Girişi Formu](#öğrenci-girişi-formu)
  - [Şifre Sıfırlama](#şifre-sıfırlama)
  - [Öğrenci Sayfası](#öğrenci-sayfası)
  - [Ders Seçimi ve Notlar](#ders-seçimi-ve-notlar)
  - [Ayarlar Sayfası](#ayarlar-sayfası)
  - [Öğretmen İletişim](#öğretmen-iletişim)

## ER Diyagram
Projenin ER diyagramı, tablolar arasındaki ilişkileri ve anahtar (primary key) - yabancı anahtar (foreign key) bağlantılarını göstermektedir.

![ER Diyagram](er-diagram-placeholder.png)

## Tablolar ve İlişkiler
Projede kullanılan başlıca tablolar ve özellikleri aşağıda listelenmiştir:
- **TblDers**: Ders bilgilerini içerir (DersID otomatik artar, başlangıç 100).
- **TblBolum**: Bölüm bilgilerini içerir (BolumID otomatik artar, başlangıç 300).
- **TblOgrenci**: Öğrenci bilgilerini içerir. (OgrNo otomatik artar, başlangıç 1000).
- **TblNot**: Öğrencilerin notlarını içerir.
- **TblOgretmen**: Öğretmen bilgilerini içerir.

## Kod Açıklamaları

### Öğrenci Girişi Formu
Bu modül, öğrencilerin giriş yapabilmesini sağlar. SQL sorguları ile öğrenci bilgileri doğrulanır. Hatalı girişler için uyarı mesajı gösterilir.

**SQL Sorgusu Örneği:**
```csharp
cmd.CommandText = "SELECT * FROM TblOgrenci WHERE OgrNo='" + _ogrencino + "' AND Sifre LIKE'" + _sifre + "'";
