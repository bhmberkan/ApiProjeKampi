# 🚀 ApiProjeKampi - Çok Katmanlı API & UI Yönetim Sistemi

**ApiProjeKampi**, kurumsal mimari prensiplerine sadık kalınarak geliştirilmiş; API merkezli, çok katmanlı ve modern bir yönetim sistemidir. 
Proje, verinin güvenli bir şekilde işlenip API üzerinden dış dünyaya sunulması ve bu verilerin bir UI (Arayüz) tarafında efektif bir şekilde tüketilmesini (consuming) temel alır.

---

## 📁 Proje Yapısı

```
ApiProjeKampi/
├── ApiConsume/                  # API Servislerinin Tüketildiği Katmanlar
│   ├── Project.DtoLayer/        # Veri Transfer Nesneleri (DTO)
│   ├── Project.EntityLayer/     # Veritabanı Tablo Modelleri
│   ├── Project.DataAccessLayer/ # Entity Framework Core & Context Yapısı
│   ├── Project.BusinessLayer/   # İş Mantığı ve Validasyonlar
│   ├── Project.WebApi/          # RESTful API Endpoint'leri ve Swagger
│
└── Project.WebUI/               # Verilerin Sergilendiği ASP.NET Core MVC Arayüzü
    ├── Controllers/             # API ile Haberleşen (HttpClient) Controllerlar
    ├── Views/                   # Dinamik Razor Sayfaları
    └── wwwroot/                 # CSS, JS ve Tema Dosyaları

## 📁 Proje Yapısı

```

---

## 🛠️ Kullanılan Teknolojiler

Alan	--- Kullanılan Araç ---- Teknoloji
Backend	--- .NET Core 6.0 / 8.0, --- ASP.NET Web API
ORM / DB	---  Entity Framework Core,---  MS SQL Server
API Dokümantasyon ---  	Swagger ---  OpenAPI
UI Framework	---  ASP.NET Core MVC, ---  Bootstrap
API İletişimi --- 	HttpClient ---  JSON Serialization/Deserialization
Mimari Tasarım --- 	Standart  Pattern ---  DTO Pattern

---



## 🧪 Uygulama Özellikleri 

--Tam Kapsamlı CRUD: API üzerinden kategori, ürün ve personel yönetim süreçleri.

--API Consuming: Verilerin API katmanından HttpClient kullanılarak asenkron şekilde UI tarafına çekilmesi.

--Merkezi Dokümantasyon: Tüm uç noktaların Swagger üzerinden test edilebilir yapısı.

--Dinamik Arayüz: Kullanıcı dostu, modern dashboard tasarımları.

--Katmanlı Mimari: Sorumlulukların ayrılması (Separation of Concerns) prensibine uygun yapı.Tam Kapsamlı CRUD: API üzerinden kategori, ürün ve personel yönetim süreçleri.

--API Consuming: Verilerin API katmanından HttpClient kullanılarak asenkron şekilde UI tarafına çekilmesi.

--Merkezi Dokümantasyon: Tüm uç noktaların Swagger üzerinden test edilebilir yapısı.

--Dinamik Arayüz: Kullanıcı dostu, modern dashboard tasarımları.

--Katmanlı Mimari: Sorumlulukların ayrılması (Separation of Concerns) prensibine uygun yapı.

---


## 🎯 Geliştirme Aşamaları

- [x] Veritabanı tablolarının ve ilişkilerinin (Migration) tasarımı.
- [x] Generic Repository yapısı ile veri erişiminin standardize edilmesi.
- [x] UI tarafında API'den gelen verilerin modellenmesi (DTO Mapping).
- [x] Web API üzerinde Controller ve Endpoint yapılarının kurgulanması.
- [x] Listeleme, Ekleme, Güncelleme ve Silme (CRUD) işlevlerinin UI tarafına entegrasyonu.
- [x] Kullanıcı rolleri ve oturum yönetimi
- [x] Modern bir Dashboard temasının projeye giydirilmesi.
- [x] Pagging
---


## 📸 **Proje Görselleri**
---


---


## ⚙️ Kurulum Talimatları

### 1. Reponun Klonlanması
```bash
git clone https://github.com/bhmberkan/ApiProjeKampi.git
```

### 2. Veritabanı Ayarları
`appsettings.json` dosyasını açarak kendi SQL Server bağlantınızı girin:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=ApiYummyDb;Trusted_Connection=True;"
}
```

> ❗ Not: Eğer `ApiYummyDb` veritabanınız yoksa SQL script dosyası ile oluşturmanız gerekebilir.

### 3. Projeyi Çalıştırma



#### UI tarafı için:
```bash
cd ApiProjeKampi/ApiProjeKampiWebUI
dotnet restore
dotnet run
```

### 4. Swagger ile API Testi
Aşağıdaki adresi tarayıcınızda açarak API uç noktalarını test edebilirsiniz:
```
https://localhost:5001/swagger/index
```

---

## 🔐 Örnek API Endpoint'leri

| Yöntem | URL | Açıklama |
|--------|-----|----------|
| `GET`  | `/api/Reservation`         | Tüm Rezervasyonları getirir |
| `POST` | `/api/Reservation`         | Yeni Rezervasyon ekler |
| `GET`  | `/api/Reservationv/{id}`    | ID'ye göre Rezervasyon getir |
| `PUT`  | `/api/Reservation/{id}`    | Rezervasyon bilgisini günceller |
| `DELETE` | `/api/Reservation/{id}`  | RezervasyonRezervasyon bilgisini siler |

---



## 👨‍💻 Geliştirici Bilgisi

- **👤 Adı**: Berkan Burak Turgut  
- 💼 **LinkedIn**: [linkedin.com/in/berkanburakturgut](https://www.linkedin.com/in/berkan-turgut-2a277a232/)  
- 💻 **GitHub**: [github.com/bhmberkan](https://github.com/bhmberkan)  
- 📧 **E-posta**: berkanburakturgut@gmail.com  

---

## 📄 Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına göz atabilirsiniz.

---

## 🤝 Katkı Sağla

Her türlü katkıya açığız!

1. Fork'la ⭐  
2. Yeni bir branch oluştur  
3. Değişikliklerini commit et  
4. Pull Request gönder  
5. Kodu birlikte büyütelim!

---

## 📌 Notlar

- Bu proje **öğrenme odaklı** bir tam yığın uygulamadır.
- UI ile API arasındaki iletişim tamamen `HttpClient` üzerinden gerçekleşir.
- Swagger dokümantasyonu otomatik olarak oluşturulmuştur.
