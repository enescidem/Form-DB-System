# Üniversite Öğrenci Paneli Projesi

---
**Proje Hakkında**  
Bu proje, Kastamonu Üniversitesi Bilgisayar Mühendisliği bölümü Veri Tabanı Yönetim Sistemleri dersi kapsamında geliştirilmiştir. Proje, üniversite öğrencilerinin ders seçimi, not görüntüleme, ayar yapma gibi ihtiyaçlarını karşılayan bir panel uygulamasıdır.

## İçindekiler

- [Projenin Amacı](#projenin-amacı)
- [Teknolojiler](#teknolojiler)
1. [ER Diyagram](#er-diyagram)  
2. [Tablolar Arasındaki İlişkiler](#tablolar-arasındaki-ilişkiler)  
3. [Öğrenci Girişi Formu](#öğrenci-girişi-formu)  
   - [Giriş Ekranı SQL Sorgusu](#giriş-ekranı-sql-sorgusu)  
   - [Giriş Yap Butonuna Bastığımızda](#giriş-yap-butonuna-bastığımızda)  
4. [Şifremi Unuttum Butonuna Bastığımızda](#şifremi-unuttum-butonuna-bastığımızda)  
5. [Şifremi Unuttum Sayfası Formu](#şifremi-unuttum-sayfası-formu)  
   - [Şifremi Unuttum Ekranı SQL Sorgusu](#şifremi-unuttum-ekranı-sql-sorgusu)  
6. [Giriş Yaptıktan Sonra Gelen Ekran](#giriş-yaptıktan-sonra-gelen-ekran)  
   - [Öğrenci Sayfası Formu](#öğrenci-sayfası-formu)  
     - [Sayfa Yüklenirken Çalışan SQL Sorgusu](#sayfa-yüklenirken-çalışan-sql-sorgusu)  
7. [Notlar Sayfası Formu](#notlar-sayfası-formu)  
   - [Sayfa Yüklenirken Çalışan SQL Sorgusu İle Tabloyu Doldurma](#sayfa-yüklenirken-çalışan-sql-sorgusu-ile-tabloyu-doldurma)  
8. [Ayarlar Sayfası Formu](#ayarlar-sayfası-formu)  
   - [Sayfa Yüklenirken Çalışan SQL Sorguları](#sayfa-yüklenirken-çalışan-sql-sorguları)  
   - [Kaydet Butonuna Bastığımızda Çalışan SQL Sorguları](#kaydet-butonuna-bastığımızda-çalışan-sql-sorguları)  
9. [Ders Seçimi Sayfası Formu](#ders-seçimi-sayfası-formu)  
   - [Sayfa Yüklenirken Çalışan SQL Sorguları](#sayfa-yüklenirken-çalışan-sql-sorguları-1)  
   - [Listele Fonksiyonu](#listele-fonksiyonu)  
   - [Ders Ekle Butonuna Bastığımızda Çalışan SQL Sorguları](#ders-ekle-butonuna-bastığımızda-çalışan-sql-sorguları)  
   - [Ders Sil Butonuna Bastığımızda Çalışan SQL Sorguları](#ders-sil-butonuna-bastığımızda-çalışan-sql-sorguları)  
10. [Öğretmen İletişim Sayfası Formu](#öğretmen-iletişim-sayfası-formu)  
    - [Sayfa Yüklenirken Çalışan SQL Sorguları](#sayfa-yüklenirken-çalışan-sql-sorguları-2)  
    - [Öğretmen Arama](#öğretmen-arama)

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

## ER Diyagram
Projede kullanılan tablolar ve ilişkiler, aşağıdaki ER diyagramında gösterilmiştir.

![image](https://github.com/user-attachments/assets/a730c6b1-2c3c-4f35-a351-9d4780cf1c5c)  

---

## Tablolar Arasındaki İlişkiler
![image](https://github.com/user-attachments/assets/97e7b4d4-5bb5-4a45-87cb-98e0f28e5aca)
Yanında anahtar işareti bulunan nitelikler PRİMARY KEY’dir. 
Burada okların ucundaki anahtar simgesine baktığımızda anahtar işaretinin gösterdiği nitelik herhangi bir
tablonun PRİMARY KEY’ini okun diğer ucu ise o primary keyin diğer tabloda FOREIGN KEY olarak 
kullanıldığını göstermektedir.  
Örnek: Tblil tablosunun PRİMARY KEY’i olan ilID, TblOgrenci tablosunda yine ilID ismini alarak 
FOREIGN KEY olmuştur. 

![image](https://github.com/user-attachments/assets/561d0583-cd6a-4ea7-8bed-93c357abeca7)
Burada tabloların tüm niteliklerini ve onların özelliklerini görmekteyiz. 
TblDers tablosunda: DersID niteliği otomatik artan bir özellik ekledim burada 100 den başlayarak 1’er 
1’er artarak ileriliyor. 
TblBolum tablosunda: BolumID niteliği otomatik artan bir özellik ekledim burada 300 den başlayarak 1’er 
1’er artarak ileriliyor. 
TblOgrenci tablosunda: OgrNo niteliği otomatik artan bir özellik ekledim burada 1000 den başlayarak 
1’er 1’er artarak ileriliyor. Ve Tel niteliği de default bir değer içeriyor eğer tabloya veri eklenirken Tel 
niteliği boş bırakılırsa Tel Yok yazdırmasını istiyoruz. Yine aynı şekilde AyarGuncellemeSayisi da default 
olarak 0 yaptım. 
TblNot tablosunda: VizeNotu ve FinalNotu nitelikleri de default olarak 0 atadım. 
TblOgretmen tablosunda: OgretmenID niteliği otomatik artan bir özellik ekledim burada 200 den 
başlayarak 1’er 1’er artarak ileriliyor. Ve yine aynı şekilde Tel niteliğine de default olarak Tel Yok değerini 
atıyorum.

---

## Öğrenci Girişi Formu
![image](https://github.com/user-attachments/assets/f760b673-8159-4fb6-bc85-704c9f714cf7)

### Giriş Ekranı SQL Sorgusu
```csharp
public partial class OgrenciGirisi : Form
    {
        public static string _ogrencino, _sifre, _ogrenciad, _ogrsoyad, _tel, _ilID, _bolumID, _sinif, _ayarguncelleme;
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            //TEXTBOXA GİRİLEN DEĞERLERİ SELECT VERİTABANI SORGUSU İLE KONTROL ETME
            _ogrencino = textBoxOgrenciNo.Text;
            _sifre = textBoxSifre.Text;
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM TblOgrenci WHERE OgrNo='" + _ogrencino + "' AND Sifre LIKE'" + _sifre + "'";
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                //TblOgrenci Tablosundaki verilere diğer classlardan erişebilmek için değişkenlere atama
                SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
                SqlCommand cmd1 = new SqlCommand();
                con1.Open();
                cmd1.Connection = con1;
                cmd1.CommandText = "SELECT * FROM TblOgrenci WHERE OgrNo='" + _ogrencino + "'";
                SqlDataReader read1 = cmd1.ExecuteReader();
                read1.Read();
                _ogrenciad = (string)read1["OgrenciAd"];
                _ogrsoyad = (string)read1["OgrSoyad"];
                _tel = (string)read1["Tel"];
                _ilID = Convert.ToString(read1["ilID"]);
                _bolumID = Convert.ToString(read1["BolumID"]);
                _sinif = Convert.ToString(read1["Sinif"]);
                _ayarguncelleme = Convert.ToString(read1["AyarGuncellemeSayisi"]);
                con1.Close();
                
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                OgrenciSayfasi ogrenciSayfasi = new OgrenciSayfasi();
                ogrenciSayfasi.Show();
            }
            else
            {
                MessageBox.Show("Hatalı öğrenci no veya şifre. Kontrol edip dekrar deneyiniz!");
            }
            con.Close();
        }
```
### Giriş Yap Butonuna Bastığımızda

## Şifremi Unuttum Butonuna Bastığımızda

## Şifremi Unuttum Sayfası Formu

### Şifremi Unuttum Ekranı SQL Sorgusu

## Giriş Yaptıktan Sonra Gelen Ekran

### Öğrenci Sayfası Formu

#### Sayfa Yüklenirken Çalışan SQL Sorgusu

## Notlar Sayfası Formu

### Sayfa Yüklenirken Çalışan SQL Sorgusu İle Tabloyu Doldurma

## Ayarlar Sayfası Formu

### Sayfa Yüklenirken Çalışan SQL Sorguları

### Kaydet Butonuna Bastığımızda Çalışan SQL Sorguları

## Ders Seçimi Sayfası Formu

### Sayfa Yüklenirken Çalışan SQL Sorguları

### Listele Fonksiyonu

### Ders Ekle Butonuna Bastığımızda Çalışan SQL Sorguları

### Ders Sil Butonuna Bastığımızda Çalışan SQL Sorguları

## Öğretmen İletişim Sayfası Formu

### Sayfa Yüklenirken Çalışan SQL Sorguları

### Öğretmen Arama  

---

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

Haklısın, şimdi sadece **DOCX dosyasındaki başlıkları** README formatında eksiksiz şekilde yapılandırıyorum.

---



