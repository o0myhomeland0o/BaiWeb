using System;

namespace trungbinh
{
    public class MayTinh
    {
        // Hàm tính trung bình cộng của 5 chữ số
        public double TinhTrungBinh(int[] numbers)
        {
            if (numbers.Length != 5)
                throw new Exception("Cần nhập đúng 5 chữ số!");

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return (double)sum / 5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MayTinh mt = new MayTinh();

            int[] nums = new int[5];
            Console.WriteLine("Nhập 5 chữ số:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Số thứ {i + 1}: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            double ketQua = mt.TinhTrungBinh(nums);
            Console.WriteLine($"Trung bình cộng của 5 chữ số là: {ketQua}");
        }
    }
}
