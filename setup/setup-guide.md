# Hướng dẫn cài đặt và chạy dự án PetCare - ASP.NET Core

## 1. Yêu cầu hệ thống

- .NET SDK 8.0 trở lên: [https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)
- SQL Server (Express hoặc Developer)
- Visual Studio 2022 (có workload ASP.NET và SQL Server Data Tools)
- Git (tuỳ chọn)

---

## 2. Các bước cài đặt

### Bước 1: Clone source code từ GitHub
```bash
git clone https://github.com/ThanhPhong2611/ASPNET-DK23TTC11-hothanhphong-petcare.git
cd src
cd pet-care
```

### Bước 2: Mở project bằng Visual Studio
- Mở file `PetShopProj.sln` trong thư mục `pet-care` bằng Visual Studio.
- Có thể mở bằng cách nhấn đúp hoặc dùng lệnh:
```bash
start PetShopProj.sln
```

### Bước 3: Khởi chạy project
- Chọn project `PetShopProj` làm project khởi động.
- Nhấn `F5` hoặc chọn **Debug > Start Debugging** để chạy web app trên trình duyệt.