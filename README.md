# Üniversite Öğrenci Paneli DB Projesi

---

**Proje Hakkında**  
Bu proje, Kastamonu Üniversitesi Bilgisayar Mühendisliği bölümü Veri Tabanı Yönetim Sistemleri dersi kapsamında geliştirilmiştir. Proje, üniversite öğrencilerinin ders seçimi, not görüntüleme, ayar yapma gibi ihtiyaçlarını karşılayan bir panel uygulamasıdır.

Microsoft SQL Server'da temel SQL sorguları ile INNER JOIN, LEFT JOIN, Saklı Prosedürler (Stored Procedures) ve Tetikleyiciler (Triggers) gibi ileri teknikleri kullanan bir öğrenci yönetim sistemi.

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

---

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

---

### Giriş Yap Butonuna Bastığımızda
Bu kod bloklarında öncelikle  OgrenciGirisi formunda public static olarak tanımladığımız değişkenler var.Bu değişkenlere SQL’den veri çekicez. Bunları diğer formlardan ulaşabilmek için tutuyoruz. Textboxlardan aldığımız verileri değişkenlere atıyoruz.Sonra SELECT sorgusu ile TblOgrenci tablosundan OgrNo’su textBoxOgrenciNo’dan girilen değere eşit olan ve Sifre niteliğini de LIKE ile textBoxSifre’den gelen değere eşitleyip seçiyoruz. Sonra if sorgusu ile eğer bu sorgu read edilirse tabloda böyle bir kişi olduğunu anlıyoruz. Ve o kişinin verilerini çekebilmek için if içinde tekrar bir SELECT sorgusu ile gelen öğrencinin tüm değerlerini ilgili değişkenlere atıyoruz. Daha sonra OgrenciSayfasi’nı açıyoruz. Eğer böyle bir kullanıcı yoksa (else) hata mesajı çıkarıyoruz.

