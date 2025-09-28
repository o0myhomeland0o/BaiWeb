using System;

namespace WindowsFormsApp1
{
    public class MayTinh
    {
        public double TinhTrungBinh(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Mảng số không hợp lệ.");

            double sum = 0;
            foreach (int n in numbers)
                sum += n;

            return sum / numbers.Length;
        }
    }
}