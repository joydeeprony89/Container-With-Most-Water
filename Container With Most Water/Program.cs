using System;

namespace Container_With_Most_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = new int[] { 4, 9, 12, 7, 8, 14 };
            Console.WriteLine(MaxArea(height));
        }

        static int MaxArea(int[] height)
        {
            int l = 0, r = height.Length - 1;
            int max = int.MinValue;
            while(l < r)
            {
                int min = Math.Min(height[l], height[r]);
                max = Math.Max(max, min * (r - l));
                if (height[l] < height[r]) l++;
                else r--;
            }
            return max;
        }
    }
}
