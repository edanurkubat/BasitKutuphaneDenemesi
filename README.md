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

<img width="452" height="533" alt="Ekran görüntüsü 2025-09-27 230224" src="https://github.com/user-attachments/assets/7c097c5d-323c-4bc2-bd1f-b26f63277d60" />

 
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

 <img width="482" height="373" alt="Ekran görüntüsü 2025-09-27 230211" src="https://github.com/user-attachments/assets/8e93d21d-9c10-4a55-a548-b0ec3cde4487" />

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
 <img width="1055" height="618" alt="Ekran görüntüsü 2025-09-27 235505" src="https://github.com/user-attachments/assets/8f4db521-4436-4363-80d5-973933e01a49" />
 
 <img width="1060" height="620" alt="Ekran görüntüsü 2025-09-27 235524" src="https://github.com/user-attachments/assets/829cb2b3-f03d-45d2-af0c-906f8bbadfa6" />

-Yazar yazar işlemleri
 <img width="1062" height="620" alt="Ekran görüntüsü 2025-09-27 235540" src="https://github.com/user-attachments/assets/29f09002-4c15-4ccf-bb78-56008afa8e97" />

-Yayınevi yayınevi işlemleri
 <img width="1060" height="625" alt="Ekran görüntüsü 2025-09-27 235553" src="https://github.com/user-attachments/assets/7504e6f3-6682-4a68-8e38-db84fa7ac03b" />

-Emanet Ekle-Teslim 
        <img width="1060" height="619" alt="Ekran görüntüsü 2025-09-27 235617" src="https://github.com/user-attachments/assets/7dc69f98-3738-4412-a4e9-2a82a5604c3a" />
<img width="1058" height="618" alt="Ekran görüntüsü 2025-09-27 235606" src="https://github.com/user-attachments/assets/4869692c-f894-4b7f-b908-2a446ea608d2" />
 
-İstatistik
 <img width="1067" height="618" alt="Ekran görüntüsü 2025-09-27 235630" src="https://github.com/user-attachments/assets/290c2302-b3b6-410a-94f3-094ffbe1a303" />

*Listeleme iconu (Anasayfa ilk açıldığında görünen ekran)
<img width="1064" height="585" alt="Ekran görüntüsü 2025-09-27 205551" src="https://github.com/user-attachments/assets/0db2f58c-40c0-4144-9241-3fa693c100f7" />

*Üye iconu (Üye işlemleri sil-kaydet-güncelle)                                                                                    
 <img width="501" height="558" alt="Ekran görüntüsü 2025-09-27 235638" src="https://github.com/user-attachments/assets/830f3b02-41cf-4b7e-8076-3f695a8d0be1" />


