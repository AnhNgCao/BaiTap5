using System;

namespace BaiTap5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai tap lam quen voi kieu du lieu mang - Array
            // Vi de bai khong noi ro la phan tu duoc nhap vao co kieu du lieu nhu the nao
            // -> tat ca cac phan tu duoc su dung trong bai tap se la kieu so nguyen (integer)
            
            // Init an array 
            Console.Write("Enter the number of elements in the array (n): ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            int[] arr = new int[n];

            // Cau 1
            // Init value for each element
            for(int i = 0; i < n; i++) {
                Console.Write($"Enter the number for arr[{i}]: ");
                arr[i]  = int.Parse(Console.ReadLine() ?? "0");
            }

            for(int i = 0; i < n; i++) {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            // Cau 2
            Console.WriteLine("Array in reverse: ");
            for(int i = n-1; i >= 0; i--) {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            // Cau 3
            int count = 0;
            int[] clone = (int[])arr.Clone();
            for(int i = 0; i < clone.Length; i++) {
                for(int j = i + 1; j < clone.Length; j++) {
                    if(clone[i] == clone[j]) {
                        
                    }
                }
            }
            // 1 3 5 7 4 3 5 8 9 1 1

        }
    }
}