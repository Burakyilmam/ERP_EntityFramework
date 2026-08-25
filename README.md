<h1>Entity Framework ERP Uygulaması</h1>

<p>
.NET Framework ve DevExpress kullanılarak geliştirilen, katmanlı mimariye sahip
masaüstü ERP uygulamasıdır.
</p>

<p>
<b>Not:</b> Proje aktif olarak geliştirme aşamasındadır. Bazı modüller henüz tamamlanmamıştır ve değişiklik gösterebilir.
</p>

<h3>Kullanılan Teknolojiler</h3>

<ul>
  <li><b>DevExpress</b></li>
  <li><b>.NET Framework</b></li>
  <li><b>C#</b></li>
  <li><b>WinForms</b></li>
  <li><b>Entity Framework</b></li>
  <li><b>Microsoft SQL Server (MSSQL)</b></li>
  <li><b>Dependency Injection</b></li>
  <li><b>Katmanlı Mimari</b></li>
</ul>

<h3>Mimari</h3>

<ul>
  <li><b>UI:</b> DevExpress WinForms kullanıcı arayüzü ve MDI yapısı.</li>
  <li><b>Business:</b> Uygulama servisleri ve iş kuralları.</li>
  <li><b>Data Access:</b> Entity Framework ve veri erişim işlemleri.</li>
  <li><b>Entities:</b> Veritabanı entity modelleri ve enum tanımları.</li>
  <li><b>Core:</b> Ortak yardımcı sınıflar ve temel uygulama bileşenleri.</li>
</ul>

<h3>Özellikler</h3>

<ul>
  <li>
    <b>MDI Yapısı:</b>
    ERP modülleri ana form içerisinde MDI child olarak açılabilir.
  </li>

  <li>
    <b>Ribbon Menü:</b>
    Açılan modüle göre ilgili işlemler Ribbon üzerinde gösterilir.
  </li>

  <li>
    <b>Kullanıcı Yönetimi:</b>
    Kullanıcı ekleme, düzenleme, silme ve listeleme işlemleri yapılabilir.
  </li>

  <li>
    <b>Müşteri Yönetimi:</b>
    Müşteri ekleme, düzenleme, silme ve listeleme işlemleri yapılabilir.
  </li>

  <li>
    <b>Tek Form Ekle/Düzenle:</b>
    Aynı form üzerinden hem yeni kayıt oluşturma hem de mevcut kayıtları düzenleme
    işlemleri gerçekleştirilebilir.
  </li>

  <li>
    <b>Klavye Navigasyonu:</b>
    Grid üzerinde Home, End, PageUp, PageDown ve M tuşları ile kayıtlar arasında
    hızlıca geçiş yapılabilir.
  </li>

  <li>
    <b>Excel Export:</b>
    Grid içerisindeki veriler Excel formatında dışarı aktarılabilir.
  </li>

  <li>
    <b>PDF Export:</b>
    Grid içerisindeki veriler PDF formatında dışarı aktarılabilir.
  </li>

  <li>
    <b>HTML Export:</b>
    Grid içerisindeki veriler HTML formatında dışarı aktarılabilir.
  </li>

  <li>
    <b>Yazdırma:</b>
    Grid verileri DevExpress Print Preview üzerinden yazdırılabilir.
  </li>
</ul>

<h3>Kullanıcı Yönetimi</h3>

<p>
Kullanıcı yönetimi ekranı üzerinden kullanıcılar listelenebilir, yeni kullanıcı
oluşturulabilir, mevcut kullanıcılar düzenlenebilir ve seçilen kullanıcılar
silinebilir.
</p>

<h3>Müşteri Yönetimi</h3>

<p>
Müşteri yönetimi ekranı üzerinden müşteri bilgileri yönetilebilir. Müşteri tipi,
müşteri kodu, şirket adı, vergi numarası, doğum tarihi ve açıklama gibi bilgiler
tek bir Add/Edit formu üzerinden yönetilmektedir.
</p>

<h3>Klavye Kısayolları</h3>

<table>
  <tr>
    <th>Tuş</th>
    <th>İşlem</th>
  </tr>
  <tr>
    <td><b>Home</b></td>
    <td>İlk kayda gider.</td>
  </tr>
  <tr>
    <td><b>End</b></td>
    <td>Son kayda gider.</td>
  </tr>
  <tr>
    <td><b>M</b></td>
    <td>Orta kayda gider.</td>
  </tr>
  <tr>
    <td><b>PageUp</b></td>
    <td>Önceki kayda gider.</td>
  </tr>
  <tr>
    <td><b>PageDown</b></td>
    <td>Sonraki kayda gider.</td>
  </tr>
</table>

<h3>Görseller</h3>

<p>
Projenin geliştirme süreci devam ettiği için ekran görüntüleri ve yeni modüller
zaman içerisinde eklenecektir.
</p>

<img width="700" height="350" alt="demo" src="https://github.com/user-attachments/assets/cfb82d36-b514-46d6-a148-803d48117994" />
<img width="700" height="350" alt="login" src="https://github.com/user-attachments/assets/6fe9185b-a9b5-448f-bbb8-ec0fe60b428e" />
<img width="700" height="350" alt="customer" src="https://github.com/user-attachments/assets/c30f03dd-7ec6-40bf-bc2f-ab317eb066e2" />
