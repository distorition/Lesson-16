using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16
{
    class Program
    {
        const int n = 3;
        const int m = 3;
        static void Main(string[] args)
        {
            int[,] arr = NewMethod();
            Print(n, m, arr);
            Console.WriteLine(Sum(25,3));
            int p = 1;
            int[] mas = new int[p];
            for (int i = 0; i < p; i++)
            {
                mas[i] = 16;
                for (int j = 1; j < p; j++)
                {
                   if(p%2==0)
                    {
                      
                        mas[i] = mas[p - 1] + mas[p/2];
                        Console.WriteLine(mas[i]);
                    }
                   else
                    {
                        mas[i] = mas[p - 1];
                        Console.WriteLine(mas[i]);
                    }
                }
            }
         

        }

        public static int Sum(int num,int second)
        {
            int[] arrs = new int[num];
            for (int i = 0; i < num; i++)
            {
                arrs[i] = second;
                for (int j = second; j < num; j++)
                {
                    if(num%2==0)
                    {
                        return Sum(num - 1,second) + Sum(num / 2,second);
                    }
                    else
                    {
                        return Sum(num - 1,second);
                    }
                    
                }
                
            }
            return num;
        }

        private static int[,] NewMethod()
        {
            int[,] arr = new int[n, m];
            int i, j;
            for (j = 0; j < m; j++)
            {
                arr[0, j] = 1;
            }
            for (i = 1; i < n; i++)
            {
                arr[i, 0] = 1;
                for (j = 1; j < m; j++)
                {
                    arr[i, j] = arr[i, j - 1] + arr[i - 1, j];
                }
            }

            return arr;
        }

        public static void Print(int n, int m, int[,]a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < m; i++)
                {
                    Console.WriteLine(a[i,j]);
                }
                Console.WriteLine("\r\n");
            }
        }

        static int Lenght(string A, string B,int i=0, int j=0)
        {
            if(A.Length==i||B.Length==j)
            {
                return 0;
            }   
            else if(A[i]==B[j])
            {
                return 1 + Lenght(A, B, i + 1, j + 1);
            }
            else
            {
                return Math.Max(Lenght(A, B, i, j + 1), Lenght(A, B, i + 1, j));
            }
        }
    }
}
