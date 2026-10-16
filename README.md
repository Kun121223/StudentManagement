# HỆ THỐNG QUẢN LÝ SINH VIÊN

**Student Management System – ASP.NET Core MVC & Web API**

## 1. Giới thiệu dự án

Student Management là website quản lý thông tin sinh viên được tôi sử dụng để học tập, nghiên cứu và thực hành lập trình backend bằng ASP.NET Core.

Dự án được phát triển tiếp từ một mã nguồn tham khảo, sau đó tôi tiến hành Việt hóa giao diện, chỉnh sửa chức năng và cải thiện quá trình quản lý dữ liệu.

Mục tiêu là tìm hiểu cách xây dựng một ứng dụng web theo mô hình MVC, kết nối cơ sở dữ liệu SQL Server, xây dựng REST API và tổ chức mã nguồn theo nhiều lớp.

## 2. Công nghệ sử dụng

| Thành phần | Công nghệ |
|---|---|
| Backend | ASP.NET Core MVC (.NET 8) |
| Ngôn ngữ | C# |
| Cơ sở dữ liệu | SQL Server |
| ORM | Entity Framework Core 8 |
| Frontend | Razor Views, Bootstrap 5 |
| API | ASP.NET Core Web API |
| Kiểm thử API | Swagger |
| Công cụ lập trình | Visual Studio 2026 |
| Quản lý mã nguồn | Git, GitHub |

**Lưu ý:** Dự án hiện đang sử dụng .NET 8 và có kế hoạch nâng cấp lên .NET 10.

## 3. Chức năng của hệ thống

### Quản lý sinh viên

- Thêm sinh viên mới.
- Hiển thị danh sách sinh viên.
- Tìm kiếm theo mã sinh viên, họ tên, email và ngành học.
- Xem thông tin chi tiết sinh viên.
- Chỉnh sửa thông tin sinh viên.
- Xóa mềm sinh viên.
- Kiểm tra dữ liệu bắt buộc và chống trùng mã sinh viên, email.

### Dashboard

- Thống kê tổng số sinh viên.
- Thống kê số ngành học.
- Thống kê sinh viên theo năm học.
- Hiển thị danh sách sinh viên mới thêm.

### REST API

Hệ thống cung cấp các API chính:

| Phương thức | Endpoint | Chức năng |
|---|---|---|
| GET | `/api/students` | Lấy danh sách |
| GET | `/api/students/{id}` | Lấy chi tiết |
| POST | `/api/students` | Thêm sinh viên |
| PUT | `/api/students/{id}` | Cập nhật sinh viên |
| DELETE | `/api/students/{id}` | Xóa mềm sinh viên |

Có thể kiểm tra API thông qua Swagger.

## 4. Kiến trúc hệ thống

Ứng dụng được tổ chức thành các thành phần:

- **Models:** Định nghĩa đối tượng dữ liệu.
- **Views:** Hiển thị giao diện cho người dùng.
- **Controllers:** Tiếp nhận và xử lý yêu cầu HTTP.
- **Services:** Xử lý nghiệp vụ.
- **Repositories:** Truy vấn dữ liệu.
- **Data:** Cấu hình Entity Framework Core và DbContext.
- **ViewModels:** Truyền dữ liệu và kiểm tra biểu mẫu.
- **Migrations:** Quản lý thay đổi cấu trúc database.

Luồng hoạt động chính:

`Browser → MVC Controller → Service → Repository → Entity Framework Core → SQL Server`

REST API sử dụng lại lớp Service để thực hiện các chức năng quản lý sinh viên.

## 5. Hướng dẫn cài đặt

### Yêu cầu

- Visual Studio 2026 hoặc phiên bản hỗ trợ .NET 8.
- .NET 8 SDK.
- SQL Server Express hoặc LocalDB.
- Git (nếu tải bằng lệnh clone).

### Tải mã nguồn

```bash
git clone https://github.com/Kun121223/StudentManagement.git
```

Mở file `StudentManagement.sln` bằng Visual Studio.

### Cấu hình cơ sở dữ liệu

Cập nhật `DefaultConnection` trong file `appsettings.Development.json` theo SQL Server trên máy.

Ví dụ sử dụng LocalDB:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=StudentManagementDb;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

Giữ các cấu hình khác đang có trong file.

### Tạo database

Mở Package Manager Console, chọn project `StudentManagement`, sau đó chạy:

```powershell
Update-Database
```

### Chạy website

Chọn project `StudentManagement` làm Startup Project và nhấn `F5`.

Các đường dẫn:

- Website: `https://localhost:5001`
- Quản lý sinh viên: `https://localhost:5001/Students`
- Swagger: `https://localhost:5001/swagger`

Cổng có thể thay đổi tùy cấu hình chạy trên máy.

## 6. Những phần đã chỉnh sửa

- Việt hóa giao diện website.
- Việt hóa biểu mẫu và thông báo kiểm tra dữ liệu.
- Điều chỉnh cách hiển thị họ tên và ngày tháng.
- Sửa lỗi thêm lại sinh viên đã xóa mềm bằng filtered unique index.
- Bổ sung EF Core Migration để cập nhật database.

## 7. Định hướng phát triển

Trong thời gian tiếp theo, tôi dự kiến:

- Nâng cấp ASP.NET Core từ .NET 8 lên .NET 10.
- Xây dựng chức năng thùng rác và khôi phục sinh viên.
- Bổ sung quản lý ngành học.
- Xuất danh sách sinh viên thành file Excel hoặc CSV.
- Thêm đăng nhập và phân quyền.
- Cải thiện giao diện và kiểm thử tự động.

## 8. Nguồn tham khảo

Dự án được học tập và phát triển dựa trên mã nguồn ban đầu:

[SOFTDEV-CRUD – apcjomaala1](https://github.com/apcjomaala1/SOFTDEV-CRUD)

Các nội dung Việt hóa, sửa lỗi và tính năng bổ sung được thực hiện trong quá trình học tập, phát triển dự án. Lịch sử commit được sử dụng để theo dõi các thay đổi.