Örnek başarılı öğrenci girişi:
![image](https://github.com/user-attachments/assets/c707e1f7-1584-4075-8c45-12786c588ac4)

Örnek başarısız öğrenci girişi:
![image](https://github.com/user-attachments/assets/ffeafee4-4a74-4d55-b15b-b480f0902f40)

---

## Şifremi Unuttum Butonuna Bastığımızda
```csharp
private void buttonSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttumFormu sifremiUnuttumFormu = new SifremiUnuttumFormu();
            sifremiUnuttumFormu.Show();
        }
```
SifremiUnuttumFormu’nu çağırıyor.

---

## Şifremi Unuttum Sayfası Formu
![image](https://github.com/user-attachments/assets/a6d5fd30-2a54-48e5-bfd8-c958c58c5dc9)

### Şifremi Unuttum Ekranı SQL Sorgusu
```csharp
    public partial class SifremiUnuttumFormu : Form
    {
        private void buttonSifreyiDegistir_Click(object sender, EventArgs e)
        {
            int _ogrno = Convert.ToInt32(textBoxOgrNo.Text);
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE TblOgrenci SET Sifre='" + textBoxYeniSifre.Text +"' WHERE OgrNo='" + _ogrno + "' AND OgrenciAd='"+textBoxOgrAd.Text+"' AND OgrSoyad='"+textBoxOgrSoyad.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Şifre Değiştirme Başarılı");
        }
```
Bu kod bloğunda Şifreyi Değiştir butonuna bastığımızda UPDATE SQL sorgusu ile TblOgrenci tablosundaki Sifre niteliğini SET ediyoruz textBoxYeniSifre’den dönen değer ile ama WHERE koşulu true döndürürse. Yani OgrNo, OgrenciAd, OgrSoyad nitelikleri textboxlarda girilen değerler ile eşleşirse şifre değişikliği başarılı oluyor.

Veritabanındaki veriler:
 ![image](https://github.com/user-attachments/assets/d6ee855f-7c6d-4594-abce-2851064eefda)
Celal öğrencisinin şifresini değiştirelim:
![image](https://github.com/user-attachments/assets/05e07882-8753-40e1-a5b0-0f30522042bb)
Şifre değişikliğinden sonra veritabanındaki veriler:
![image](https://github.com/user-attachments/assets/38c4f608-b67c-4df4-a4dd-0931a7128fa5)

---

## Giriş Yaptıktan Sonra Gelen Ekran

### Öğrenci Sayfası Formu
![image](https://github.com/user-attachments/assets/56565cd4-8b5b-46b0-b98d-baca05524322)

---

#### Sayfa Yüklenirken Çalışan SQL Sorgusu
```csharp
        private void OgrenciSayfasi_Load(object sender, EventArgs e)
        {
            labelHosgeldinOgrenci.Text = "Hoşgeldin "+OgrenciGirisi._ogrenciad+" "+ OgrenciGirisi._ogrsoyad;
            labelSınıf.Text = "Sınıfın: "+OgrenciGirisi._sinif;
            //SQL Sorgu ile Bölümünü bulma
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT BolumAd FROM TblBolum WHERE BolumID='" + OgrenciGirisi._bolumID + "'";
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            labelBolum.Text = "Bölümünüz: " +Convert.ToString(read["BolumAd"]);
            con.Close();
        }
```
Burada ilk olarak labelHosgeldinOgrenci ye OgrenciGirisi formundan tuttuğumuz değişkenleri atarak Hoşgeldin  Ad Soyad şeklinde çekiyoruz. Aynı şekilde sınıfı da çekiyoruz.  Burada önemli olan Bölümünüz kısmı çünkü bölüm kısmını TblOgrenci tablosunda BolumID olarak tuttuğumuz için. SELECT sorgusu ile TblBolum tablosundan BolumAd ı istiyoruz. WHERE koşulu ile de yine OgrenciGirisi sayfasında çektiğimiz BolumID leri eşit olan değeri döndürüyoruz. Dönen değeri de  labelBolum değerine atıyoruz. 
Öğrenci Sayfasında Notlar Butonuna tıkladığımızda:
NotlarFormu’ndan nesne üretip notlar sayfasını gösteriyoruz.

---

## Notlar Sayfası Formu
![image](https://github.com/user-attachments/assets/dc129bec-b5ad-4b6f-ba70-e5e596b88667)

---

### Sayfa Yüklenirken Çalışan SQL Sorgusu İle Tabloyu Doldurma
```csharp 
    public partial class NotlarFormu : Form
    {
        DataTable tablo = new DataTable();
        private void NotlarFormu_Load(object sender, EventArgs e)
        {
            //BURADA SQL SORGUSU İLE LEFT JOİNLE TABLO OLUŞTUURP TABLOYA AKTARMA
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT TblNot.OgrNo, TblDers.DersAd, TblDers.DersKredi, TblNot.VizeNotu, TblNot.FinalNotu FROM TblNot INNER JOIN TblDers ON TblNot.DersID = TblDers.DersID WHERE OgrNo= '" + OgrenciGirisi._ogrencino + "' ORDER BY TblDers.DersAd", con);
            adtr.Fill(tablo);
            dataGridViewNotlar.DataSource = tablo;
            con.Close();
        }
```
Burada ilk olarak DataTable türünde bir tablo oluşturuyorum. Daha sonra INNER JOIN ile Tabloları birleştirme işlemi yapıyorum. TblNot ile TblDers tablolarını join ediyorum. Bu tabloların DersID niteliğinin eşit olanları join ediyorum ve WHERE koşulu ile de hangi öğrenci giriş yaptıysa onun OgrNo’ su ile eşliyorum. ORDER BY ile de DersAd’a göre alfabetik(ASC) sıralıyorum.  ASC yazmadım çünkü default olarak ASC var zaten. En sonda bu dönen değerleri SELECT sorgusu ile çekip tabloya atıyorum.

---

Öğrenci Sayfasında AyarlarButonuna tıkladığımızda:
AyarlarFormu’ndan nesne üretip notlar sayfasını gösteriyoruz.
## Ayarlar Sayfası Formu
![image](https://github.com/user-attachments/assets/1290b389-21da-4d01-a7bf-6df8a1f3b741)

---

### Sayfa Yüklenirken Çalışan SQL Sorguları
```csharp
    public partial class AyarlarFormu : Form
    {
        private void AyarlarFormu_Load(object sender, EventArgs e)
        {
            //TRİGGER İLE AYAR GUNCELLEMEYİ SÜREKLİ GÜNCELLİYORUZ
            labelAyarGuncelleme.Text = "Ayar Güncelleme Sayınız: "+OgrenciGirisi._ayarguncelleme;
            textBoxSifre.Text = OgrenciGirisi._sifre;
            textBoxTelefon.Text = OgrenciGirisi._tel;
            //ilID sını kullanarak SQL Sorgusu ile Şehiri Bulup comboboxa atma
            SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT ilAd FROM Tblil WHERE ilID='" +OgrenciGirisi._ilID+ "'";
            SqlDataReader read1 = cmd1.ExecuteReader();
            read1.Read();
            comboBoxSehir.Text= Convert.ToString(read1["ilAd"]);
            con1.Close();

            //Veritabanındaki İlleri SAKLI YORDAM İLE ComboBoxa atma
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "EXEC SakliYordam";
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                comboBoxSehir.Items.Add(read["ilAd"]);
            }
            con.Close();
        }
```
Burada öncelikle form sayfasında sağ üstte yazan Ayar Güncelleme Sayınız dan bahsedelim bu kısımda Trigger kullandım. Her TblOgrenci tablosu güncellendiğinde (UPDATE), TblOgrenci tablosundaki AyarGuncellemeSayisi niteliği 1 artıyor. Yazdığım Trigger:
![image](https://github.com/user-attachments/assets/0390f7e2-de28-4734-a774-4739dd40db37)
Buradaki trigger sorgusunda declare ile @id adında int bir değişken tanımlayıp. Ayar Güncelleme(UPDATE) işleminden sonra(AFTER)  o UPDATE sorgusundaki OgrNo’yu @id’ye tanımlıyoruz. Buradaki FROM inserted denilen yer UPDATE veya İNSERT işleminde oluşan görünmez bir tablo gibi düşünebiliriz. Ordan veriyi çekiyoruz. Daha sonra update ile TblOgrenci’de bulunan AyarGuncellemeSayisi niteliğini 1 arttıyoruz. Bunu da yaparken WHERE koşulu ile Ayar Güncelleme işleminde kullandığımız OgrNo yu yani @id’ye attığımız değeri OgrNo’ya eşit olsun koşulu koyuyoruz.

Ayarlar değiştirmeden önce Ayar Güncelleme Sayımız 12 idi. Ayarları güncelleyip tekrar bakalım:
![image](https://github.com/user-attachments/assets/ee7801ff-ba90-4bbe-a736-e9296e483c62)
![image](https://github.com/user-attachments/assets/521295c7-2113-4aab-9e4d-890a374a039b)
Gördüğümüz gibi 13 oldu.

Ayarlar formu açıldığında texboxlara ve combobaxa default olarak OgrenciGirisi sayfasında değişkenlerde tuttuğumuz değerleri yerleştirdim. Fakat bu kısımda şehir’i TblOgrenci’de ilID olarak tutuğumuz için bu ilID’nin hangi il olduğunu bulmak için yine bir sorgu yazıyoruz. Bu sorguda Tblil tablosundaki ilAd niteliğini seçiyoruz neye göre seçiyoruz WHERE koşuluyla ilID’si OgrenciGirisi formunda değişkene atadığımız _ilID olsun diyoruz. Ve daha sonra bunu comboBoxSehir’in textine atıyoruz. Böylelikle öğrencinin ili default olarak gelmiş oluyor. 

Daha sonra bu combobaxa diğer illeri atarak öğrencinin illeri değişmesine olanak sağlıyoruz. Combobaxa illeri atmak için SAKLI YORDAM kullandım. Yazdığım saklı yordam:
![image](https://github.com/user-attachments/assets/1ede6730-c83a-4d65-b1e8-f555deb7aa13)
Saklı yordamı kod ortamında EXEC SakliYordam ile çağırdım ve Tblil tablosundaki tüm nitelikleri seçerek. Tüm tabloyu döndürmüş oldum. Kodun devamında comboBoxSehir.Items.Add(read["ilAd"]) ile ilAd niteliğindeki tüm verileri combobaxa atıyorum while döngüsü içinde.

comboBoxSehir'de ki şehirler:
![image](https://github.com/user-attachments/assets/1c6060ba-24a4-40db-a446-2f7525ff8c58)

---

### Kaydet Butonuna Bastığımızda Çalışan SQL Sorguları
```csharp
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //comboboxtan seçilen ilin Şehir ID'sini Bulma SQL Sorgusu
            string _sehir = comboBoxSehir.Text;
            SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT ilID FROM Tblil WHERE ilAd='"+ _sehir + "'";
            SqlDataReader read1 = cmd1.ExecuteReader();
            read1.Read();
            int _ilID = (int)read1["ilID"];
            con1.Close();
            
            //Şehir ve Telefon Bilgisini Güncelleme SQL Sorgusu
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE TblOgrenci SET Tel='"+textBoxTelefon.Text+"', ilID='"+_ilID+"', Sifre='"+textBoxSifre.Text+"' WHERE OgrNo='"+Convert.ToInt32(OgrenciGirisi._ogrencino)+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme Başarılı");
        }
```
İlk sorguda comboboxtan seçilen şehirin ilID'sini Bulmak için string türünde _sehir değişkeni tanımlıyoruz. Bu değişkene combobaxdan seçilen değeri atıyoruz. Daha sonra SELECT sorgusu ile ilID niteliğini seçip WHERE koşulu ile ilAd niteliğinin _sehir değişkenine eşit olan değeri döndürüyoruz.
 Alttaki sorguda ise textboxlara girilen değerleri ve combobaxda seçilen değerleri veritabanındaki veri tipleri ile aynı olucak şekilde veri tiplerine dönüştürerek TblOgrenci Tablosundaki Tel, ilID ve Sifre niteliklerini SET ediyoruz. WHERE koşulu ile de girisekranında aldığımız _ohrencino ile veritabanındaki OgrNo’ları eşleştiriyoruz.
 
Özlem Kişisi Üzerinden Bir Güncelleme İşlemi: 

Değiştirmeden Önce:
![image](https://github.com/user-attachments/assets/d826c34b-021c-4339-8820-f8e3785b6254)
![image](https://github.com/user-attachments/assets/d9f554cd-223c-44bd-bfaf-72dacdca54bd)

Güncellemeden Sonra:
![image](https://github.com/user-attachments/assets/1c0a5909-d7d5-42e2-a21c-12301583d191)
![image](https://github.com/user-attachments/assets/2a7efbcb-9df5-4b89-8336-0203daebd020)
Burada yeniden TRİGGER’ında çalıştığını görmüş olduk.

---

## Ders Seçimi Sayfası Formu
![image](https://github.com/user-attachments/assets/86cb177c-8d34-4335-9244-8a66acb34ad3)

---

### Sayfa Yüklenirken Çalışan SQL Sorguları
```csharp
    public partial class DersSecimiFormu : Form
    { 
        private void DersSecimiFormu_Load(object sender, EventArgs e)
        {
            //ALMADIĞIN DERSLERİ İÇ İÇE SORGU İLE COMBOBOXA ATMA BURADA
            SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT DersAd FROM TblDers LEFT JOIN (SELECT * FROM TblNot WHERE OgrNo='"+OgrenciGirisi._ogrencino+"') AS TblNotOgrNo ON TblNotOgrNo.DersID=TblDers.DersID WHERE TblNotOgrNo.DersID IS NULL";
            SqlDataReader read1 = cmd1.ExecuteReader();
            while (read1.Read())
            {
                comboBoxDersler.Items.Add(read1["DersAd"]);
            }
            con1.Close();
            Listele();
        }
```
Sayfa Yüklenirken Öğrencinin Almadığı Dersleri bulmak için bir sql sorgusu yazdım bu sorguda iç içe sorguları ve left join kullandım. İç sorgudan başlayalım TblNot tablosundaki tüm nitelikleri seç(SELECT) ama (WHERE)  OgrNo değeri girissayfasındaki _ogrno ile eşit olanları. Daha sonra burdan dönen tabloya TblNotOgrNo ismini verdim. Ve bu tablo ile TblDers tablosundaki DersAd niteliğini seçerek(SELECT) bu iki tabloyu DersID’lerine göre eşitleyip. WHERE koşulunda TblNotOgrNo ile isim verdiğim tablonun DersID niteliğininin NULL olduğu değerleri döndürerek Öğrencinin almadığı dersleri buldum ve bu dersleri  comboBoxDersler.Items.Add(read1["DersAd"]); komutu ile while döngüsü içinde combobaxa attım.

Örnek olarak:

TblDers tablosundaki dersler:
![image](https://github.com/user-attachments/assets/1b382e61-0a19-43b6-8bae-8a7c56987875)
![image](https://github.com/user-attachments/assets/990d038a-a552-449f-b9ed-3742e9d36541)
Görüldüğü gibi yukarıdaki tablodaki dersler yok sadece almadığı dersler var.

Sayfa yüklenirken son olarak da Listele(); fonksiyonu ile tabloyu dolduruyorum .

---

### Listele() Fonksiyonu
```csharp
        //Aldığın Derslerin bilgilerinin gözüktüğü tabloyu sql sorgusu ile çağıran method
        private void Listele()
        {
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT TblNot.OgrNo, TblDers.DersAd, TblDers.DersKredi, TblOgretmen.Ad, TblOgretmen.Soyad, TblOgretmen.Tel FROM TblNot, TblDers, TblOgretmen WHERE TblNot.OgrNo ='" + OgrenciGirisi._ogrencino + "'AND TblOgretmen.OgretmenID = TblDers.OgretmenID AND TblNot.DersID = TblDers.DersID", con);
            adtr.Fill(tablo);
            dataGridViewDersler.DataSource = tablo;
            con.Close();
        }
```
Burada ilk olarak DataTable türünde bir tablo oluşturuyorum. Daha sonra SELECT sorgusu ile TblNot, TblDers, TblOgretmen tablolarındaki bazı nitelikleri(tablonun sütun isimlerini oluşturacak) çekerek WHERE koşulu ile OgrNo su giris sayfasındaki textboxa girilen oğrenci no olan VE TblOgretmen tablosundaki OgretmenID ile TblDers’de ki OgretmenID eşleştirerek VE TblNot tablosundaki DersID ile TblDers tablosundakini eşliyorum dönen tabloyu da aktarıyorum.

---

### Ders Ekle Butonuna Bastığımızda Çalışan SQL Sorguları
```csharp
        private void buttonDersEkle_Click(object sender, EventArgs e)
        {
            //comboboxtan seçilen dersin Ders ID'sini Bulma SQL Sorgusu
            string _secilenders = comboBoxDersler.Text;
            SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT DersID FROM TblDers WHERE DersAd='" + _secilenders+ "'";
            SqlDataReader read1 = cmd1.ExecuteReader();
            read1.Read();
            int _dersID = (int)read1["DersID"];
            con1.Close();

            //DERSİ ÖĞRENCİNİN DERSLERİNE DAHİL ETME
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO TblNot(OgrNo, DersID) values('"+int.Parse(OgrenciGirisi._ogrencino)+"','"+_dersID+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            Listele();
            MessageBox.Show("Güncelleme Başarılı");
        }
```
İlk sorgu comboboxtan seçilen ilin Şehir ID'sini Bulma SQL Sorgusu ile aynı işlevi görmektedir. Tekrar açıklayarak kalabalık etmek istemedim. 

Son sorguya gelicek olursak ekleme (INSERT) sorgusu görüyoruz. TblNot Tablosuna ekleme yapıyoruz OgrNo niteliğine int.Parse(OgrenciGirisi._ogrencino) Ogrenci giris sayfasından tuttuğumuz değişkeni   doğru veri tipine dönüştürüyoruz ve DersID niteliğine üst sorgudan gelen _dersID değişkenini value olarak gösteriyoruz. En sonda Listele fonksiyonunu çağırarak tabloyu güncelliyoruz.

Örnek bir ekleme işlemi:
![image](https://github.com/user-attachments/assets/c9c680a7-dd18-49c4-8731-024da3977826)

---

### Ders Sil Butonuna Bastığımızda Çalışan SQL Sorguları
```csharp
        private void buttonSil_Click(object sender, EventArgs e)
        { 
            //Tablodan seçilen dersin Ders ID'sini Bulma SQL Sorgusu
            string _secilenders = dataGridViewDersler.CurrentRow.Cells[1].Value.ToString();//GridViewdan dersin adını çekme
            SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT DersID FROM TblDers WHERE DersAd='" + _secilenders + "'";
            SqlDataReader read1 = cmd1.ExecuteReader();
            read1.Read();
            int _dersID = (int)read1["DersID"];
            con1.Close();

            //silme işlemi
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM TblNot WHERE OgrNo='"+ dataGridViewDersler.CurrentRow.Cells[0].Value.ToString()+"' AND DersID='"+_dersID+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            Listele();
            MessageBox.Show("Silme Başarılı");
        }
```
Üstteki sorguda yine bi önceki comboboxtan seçilen dersin Ders ID'sini Bulma SQL Sorgusu ile aynı tek farkı combobax yerine tablodan seçilmesidir. Aynı şekilde açıklamıyorum.

Alttaki sorgu ise DELETE sorgusudur. TblNot tablosunda silme işlemi yapıyoruz WHERE koşulu önemli burda çümlü o olmasa tüm tabloyu silerdi. Burada TblNot tablosundaki OgrNo niteliğini dataGridViewDersler’den seçilen satırın öğrenci nosunu(0. Index yani) alıyoruz VE DersID niteliğinin üst sorgudan dönen _dersID değişkenine eşit olan dersi siliyoruz.

Örnek Silme İşlemi Görsel Programlama Dersini seçtim ve Sildim:
![image](https://github.com/user-attachments/assets/beeb11ff-f716-49d9-958a-f0e7535b2b7f)
![image](https://github.com/user-attachments/assets/53621e19-26fb-4f1a-a89e-de93ad777e72)

---

## Öğretmen İletişim Sayfası Formu
![image](https://github.com/user-attachments/assets/5406bbfb-3c01-4a0d-9d4f-da823c3b28ac)

SQL’de ki datalar:
![image](https://github.com/user-attachments/assets/51c9809f-2b5e-4ec2-9d00-c973c9f3557a)

---

### Sayfa Yüklenirken Çalışan SQL Sorguları
```csharp
    public partial class OgretmenIletisimFormu : Form
    {
        DataTable tablo = new DataTable();
        private void OgretmenIletisimFormu_Load(object sender, EventArgs e)
        {
            //BURADA WİEW KULLANIMI VARDIR OgretmenListesi
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM OgretmenListesi", con);
            adtr.Fill(tablo);
            dataGridViewOgretmen.DataSource = tablo;
            con.Close();
        }
```
Bu kod bloğunda VİEW kullandım. Yazdığım View:
![image](https://github.com/user-attachments/assets/3d105bef-0005-4382-be11-d370fe618c5e)
Burada SELECT ile TblOgretmen tablosundaki tüm nitelikleri seçip OgretmenListesi VIEW’ına aktarıyor.

Kod Bloğunda da SELECT ile OgretmenListesi VIEW’ını çağırarak tabloya aktarıyorz.

---

### Öğretmen Arama  
```csharp
      private void textBoxOgrenciNo_TextChanged(object sender, EventArgs e)
        {
            //WİEW KULLANARAK TEXTBOXTAKİ VERİYE GÖRE TABLOYU DEĞİŞTİRME
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM OgretmenListesi WHERE Ad LIKE '" + textBoxAra.Text+"%'", con);
            adtr.Fill(tablo);
            dataGridViewOgretmen.DataSource = tablo;
            con.Close();
        }
```
Bu sorguda yukardaki sorgu ile aynı şekilde tek farkı WHERE koşulu bu koşul ile Ad niteliği LIKE ile textBoxAra’dan dönen değer ile % nin birleşmesi ile gelen değere göre tabloyu yeniden yüklüyor.Mesela textBoxAra ya a yazdık %’nin yanına gelmesiyle a% oluyor ve Ad niteliğinde a ile başlayan tüm öğretmenleri tabloya geri yüklüyor.

Örnek:
![image](https://github.com/user-attachments/assets/54ef85b4-51cf-4a0d-affa-cef8f32aaaea)

---
