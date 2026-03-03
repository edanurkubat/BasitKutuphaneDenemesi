# 📚 Kütüphane Yönetim Sistemi

Temel SQL Server ve Windows Forms bilgisiyle oluşturulabilen bir kütüphane otomasyon sistemi. Kitap-yazar-emanet işlemleri yapılabilir ve bu işlemlerden istatistikler üretilebilir.

## 📋 Proje Hakkında

Bu proje, C# Windows Forms ve SQL Server kullanılarak geliştirilmiş kapsamlı bir kütüphane yönetim sistemidir. Kitap kayıt işlemlerinden üye yönetimine, emanet takibinden detaylı istatistiklere kadar tüm kütüphane operasyonlarını destekler.

## 🗄️ Veritabanı Yapısı

Proje 5 ana tablo üzerinde çalışmaktadır:

### TblKitaplar
| Alan | Tip | Açıklama |
|------|-----|----------|
| KitapID | int | Primary Key |
| KitapAd | nvarchar | Kitap adı |
| Yazar | int | Foreign Key (TblYazar) |
| Sayfa | int | Sayfa sayısı |
| Yayinevi | int | Foreign Key (TblYayinevi) |
| Tur | nvarchar | Kitap türü |
| Durum | bit | Müsait/Emanette durumu |

### TblUye
| Alan | Tip | Açıklama |
|------|-----|----------|
| UyeID | int | Primary Key |
| KullaniciAdi | nvarchar | Kullanıcı adı |
| Sifre | nvarchar | Şifre |

### TblYazar
| Alan | Tip | Açıklama |
|------|-----|----------|
| ID | int | Primary Key |
| AdSoyad | nvarchar | Yazar adı soyadı |
| DogumTarihi | date | Doğum tarihi |

### TblYayinevi
| Alan | Tip | Açıklama |
|------|-----|----------|
| ID | int | Primary Key |
| Ad | nvarchar | Yayınevi adı |

### TblEmanet
| Alan | Tip | Açıklama |
|------|-----|----------|
| EmanetID | int | Primary Key |
| UyeID | int | Foreign Key (TblUye) |
| KitapID | int | Foreign Key (TblKitaplar) |
| AlisTarihi | date | Kitap alış tarihi |
| TeslimTarihi | date | Kitap teslim tarihi |

## ✨ Özellikler

### 🔐 Giriş Sistemi
- Kullanıcı adı ve şifre doğrulaması
- Güvenlik kodu üretimi ve doğrulaması
- Her uyarıdan sonra değişen dinamik kod
- Kayıtlı kullanıcı kontrolü
- Hatalı giriş uyarıları
- Üye olma ve şifre sıfırlama seçenekleri
- Enter tuşuyla hızlı giriş

