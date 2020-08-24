# Bài kiểm tra DAO.NET
Bài này chủ yếu kiểm tra về cách kết nối với SQL Server và Đổ dữ liệu lên Form nên không cần validate các trường.
Nên làm theo mô hình 3 layer thì sẽ được điểm tuyệt đối. Mấy bài mẫu tao đều làm theo 3 lớp.
Bài tương đối dễ nếu code yếu thì chỉ cần đổ dữ liệu lên theo đúng yêu cầu dưới là đạt. Có thể xem video này https://www.youtube.com/watch?v=gNcFLGUHgZI
Cẩn thận nhầm lẫn 2 lớp và 3 lớp nhé!

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