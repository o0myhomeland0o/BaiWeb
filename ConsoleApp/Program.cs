using System;

namespace tinhtoandongian
{
    // Class MayTinh nằm trong namespace tinhtoandongian
    public class MayTinh
    {
        // Tính trung bình cộng của 5 số (dùng double để cho phép số thập phân)
        public double TinhTrungBinh(double[] numbers)
        {
            if (numbers == null || numbers.Length != 5)
                throw new ArgumentException("Cần nhập đúng 5 số.", nameof(numbers));

            double sum = 0;
            foreach (var n in numbers) sum += n;
            return sum / numbers.Length;
        }
    }
}

class Program
{
    static void Main()
    {
        // Khởi tạo đối tượng từ namespace tinhtoandongian
        var mt = new tinhtoandongian.MayTinh();

        double[] nums = new double[5];
        Console.WriteLine("Nhập 5 số (nhấn Enter sau mỗi số):");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Số {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out nums[i]))
            {
                Console.WriteLine("Giá trị không hợp lệ. Chương trình kết thúc.");
                return;
            }
        }

        try
        {
            double ketQua = mt.TinhTrungBinh(nums);
            Console.WriteLine($"Trung bình cộng của 5 số là: {ketQua}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }

        Console.WriteLine("Nhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}