![Giriş Ekranı](https://github.com/user-attachments/assets/9675b19d-6d55-404c-aa45-19ed3306e2db)


### 📝 Üye Kayıt Sistemi
- Kullanıcı adı ve şifre girişi
- Şifreyi göster/gizle özelliği
- Minimum 6 karakter şifre zorunluluğu
- Tekrar kullanıcı adı kontrolü
- Boş alan kontrolü
- Otomatik veritabanı kaydı

![Üye Ol](https://github.com/user-attachments/assets/7c097c5d-323c-4bc2-bd1f-b26f63277d60)


### 🔑 Şifre Sıfırlama
- Kullanıcı adı ile şifre güncelleme
- Şifre tekrar doğrulaması
- Kullanıcı varlık kontrolü
- Minimum 6 karakter şifre kuralı
- Başarılı sıfırlamada otomatik anasayfaya yönlendirme

![Şifre Sıfırlama](https://github.com/user-attachments/assets/8e93d21d-9c10-4a55-a548-b0ec3cde4487)

### 📖 Kitap İşlemleri
- Yeni kitap ekleme
- Kitap bilgilerini güncelleme
- Kitap silme
- Sağ tıklama ile liste yenileme
- Yazar ve yayınevi seçimi
- Durum takibi (Müsait/Emanette)

![Kitap İşlemleri 1](https://github.com/user-attachments/assets/8f4db521-4436-4363-80d5-973933e01a49)


### ✍️ Yazar Yönetimi
- Yazar ekleme ve düzenleme
- Yazar bilgilerini güncelleme
- Doğum tarihi kaydı

![Yazar İşlemleri](https://github.com/user-attachments/assets/29f09002-4c15-4ccf-bb78-56008afa8e97)

### 🏢 Yayınevi Yönetimi
- Yayınevi ekleme ve düzenleme
- Yayınevi bilgilerini güncelleme

![Yayınevi İşlemleri](https://github.com/user-attachments/assets/7504e6f3-6682-4a68-8e38-db84fa7ac03b)

### 📋 Emanet Sistemi
- **Emanet Verme:**
  - Tarih seçimi ile emanet kaydı
  - Otomatik kitap durumu güncelleme (Emanette)
  - Aynı üye-kitap eşleşme kontrolü
  - Teslim tarihi girişi kapalı (erken teslimat önleme)

- **Emanet Teslim Alma:**
  - Sadece teslim tarihi girişi aktif
  - Otomatik kitap durumu güncelleme (Müsait)
  - İstatistik verilerinin güncellenmesi

![Emanet Ekle](https://github.com/user-attachments/assets/7dc69f98-3738-4412-a4e9-2a82a5604c3a)

![Emanet Teslim](https://github.com/user-attachments/assets/4869692c-f894-4b7f-b908-2a446ea608d2)

### 📊 İstatistikler ve Raporlama
- **Genel İstatistikler:**
  - Toplam kitap sayısı
  - Toplam üye sayısı
  - Toplam yayınevi sayısı
  - Aktif emanet sayısı
  - Emanetteki kitap sayısı
  - Müsait kitap sayısı

- **Grafikler:**
  - Yazarlara göre kitap sayısı grafiği
  - Yayınevine göre kitap dağılımı chart

![İstatistikler](https://github.com/user-attachments/assets/290c2302-b3b6-410a-94f3-094ffbe1a303)

### 🔍 Kitap Listeleme ve Arama
- Kitap adına göre arama
- Yazar adına göre filtreleme
- Yayınevi adına göre filtreleme
- Tür adına göre arama
- Kombine arama desteği
- Detaylı kitap bilgilerini görüntüleme

![Kitap Listeleme](https://github.com/user-attachments/assets/0db2f58c-40c0-4144-9241-3fa693c100f7)

### 👤 Üye İşlemleri
- Üye ekleme
- Üye silme
- Üye bilgilerini güncelleme
- Üye listesini görüntüleme

![Üye İşlemleri](https://github.com/user-attachments/assets/830f3b02-41cf-4b7e-8076-3f695a8d0be1)

## 🛠️ Kullanılan Teknolojiler

- **IDE:** Visual Studio
- **Programlama Dili:** C#
- **Framework:** .NET Framework / Windows Forms
- **Veritabanı:** Microsoft SQL Server
- **UI Bileşenleri:** MenuStrip, DataGridView, Chart, DateTimePicker



## 💡 Kullanım

1. **İlk Kullanım:**
   - "Üye Ol" butonundan yeni hesap oluşturun
   - Minimum 6 karakterli şifre belirleyin
   - Güvenlik kodu ile giriş yapın

2. **Kütüphane Yönetimi:**
   - Menü çubuğundan ilgili modüle gidin
   - Kitap, yazar ve yayınevi bilgilerini ekleyin
   - Emanet işlemlerini gerçekleştirin

3. **Raporlama:**
   - İstatistik menüsünden detaylı raporları görüntüleyin
   - Grafikleri analiz edin

## 🎯 Proje Hedefleri

- ✅ Kütüphane operasyonlarının dijitalleştirilmesi
- ✅ Kitap-üye takibinin kolaylaştırılması
- ✅ Emanet süreçlerinin otomasyonu
- ✅ Detaylı raporlama ve istatistik üretimi
- ✅ Kullanıcı dostu arayüz tasarımı

## 🚀 Geliştirme Fırsatları

- Kitap rezervasyon sistemi
- Gecikme cezası hesaplama
- E-posta bildirimleri
- Barkod okuyucu entegrasyonu
- Mobil uygulama desteği

##  Geliştirici


- GitHub: [@edanurkubat](https://github.com/edanurkubat)

##  Lisans

Bu proje eğitim amaçlı geliştirilmiştir.




⭐ Projeyi beğendiyseniz yıldız vermeyi unutmayın!

---




# 📚 Library Management System

A library automation system that can be built with basic SQL Server and Windows Forms knowledge. Book-author-loan operations can be performed and statistics can be generated from these operations.

## 📋 About The Project

This project is a comprehensive library management system developed using C# Windows Forms and SQL Server. It supports all library operations from book registration to member management, from loan tracking to detailed statistics.

## 🗄️ Database Structure

The project operates on 5 main tables:

### TblBooks
| Field | Type | Description |
|------|-----|----------|
| BookID | int | Primary Key |
| BookName | nvarchar | Book name |
| Author | int | Foreign Key (TblAuthor) |
| Pages | int | Number of pages |
| Publisher | int | Foreign Key (TblPublisher) |
| Genre | nvarchar | Book genre |
| Status | bit | Available/On Loan status |

### TblMember
| Field | Type | Description |
|------|-----|----------|
| MemberID | int | Primary Key |
| Username | nvarchar | Username |
| Password | nvarchar | Password |

### TblAuthor
| Field | Type | Description |
|------|-----|----------|
| ID | int | Primary Key |
| FullName | nvarchar | Author full name |
| BirthDate | date | Date of birth |

### TblPublisher
| Field | Type | Description |
|------|-----|----------|
| ID | int | Primary Key |
| Name | nvarchar | Publisher name |

### TblLoan
| Field | Type | Description |
|------|-----|----------|
| LoanID | int | Primary Key |
| MemberID | int | Foreign Key (TblMember) |
| BookID | int | Foreign Key (TblBooks) |
| BorrowDate | date | Book borrow date |
| ReturnDate | date | Book return date |

## ✨ Features

### 🔐 Login System
- Username and password verification
- Security code generation and validation
- Dynamic code that changes after each warning
- Registered user check
- Invalid login warnings
- Sign up and password reset options
- Quick login with Enter key

![Login Screen](https://github.com/user-attachments/assets/9675b19d-6d55-404c-aa45-19ed3306e2db)

### 📝 Member Registration System
- Username and password input
- Show/hide password feature
- Minimum 6 character password requirement
- Duplicate username check
- Empty field validation
- Automatic database registration

![Sign Up](https://github.com/user-attachments/assets/7c097c5d-323c-4bc2-bd1f-b26f63277d60)

### 🔑 Password Reset
- Password update via username
- Password confirmation check
- User existence validation
- Minimum 6 character password rule
- Automatic redirect to homepage on successful reset

![Password Reset](https://github.com/user-attachments/assets/8e93d21d-9c10-4a55-a548-b0ec3cde4487)

### 📖 Book Operations
- Add new book
- Update book information
- Delete book
- Refresh list with right-click
- Author and publisher selection
- Status tracking (Available/On Loan)

![Book Operations](https://github.com/user-attachments/assets/8f4db521-4436-4363-80d5-973933e01a49)

### ✍️ Author Management
- Add and edit authors
- Update author information
- Birth date recording

![Author Operations](https://github.com/user-attachments/assets/29f09002-4c15-4ccf-bb78-56008afa8e97)

### 🏢 Publisher Management
- Add and edit publishers
- Update publisher information

![Publisher Operations](https://github.com/user-attachments/assets/7504e6f3-6682-4a68-8e38-db84fa7ac03b)

### 📋 Loan System
- **Issuing a Loan:**
  - Loan record with date selection
  - Automatic book status update (On Loan)
  - Duplicate member-book match check
  - Return date input disabled (to prevent early return entry)

- **Receiving a Return:**
  - Only return date input is active
  - Automatic book status update (Available)
  - Statistics data update

![Add Loan](https://github.com/user-attachments/assets/7dc69f98-3738-4412-a4e9-2a82a5604c3a)

![Return Loan](https://github.com/user-attachments/assets/4869692c-f894-4b7f-b908-2a446ea608d2)

### 📊 Statistics & Reporting
- **General Statistics:**
  - Total number of books
  - Total number of members
  - Total number of publishers
  - Active loan count
  - Number of books on loan
  - Number of available books

- **Charts:**
  - Number of books per author chart
  - Book distribution by publisher chart

![Statistics](https://github.com/user-attachments/assets/290c2302-b3b6-410a-94f3-094ffbe1a303)

### 🔍 Book Listing & Search
- Search by book name
- Filter by author name
- Filter by publisher name
- Search by genre
- Combined search support
- View detailed book information

![Book Listing](https://github.com/user-attachments/assets/0db2f58c-40c0-4144-9241-3fa693c100f7)

### 👤 Member Operations
- Add member
- Delete member
- Update member information
- View member list

![Member Operations](https://github.com/user-attachments/assets/830f3b02-41cf-4b7e-8076-3f695a8d0be1)

## 🛠️ Technologies Used

- **IDE:** Visual Studio
- **Programming Language:** C#
- **Framework:** .NET Framework / Windows Forms
- **Database:** Microsoft SQL Server
- **UI Components:** MenuStrip, DataGridView, Chart, DateTimePicker

## 💡 Usage

1. **First Use:**
   - Create a new account from the "Sign Up" button
   - Set a password with a minimum of 6 characters
   - Log in with the security code

2. **Library Management:**
   - Navigate to the relevant module from the menu bar
   - Add book, author and publisher information
   - Perform loan operations

3. **Reporting:**
   - View detailed reports from the statistics menu
   - Analyze the charts

## 🎯 Project Goals

- ✅ Digitalization of library operations
- ✅ Simplified book-member tracking
- ✅ Automation of loan processes
- ✅ Detailed reporting and statistics generation
- ✅ User-friendly interface design

## 🚀 Future Development Opportunities

- Book reservation system
- Late return fee calculation
- Email notifications
- Barcode reader integration
- Mobile application support

## Developer

- GitHub: [@edanurkubat](https://github.com/edanurkubat)

## License

This project was developed for educational purposes.

---

⭐ If you liked the project, don't forget to give it a star!
