using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> array = new List<int>();
            List<int> array1 = new List<int>();
            //ex1(rnd, array);
            //ex2(rnd, array, array1);
            //ex3(rnd, array);
            //ex4(rnd, array);
            //ex5(array);
            //ex6(rnd, array);
            //ex7(array);
            //array = ex8();
            //ex9(rnd, array);
            //ex10();
            //ex11();
            //ex12(array);
            int[] A = new int[10] { 1, 2, 3, 4, 10, 6, 7, 8, 9, 5 };
            int max = A.Max();
            int indexmax = Array.IndexOf(A, max);
            for (int i = 0; i < A.Length; i++)
            {
                if (i < indexmax)
                {
                    array.Add(A[i]);
                    Console.WriteLine(A[i]);
                }
            }
        }

        private static void ex12(List<int> array)
        {
            int[] A = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] B = new int[10] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 0; i < A.Length; i++)
            {
                array.Add(A[i]);
                array.Add(B[i]);
            }
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void ex11()
        {
            List<int> C = new List<int>();
            List<int> B = new List<int>();
            int[] A = new int[10] { 1, 2, 3, 4, -5, 6, 7, -8, 9, 10 };
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    B.Add(A[i]);
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    C.Add(A[i]);
                }
            }
            for (int i = 0; i < C.Count; i++)
            {
                Console.WriteLine(C[i]);
            }
            Console.WriteLine("-----------------------");
            for (int i = 0; i < B.Count; i++)
            {
                Console.WriteLine(B[i]);
            }
        }

        private static void ex10()
        {
            List<int> C = new List<int>();
            int[] A = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] B = new int[13] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            for (int i = 0; i < A.Length; i++)
            {
                C.Add(A[i]);
            }
            for (int i = 0; i < B.Length; i++)
            {
                C.Add(B[i]);

            }
            for (int i = 0; i < C.Count; i++)
            {
                Console.WriteLine(C[i]);
            }
        }

        private static void ex9(Random rnd, List<int> array)
        {
            for (int i = 0; i < 10; i++)
            {
                array.Add(rnd.Next(-10, 10));
                Console.WriteLine(array[i]);

            }
            Console.WriteLine("---------");
            int min = array.Min();
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == min)
                {
                    array.Remove(array[i]);
                }
                Console.WriteLine(array[i]);
            }
        }

        private static List<int> ex8()
        {
            List<int> array;
            int[] result = new int[10] { 1, 8, -53, 5, 6, -7, 0, 5, 3, -9 };
            array = result.ToList();
            for (int i = 0; i < array.Count - 1; i++)
            {
                if (array[i] < 0)
                {
                    array.Remove(array[i]);
                }
                Console.WriteLine(array[i]);
            }

            return array;
        }

        private static void ex7(List<int> array)
        {
            int[] result = new int[10] { 1, 8, -53, 5, 6, -7, 0, 5, 3, -9 };
            for (int i = 0; i < result.Length; i++)
            {
                int d = Array.IndexOf(result, result[i]);
                if (d % 2 != 0)
                {
                    array.Add(result[i]);
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                int a = Array.IndexOf(result, result[i]);
                if (a % 2 == 0)
                {
                    array.Add(result[i]);
                }
                Console.WriteLine(array[i]);
            }
        }

        private static void ex6(Random rnd, List<int> array)
        {
            for (int i = 0; i < 10; i++)
            {
                array.Add(rnd.Next(-10, 10));
                
            }
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == 0)
                {
                    array.Remove(array[i]);
                }
                Console.WriteLine(array[i]);
            }
        }

        private static void ex5(List<int> array)
        {
            int[] mass = new int[10] { 1, 8, -53, 5, 6, -7, 0, 5, 3, -9 }; 
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= 0)
                {
                    array.Add(mass[i]);
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    array.Add(mass[i]);
                }
                Console.WriteLine(array[i]);
            }
        }

        private static void ex4(Random rnd, List<int> array)
        {
            int[] result = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array.Add(rnd.Next(-10, 10));

            }
            for (int i = 0; i < 10; i++)
            {
                result[i] = array[i];
                Console.WriteLine(result[i]);
            }
        }

        private static void ex3(Random rnd, List<int> array)
        {
            for (int i = 0; i < 10; i++)
            {
                array.Add(rnd.Next(-10, 10));
                if (array[i] > 0)
                {
                    array[i] = 0;
                }
                Console.WriteLine(array[i]);
            }
        }

        private static void ex2(Random rnd, List<int> array, List<int> array1)
        {
            for (int i = 0; i < 6; i++)
            {
                array.Add(rnd.Next(-100, 10));
                Console.WriteLine(array[i]);
                int d = array[i];
                if (d > 0)
                {
                    array1.Add(d);

                }
            }
            Console.WriteLine("---------");
            for (int i = 0; i < array1.Count; i++)
            {
                Console.WriteLine(array1[i]);
            }
        }

        private static void ex1(Random rnd, List<int> array)
        {
            for (int i = 0; i < 10; i++)
            {
                array.Add(rnd.Next(-10, 10));
                if (array[i] > 0)
                {
                    Console.WriteLine(array.IndexOf(array[i]));
                }
            }
        }
    }
}
