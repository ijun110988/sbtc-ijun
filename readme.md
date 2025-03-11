# Employee Management System

## Repository
Repository: **sbtc-ijun**

## Overview
Employee Management System adalah aplikasi berbasis ASP.NET Core MVC yang memungkinkan pengguna untuk mengelola data karyawan, termasuk fitur CRUD (Create, Read, Update, Delete).

## Prerequisites
Pastikan Anda telah menginstal software berikut:
- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio Code / Visual Studio](https://visualstudio.microsoft.com/)

## Installation & Configuration
### 1. Clone Repository
```sh
git clone https://github.com/username/sbtc-ijun.git
cd sbtc-ijun
```

### 2. Konfigurasi Database
Sesuaikan koneksi database di `appsettings.json`:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost,2433;Database=training;User Id=ijun;Password=123;TrustServerCertificate=True"
}
```

### 3. Restore Dependencies
```sh
dotnet restore
```

### 4. Migrasi Database
```sh
dotnet ef database update
```

### 5. Jalankan Aplikasi
```sh
dotnet run
```
Aplikasi akan berjalan di `http://localhost:5000` atau `http://localhost:5078`

## Features
- **Create**: Menambahkan karyawan baru.
- **Read**: Melihat daftar karyawan.
- **Update**: Mengedit data karyawan.
- **Delete**: Menghapus data karyawan.

## API Endpoints
| Method | Endpoint            | Description           |
|--------|--------------------|----------------------|
| GET    | /Employee          | Menampilkan daftar karyawan |
| GET    | /Employee/Edit/{id} | Menampilkan halaman edit |
| POST   | /Employee/Edit/{id} | Menyimpan perubahan data karyawan |
| GET    | /Employee/Delete/{id} | Menampilkan halaman konfirmasi hapus |
| POST   | /Employee/DeleteConfirmed/{id} | Menghapus data karyawan |

## Troubleshooting
- **Error View Not Found**: Pastikan file **View** ada di lokasi berikut:
  - `Views/Employee/Index.cshtml`
  - `Views/Employee/Edit.cshtml`
  - `Views/Employee/Delete.cshtml`
- **Gagal Koneksi ke Database**: Periksa konfigurasi di `appsettings.json` dan pastikan SQL Server berjalan dengan benar.
- **Port Konflik**: Gunakan perintah berikut untuk menjalankan aplikasi di port tertentu:
  ```sh
  dotnet run --urls="http://localhost:5001"
  ```

## License
Aplikasi ini dibuat untuk keperluan latihan dan bersifat open-source. Gunakan sesuai kebutuhan!

---
Jika ada pertanyaan atau masalah, jangan ragu untuk menghubungi! 🚀