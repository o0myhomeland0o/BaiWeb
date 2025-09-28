# BaiWeb
# Phạm Duy Tiến Minh  
# K225480106048  
# Lớp K58-KTP  

## TẠO SOLUTION GỒM CÁC PROJECT SAU:  

DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).  
Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE  
Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE  
Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.  

# Bài làm :  
# 1.Solution và Project DLL (Class Library .NET Framework 2.0)
Creat a new project > chọn class library (.NET Framework 2.0) và đặt tên, sau đó sửa lại tên file class1 thành trungbinh và thay code trong đó  
<img width="1919" height="1008" alt="image" src="https://github.com/user-attachments/assets/1b6b9058-f6de-4789-a39e-cb554c061514" />

# 2.Project Console App (.NET Framework 2.0)  
Tạo project console app ( .NET Framework 2.0) sửa lại code trong Program.cs  
<img width="1920" height="1024" alt="image" src="https://github.com/user-attachments/assets/5962a6ac-193d-4f7d-9ef0-c189d14a8ed9" />
* Chuột phải lên project và set up as startup project và test F5    
<img width="1920" height="1028" alt="image" src="https://github.com/user-attachments/assets/24fdfb51-b874-4dfe-896e-438333362c4e" />

# 3.Project Windows Forms App (.NET Framework 2.0)  
Dùng code để xây dựng giao diện ở file Program.cs :
<img width="1920" height="1026" alt="image" src="https://github.com/user-attachments/assets/cf1021c5-970c-4218-bd4f-d7bf9f34b393" />

* Save và chuột phải project và set up as startup project và test F5
<img width="1920" height="1026" alt="image" src="https://github.com/user-attachments/assets/5780e927-727c-45cf-9086-44996d26b9eb" />

# 4.Project Web App (ASP.NET Web Application .NET Framework 2.0)

Test :
