# Movie App

Movie App, film ve TV dizilerini kategorilere göre yönetmeyi sağlayan bir web uygulamasıdır. Kullanıcılar, içerikleri görüntüleyebilir, kategorilere göre filtreleyebilir ve değerlendirme yapabilir. Küçük ve orta ölçekli projeler için iyi bir başlangıç noktası sunan bu uygulama, ASP.NET Core MVC üzerine inşa edilmiştir.

## Projenin Amacı
Bu uygulama, film ve TV şovlarını yönetmek için tasarlanmıştır ve aşağıdaki temel işlevleri sunar:
- Filmler ve TV dizilerinin listelenmesi
- Kategorilere göre içeriklerin filtrelenmesi
- İçeriklerin detaylarının görüntülenmesi
- Kullanıcıların içerikleri değerlendirmesi

## Kullanılan Teknolojiler
- **ASP.NET Core MVC**:
  - MVC (Model-View-Controller) mimari pattern'i kullanılarak sayfa yönetimi sağlanmıştır.
- **Entity Framework Core**:
  - ORM (Object-Relational Mapping) aracı olarak kullanılmıştır.
  - Veritabanı işlemleri için Microsoft SQL Server kullanılmıştır.
  - Code-First yaklaşımı benimsenmiştir.
- **Repository Pattern**:
  - Veri erişim katmanı için kullanılmıştır.
  - Gevşek bağlı bir yapı için interface'ler uygulanmıştır.

## Proje Yapısı
### 1. Entity Katmanı
Veritabanı tablolarını temsil eden model sınıflar:
- **Category**: Kategori bilgileri
- **Movie**: Film bilgileri
- **TvShow**: Dizi bilgileri
- **User**: Kullanıcı bilgileri

### 2. DataAccess Katmanı
Veritabanı işlemlerinin yönetildiği katman:
- **AppDbContext**: EF Core DbContext sınıfı
- **ICategoryRepository**: Kategori işlemleri için interface
- **CategoryRepository**: Kategori işlemlerinin implementasyonu

### 3. Controllers
- **HomeController**: Ana sayfa işlemleri
- **CategoryController**: Kategori yönetimi işlemleri

### Mimari Yapı
Proje, **N-Tier Architecture** (Çok Katmanlı Mimari) prensiplerine göre tasarlanmıştır:
1. **Presentation Layer (Sunum Katmanı)**:
   - Controllers
   - Views (Görsel temsiller)
2. **Data Access Layer (Veri Erişim Katmanı)**:
   - Repository Pattern
   - Entity Framework Core
   - Database Context
3. **Entity Layer (Varlık Katmanı)**:
   - Model sınıfları

## Önemli Özellikler
### Dependency Injection
- Constructor injection ile bağımlılık yönetimi yapılmıştır.
- Servis kayıtları `Program.cs` dosyasında gerçekleştirilmiştir.

### Asenkron Programlama
- Repository katmanında `async/await` pattern kullanılmıştır.
- Veritabanı işlemleri asenkron olarak yapılmaktadır.

### Repository Pattern
- CRUD işlemleri için standart bir arayüz sunulmuştur.
- Kod tekrarını önler ve test edilebilirliği artırır.

## Geliştirme Önerileri
1. **Service Layer**:
   - İş mantığını repository'den ayırmak ve "separation of concerns" sağlamak için eklenebilir.
2. **DTO (Data Transfer Objects)**:
   - View'lara özel veri modelleri için kullanılabilir.
   - Veri transferini optimize etmek için faydalıdır.
3. **AutoMapper**:
   - Entity ve DTO'lar arasında mapping için eklenebilir.
4. **Validation Katmanı**:
   - FluentValidation gibi kütüphanelerle veri doğrulama sağlanabilir.

