# 🚀 YummyRestoran - Çok Katmanlı API & UI Yönetim Sistemi

**YummyRestoran**, kurumsal mimari prensiplerine sadık kalınarak geliştirilmiş; API merkezli, çok katmanlı ve modern bir yönetim sistemidir. 
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
<br/>
<img width="922" height="845" alt="image" src="https://github.com/user-attachments/assets/7a2591d0-209e-4714-b629-9e6974f8c659" />
<br/>
<img width="930" height="759" alt="image" src="https://github.com/user-attachments/assets/3915816f-c1da-4e8b-9f95-03a955d2ee1e" />
<br/>
<img width="959" height="707" alt="image" src="https://github.com/user-attachments/assets/6b0f0669-3887-4be6-86c1-582eaa7eae4f" />
<br/>

<img width="868" height="726" alt="image" src="https://github.com/user-attachments/assets/039a459d-529a-4b9d-ba97-3d5a5ef3a040" />
<br/>
<img width="1090" height="837" alt="image" src="https://github.com/user-attachments/assets/4f464c76-c23b-4f0f-b364-a38a3db00cb6" />

<br/>
<img width="949" height="776" alt="image" src="https://github.com/user-attachments/assets/551b1c25-c762-4e68-a8ea-e96861332a98" />
<br/>
<img width="910" height="825" alt="image" src="https://github.com/user-attachments/assets/c769e600-4060-4a66-a5a5-0180cd502c21" />
<br/>


<img width="5120" height="16374" alt="localhost_7222_swagger_index html" src="https://github.com/user-attachments/assets/0c193608-e042-47be-8543-d0a8a67d9d57" />
<br/>
<img width="2386" height="9256" alt="localhost_7224_dashboard_Index" src="https://github.com/user-attachments/assets/778cd1b7-ffc3-4a87-b5e9-20fb288d1819" />
<br/>

<img width="1585" height="831" alt="image" src="https://github.com/user-attachments/assets/69340ada-e604-4777-8d5f-5b0bb717a93c" />
<br/>
<img width="1567" height="825" alt="image" src="https://github.com/user-attachments/assets/8e17e13a-5d79-462e-a72e-8816a2f0e0f9" />
<br/>
<img width="1639" height="390" alt="image" src="https://github.com/user-attachments/assets/0ee545f6-7dfc-4eeb-a1a6-b6046094d279" />
<br/>
<img width="1618" height="382" alt="image" src="https://github.com/user-attachments/assets/6603b924-35cc-4ff3-ac9a-c20dddd882b7" />
<br/>

<img width="1617" height="400" alt="image" src="https://github.com/user-attachments/assets/52f6e7f6-6215-4b22-98c4-51ab930dafb3" />
<br/>
<img width="1495" height="449" alt="image" src="https://github.com/user-attachments/assets/625883b1-9725-426a-ac1f-29153e4bec65" />
<br/>
<img width="1606" height="788" alt="image" src="https://github.com/user-attachments/assets/51bd724a-db34-462f-8b72-c28b7640ffef" />
<br/>
<img width="1630" height="791" alt="image" src="https://github.com/user-attachments/assets/6078db31-faac-4bf0-b2a1-868325e4cb51" />
<br/>

<img width="1594" height="701" alt="image" src="https://github.com/user-attachments/assets/55de044b-7ba4-4bed-8bc1-9fb2af81e216" />
<br/>
<img width="1589" height="852" alt="image" src="https://github.com/user-attachments/assets/9a158fd9-1018-4587-9128-3dafbf427c35" />
<br/>

<img width="1597" height="813" alt="image" src="https://github.com/user-attachments/assets/319654d4-8070-4de8-b802-b149c08d33e4" />

<br/>
<img width="1591" height="816" alt="image" src="https://github.com/user-attachments/assets/bb58435e-fb23-4a72-a1b0-a716e623719f" />
<br/>
<img width="1591" height="772" alt="image" src="https://github.com/user-attachments/assets/2e25333c-279e-445f-b146-63507b100496" />

<br/>
<img width="1608" height="764" alt="image" src="https://github.com/user-attachments/assets/39962798-9ab5-4968-b82c-63babf62fad4" />
<br/>
<img width="1495" height="636" alt="image" src="https://github.com/user-attachments/assets/3c27ad8b-09bb-42d3-a75a-520a894c6444" />
<br/>
<img width="1855" height="942" alt="image" src="https://github.com/user-attachments/assets/4d22eb61-aa81-4b1b-bb8f-78aa64bcbb08" />
<br/>
<img width="306" height="453" alt="image" src="https://github.com/user-attachments/assets/0de66a8f-31c2-48c1-8e76-8eb7d848bbc3" />
<br/>
<img width="938" height="554" alt="image" src="https://github.com/user-attachments/assets/eb27b661-e5ff-4600-82bd-fa3315aa41d4" />
<br/>
<br/>
<br/>

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
