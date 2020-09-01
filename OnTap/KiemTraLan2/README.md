# Bài kiểm tra DAO.NET
- Bài này chủ yếu kiểm tra về cách kết nối với SQL Server và Đổ dữ liệu lên Form nên không cần validate các trường.
- Nên làm theo mô hình 3 layer thì sẽ được điểm tuyệt đối. Mấy bài mẫu tao đều làm theo 3 lớp.
- Nếu không làm đủ 3 lớp có thể xem [video này](https://www.youtube.com/watch?v=gNcFLGUHgZI) hay tham khảo [code này của MR.Tuấn](https://github.com/hqtuangithub/CSharp)

Bài kiểm tra này tao đéo chụp được đề, nhưng cơ bản yêu cầu nó như dưới, form tự thiết kế.

## CẤU TRÚC BÀI KIỂM TRA SỐ 2 – THỜI GIAN 60P
CHUẨN BỊ CSDL:  Tạo csdl trong SqlServer gồm 2 bảng có quan hệ 1- nhiều, cấu trúc bảng cho trước
SỬ DỤNG ADO.NET VIẾT CODE
1.	Hiển thị bảng trong DataGridView (2đ)
2.	Viết code để khi người dùng chọn 1 dòng trong data grid view thì dữ liệu được hiển thị trong các điều khiển nhập liệu tương ứng (1đ)
3.	Thêm 1 bản ghi  (1đ)
4.	Sửa thông tin 1 bản ghi theo mã  (1đ)
5.	Xóa 1 bản ghi mã , có hiển thị yêu cầu xác nhận xóa (1đ)
6.	Tìm 1 bản ghi theo mã, có thông báo khi không tìm thấy (1đ)
7.	Sử dụng combo box hiển thị tên nhưng khi chọn lấy mã để cập nhật dữ liệu (1đ)
8.	Viết ứng dụng 3 tầng (2đ)

## Config
- Import Database
- Edit SQL string connection trong **Project/DALs/xxx.cs**

## Demo Project
![QuanLyBenhNhan](https://i.imgur.com/tPgUM9D.png)
![QuanLyHoaDonDien](https://i.imgur.com/cdD0w1W.png)
![QuanLyNhac](https://i.imgur.com/owtuHdq.png)
![QuanLyNhanVien](https://i.imgur.com/L7IR48U.png)
![QuanLySach](https://i.imgur.com/tE1GNig.png)
![QuanLySanPham](https://i.imgur.com/Qhs25Vn.png)
