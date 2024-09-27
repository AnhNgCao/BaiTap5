using System;
using System.Transactions;

namespace BaiTap5
{
    internal class Program
    {
        static void BubbleSort(ref int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++) 
                {
                    if (array[j] < array[j + 1]) 
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

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

            // Cau 3 va 4
            int count = 0;     
            int duplicate = 0;  

            int[] alreadyCounted = new int[n];  
            int[] frequency = new int[n];  

            for (int i = 0; i < arr.Length; i++) {
                bool counted = false;

                for (int j = 0; j < count; j++) {
                    if (alreadyCounted[j] == arr[i]) {
                        counted = true;
                        frequency[j]++;  
                        break;
                    }
                }

                if (!counted) {
                    alreadyCounted[count] = arr[i];
                    frequency[count] = 1;
                    count++;  
                }
            }
            int distinctCount = 0;
            for (int i = 0; i < count; i++) {
                if (frequency[i] == 1) {
                    distinctCount++; 
                } else {
                    duplicate++; 
                }
            }
            Console.WriteLine($"The number of distinct element in the array: {distinctCount}");
            Console.WriteLine($"The number of duplicate element in the array: {duplicate}");
            
            // Cau 5
            int odd = 0;
            int even = 0;
            for(int i = 0; i < n; i++) {
                if(arr[i] % 2 == 0) even++;
                else odd++;
            }
            int[] evenArr = new int[even];
            int[] oddArr = new int[odd];

            int evenIndex = 0;
            int oddIndex = 0;

            for(int i = 0; i < n; i++) {
                if(arr[i] % 2 == 0) {
                    evenArr[evenIndex] = arr[i];
                    evenIndex++;
                }
                else {
                    oddArr[oddIndex] = arr[i];
                    oddIndex++;
                }
            }

            Console.WriteLine("Even Numbers: " + string.Join(" ", evenArr));
            Console.WriteLine("Odd Numbers: " + string.Join(" ", oddArr));

            // Cau 6
            BubbleSort(ref arr);
            Console.WriteLine("Descending array: " + string.Join(" ", arr));

            // Cau 7
            Console.WriteLine($"The second largest element: {arr[1]}");

        }
    }
}