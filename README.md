# BasitKutuphaneDenemesi
A Library Automation system that can be built with minimum SQL Server and Windows Forms knowledge. Basic book-author-loan operations can be performed; statistics can be generated from these operations.
Kütüphane Yönetim Sistemi

Tablolar
TblKitaplar (KitapID, KitapAd, Yazar, Sayfa, Yayinevi, Tur, Durum)
TblUye(UyeID, KullaniciAdi, Sifre)
TblYayinevi(ID, Ad)
TblEmanet(EmanetID, UyeID, KitapID, AlisTarihi, TeslimTarihi)
TblYazar(ID, AdSoyad, DogumTarihi)
Özellikler
	Giriş formu
*Kullanıcı adı ve şifre
*Kod ve kod oluşma alanı
*Her uyarıdan sonra değişen kod
*Kullanıcı zaten varsa uyarı
*Kullanıcı Adı şifre uyuşmaması durumunda hata
*Kullanıcı ve şifre doğru; kod yanlış veya boşsa uyarı
*Üye ol ve şifremi unuttum butonu
*Enter’a giriş yap butonunu atama
*Uyarılardan sonra ilgili textboxların temizlenmesi

 <img width="474" height="595" alt="Ekran görüntüsü 2025-09-27 230153" src="https://github.com/user-attachments/assets/9675b19d-6d55-404c-aa45-19ed3306e2db" />


	Üye ol
*Üye ol formunda kullanıcı adı şifre ve şifreyi göster componentleri
*Kullanıcı adı ve şifre girilip üye ol butonuna tıklandığında veri tabanına bilgi girişi
*Bilgi girilmemesi halinde messagebox ile uyarı
*Aynı kullanıcı girilmesi halinde uyarı
*Şifre 6 karakterden kısa ise uyarı
*Geri tuşu ile kapanma


 
	Şifremi unuttum
*Kullanıcı adı ve şifre girişi
*Şifreyi tekrarla 
*Şifre ve şifreyi tekrarla bölümü aynı değilse uyarı
*Kullanıcı bulunmaması halinde uyarı
*En az 6 karakter şifre uzunluğu
*Şifreyi göster checkbox’u
*Butona tıklanması halinde veri tabanında bilgi güncellenmesi
*Uyarılardan sonra ilgili textboxların temizlenmesi
*Doğru bilgilerin girilmesi halinde anasayfa formuna giriş
 
	Anasayfada 
*menustrip componenti
*Bu componenteki başlıklar;
    -Kitap
        #Ekle/Güncelle
        #Sil
       (sağ tık yenile ile liste yenilenir)
    -Yazar
        #Düzenle
    -Yayınevi
        #Düzenle
    -Emanet
        #Ekle
    ** Girilen tarihte emanet ekler ve kitaplar tablosundaki durum kısmını false yapar. Aynı uye-kitap eşleşmesinde uyarı verir. Teslim tarihi verisi girilemez bu şekilde teslim edilme durumunun önüne geçilir.
        #Teslim
     Teslim edilme tarihi dışında diğer componentlerde veri girişi kapalıdır. Teslim tarihi girildiğinde kitaplar tablosundaki durum kısmını true yapar bu şekilde kitap ekleme-güncelleme ekranında teslim edildi check box’ı seçili olur. Ve buna göre istatistikler şekillenir.
    -İstatistik
        #Toplam Kitap Sayısı
        #Yıplam Üye Sayısı
        #Toplam Yayınevi Sayısı
        #Aktif Emanet
        #Emanette
        #Müsait
    *Yazarlara göre kitap sayısı Grafik
    *Yayınevine göre kitap sayısı Chart
istatistikleri tutulur.
 *3 tane buton bunlara icon (kitap listele, Uye düzenle, Uygulama çıkış)
              Kitap listele ikonuna tıklanılarak kitap listeleme ekranına gidilir. Burda kitap, yazar, yayınevi ve tür adına göre tek tek ya da bir arada arama yapılabilir.
 
-Kitap Ekle-Sil-Güncelle kitap işlemleri
             
-Yazar yazar işlemleri
 
-Yayınevi yayınevi işlemleri
 
-Emanet Ekle-Teslim 
         
-İstatistik
 
*Listeleme iconu (Anasayfa ilk açıldığında görünen ekran)
*Üye iconu (Üye işlemleri sil-kaydet-güncelle)
 

