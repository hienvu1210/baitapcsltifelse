using System.ComponentModel.Design;
using System.Text;
using System.Xml;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        bai1();
        bai2();
        bai3();
        bai4();
        bai5();
        bai6();
        bai7();
        bai8();
        bai9();
        bai10();
    }
    static void bai1()
    {
        Console.WriteLine("tuoi: ");
        int tuoi = int.Parse(Console.ReadLine());
        Console.WriteLine("gio chieu: ");
        int giochieu = int.Parse(Console.ReadLine());
        if (tuoi > 60 || tuoi < 12)
        {
            Console.WriteLine("gia ve cua ban la: 50,000 VND ");
        }
        else if (giochieu < 17)
        {
            Console.WriteLine("gia ve cua ban la: 80,000 VND ");
        }
        else
        { Console.WriteLine("gia ve cua ban la: 110,000 VND "); }

    }
    static void bai2()
    {
        Console.WriteLine("Role: ");
        string role = Console.ReadLine();
        switch (role)
        {
            case "ADMIN":
                Console.WriteLine("[Thông báo]: Toàn quyền quản trị hệ thống.");
                break;
            case "MANAGER":
                Console.WriteLine("[Thông báo]: Quyền quản lý nhân sự và xem báo cáo.");
                break;
            case "EMPLOYEE":
                Console.WriteLine("[Thông báo]: Quyền tạo và chỉnh sửa hồ sơ cá nhân.");
                break;
            case "GUEST":
                Console.WriteLine("[Thông báo]: Chỉ có quyền xem thông tin công khai.");
                break;
            default:
                Console.WriteLine("[Thông báo]: Mã vai trò không hợp lệ!");
                break;
        }
    }
    static void bai3()
    {
        Console.WriteLine("so du: ");
        decimal sodu = decimal.Parse(Console.ReadLine());
        Console.WriteLine("so tien rut: ");
        decimal sotienrut = decimal.Parse(Console.ReadLine());
        if (sotienrut <= 0)
        {
            Console.WriteLine("giao dich that bai ");
        }
        else if (sotienrut % 50000 != 0)
        {
            Console.WriteLine("giao dich that bai ");
        }
        else if (sotienrut > sodu)
        {
            Console.WriteLine("giao dich that bai ");
        }
        else if (sotienrut > 5000000)
        {
            Console.WriteLine("giao dich that bai ");
        }
        else
        {
            decimal soduconlai = sodu - sotienrut;

            Console.WriteLine($"giao dich thanh cong. so du con lai:{soduconlai} VND");
        }

    }
    static void bai4()
    {
        Console.WriteLine("phim bam: ");
        int phimbam = int.Parse(Console.ReadLine());
        switch (phimbam)
        {
            case 1:
                Console.WriteLine("[Tổng đài]: Kết nối với tổng đài viên tư vấn thẻ.");
                break;
            case 2:
                Console.WriteLine("[Tổng đài]: Đang tra cứu số dư tài khoản.");
                break;
            case 3:
                Console.WriteLine("[Tổng đài]: Yêu cầu khóa thẻ khẩn cấp đã được ghi nhận.");
                break;

            case 4:
                Console.WriteLine("[Tổng đài]: Đang tra cứu tỷ giá ngoại tệ.");
                break;
            case 0:
                Console.WriteLine("[Tổng đài]: Quay lại menu chính.");
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại!");
                break;



        }
    }
    static void bai5()
    {
        Console.WriteLine("so km: ");
        double sokm = double.Parse(Console.ReadLine());
        double tongTien = 0;
        if (sokm <= 1)
        {
            tongTien = 15000 ;
        }
        else if (sokm >=2 && sokm <=10)
        {
            tongTien = 15000 + (sokm - 1) * 120000;
        }
        else 
        {
            tongTien = 15000 + 9 * 12000 + (sokm - 10) * 10000;
        }
        double tientruocgiam = tongTien;
        double khuyenmai = 0;
        if (sokm >30 )
        {
            khuyenmai = 0.1 * tongTien;
            tongTien = tongTien - khuyenmai;
        }
        Console.WriteLine($"Tổng tiền trước giảm: {tientruocgiam} VNĐ");
        if (sokm >30)
        {
            Console.WriteLine($"Khuyến mãi (10%): -{khuyenmai} VNĐ");
        }
        Console.WriteLine($"Thành tiền: {tongTien} VNĐ");
    }
    static void bai6()
    {
        

        Console.Write("Nhập mã trạng thái đơn hàng (1-5): ");
        int trangThai = int.Parse(Console.ReadLine());

        switch (trangThai)
        {
            case 1:
                Console.WriteLine("[Trạng thái]: Chờ xác nhận thanh toán.");
                break;
            case 2:
                Console.WriteLine("[Trạng thái]: Đang đóng gói và bàn giao đơn vị vận chuyển.");
                break;
            case 3:
                Console.WriteLine("[Trạng thái]: Đơn hàng đang trên đường giao đến bạn.");
                break;
            case 4:
                Console.WriteLine("[Trạng thái]: Đơn hàng đã hoàn thành. Cảm ơn bạn!");
                break;
            case 5:
                Console.WriteLine("[Trạng thái]: Đơn hàng đã hủy. Xuất phiếu hoàn tiền.");
                break;
            default:
                Console.WriteLine("[Trạng thái]: Mã trạng thái không hợp lệ!");
                break;
        }
    }
    static void bai7()
    {
        Console.WriteLine("can nang: ");
        double cannang = double. Parse(Console.ReadLine());
        Console.WriteLine("chieu cao: ");
        double chieucao = double. Parse(Console.ReadLine());
        double bmi = cannang / Math.Pow(2, chieucao);
        string phanLoai = "";
        if (bmi < 18.5)
        {
            phanLoai = "Gầy (Thiếu cân)";
        }
        else if (bmi < 23.0)
        {
            phanLoai = "Bình thường (Lý tưởng)";
        }
        else if (bmi < 25.0)
        {
            phanLoai = "Thừa cân (Tiền béo phì)";
        }
        else // bmi >= 25.0
        {
            phanLoai = "Béo phì";
        }
        // Tính dải cân nặng lý tưởng
        double canNangToiThieu = 18.5 * Math.Pow(chieucao, 2);
        double canNangToiDa = 22.9 * Math.Pow(chieucao, 2);

        // In kết quả
        Console.WriteLine("\n--- OUTPUT ---");
        // Dùng {0:F2} hoặc nội suy chuỗi {biến:F2} để lấy 2 chữ số thập phân
        Console.WriteLine($"Chi so BMI cua ban: {bmi:F2}");
        Console.WriteLine($"Phan loai suc khoe: {phanLoai}");
        Console.WriteLine($"Khuyen dung: Can nang ly tuong cua ban nen tu {canNangToiThieu:F2} kg den {canNangToiDa:F2} kg.");

    }
    static void bai8()
    {
        Console.WriteLine("loai xe: ");
        string loaiXe = Console.ReadLine();
        Console.WriteLine("thoi gian: ");
        int thoiGian = int. Parse(Console.ReadLine());
        decimal phiGui = 0;
        string tenXe = "";
        string buoi = "";

        switch (loaiXe)
        {
            case "BIKE":
                tenXe = "xe máy";
                if (thoiGian == 1)
                {
                    phiGui = 5000;
                    buoi = "Ban ngày";
                }
                else if (thoiGian == 2)
                {
                    phiGui = 10000;
                    buoi = "Ban đêm";
                }
                break;

            case "CAR":
                tenXe = "ôtô";
                if (thoiGian == 1)
                {
                    phiGui = 30000;
                    buoi = "Ban ngày";
                }
                else if (thoiGian == 2)
                {
                    phiGui = 60000;
                    buoi = "Ban đêm";
                }
                break;

            default:
                Console.WriteLine("Loại xe không hợp lệ!");
                return;
        }

        if (thoiGian != 1 && thoiGian != 2)
        {
            Console.WriteLine("Thời gian gửi không hợp lệ!");
        }
        else
        {
            Console.WriteLine($"Phí gửi xe {tenXe} ({buoi}): {phiGui:N0} VNĐ");
        }
    }
   static void bai9()
    {
        Console.WriteLine("GPA: ");
        double gpa = double.Parse(Console.ReadLine());
        Console.WriteLine("DRL: ");
        int drl = int .Parse(Console.ReadLine());
        if (gpa >= 3.6 && drl >= 90)
        {
            Console.WriteLine("Kết quả: Học bổng Xuất sắc (Mức 100%)");
        }
        else if (gpa >= 3.2 && drl >= 80)
        {
            Console.WriteLine("Kết quả: Học bổng Khá/Giỏi (Mức 50%)");
        }
        else
        {
            Console.WriteLine("Kết quả: Không đạt học bổng.");
        }
    }
    static void bai10()
    {
        Console.Write("Nhập số tiền VNĐ: ");
        decimal soTienVnd = decimal.Parse(Console.ReadLine());

        Console.Write("Nhập mã ngoại tệ (\"USD\", \"EUR\", \"JPY\"): ");
        string maNgoaiTe = Console.ReadLine()?.ToUpper();

        decimal soTienQuyDoi = 0;
        bool hopLe = true;

        switch (maNgoaiTe)
        {
            case "USD":
                soTienQuyDoi = soTienVnd / 25400m;
                break;
            case "EUR":
                soTienQuyDoi = soTienVnd / 27200m;
                break;
            case "JPY":
                soTienQuyDoi = soTienVnd / 165m;
                break;
            default:
                Console.WriteLine("Mã ngoại tệ không hợp lệ!");
                hopLe = false;
                break;
        }

        if (hopLe)
        {
            Console.WriteLine($"Số tiền sau quy đổi: {soTienQuyDoi:F2} {maNgoaiTe}");
        }
    }
}
