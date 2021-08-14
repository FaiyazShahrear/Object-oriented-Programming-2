using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            //OurAddress add1 = new OurAddress(12, 3, 4546, "Sylhet");
            //Student studentOne = new Student(100, "Bruce", 3.76, "O+", new OurAddress(12, 3, 4546, "Sylhet"));
            //Student s1 = new Student();
            //studentOne.SetId(100);
            //studentOne.SetName("Bruce");
            //studentOne.SetCgpa(3.76);
            //studentOne.SetBloodGroup("O+");
            //Console.WriteLine(studentOne.GetCgpa());
            //studentOne.ShowStudentInfo();

            //Student studentTwo = new Student(101, "Clerk", 3.42, "B+");
            //studentTwo.SetBloodGroup("AB+");
            //studentTwo.ShowStudentInfo();
            //double[] bx = new double[3] {2.4, 5.8, 3.45};

            //int[] ax = new int[5] {233, 67, -109, 2, 77};

            //byte u = 0;
            //while (u < ax.Length)
            //{
            //    Console.WriteLine("{0}", ax[u]);
            //    u++;
            //}

            //int[,] cx = new int[3, 4] {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}};

            //byte r = 0, c;
            //while (r < 3)
            //{
            //    c = 0;
            //    while (c < 4)
            //    {
            //        Console.Write("{0} ", cx[r,c]);
            //        c++;
            //    }
            //    Console.WriteLine();
            //    r++;
            //}
            
            //int[,,,] dx = new int[2,3,2,7];
            
            //foreach (int v in cx)
            //{
            //    Console.WriteLine("{0}", v);
            //}

            //ax[0] = 233;
            //ax[1] = 67;
            //ax[2] = -109;
            //ax[3] = 2;
            //ax[4] = 77;

            //byte u;
            //for (u =0 ; u < 5; u++ )
            //{
            //    Console.WriteLine("{0}", ax[u]);
            //    u++;
            //}
            //Console.WriteLine();

            //u = 8;
            //do
            //{
            //    Console.WriteLine("{0}", ax[u]);
            //    u++;
            //} while (u < 5);

            //uint i = 20;
            //for (; ; )
            //{
            //    Console.Write(i + " ");
            //    if (i >= 1)
            //        i -= 3;
            //    else
            //        break;
            //}

            int[][] jx = new int[4][];
            jx[0] = new int[3] {1, 2, 3};
            jx[1] = new int[2] {4, 5};
            jx[2] = new int[5] {6, 7, 8, 9, 0};
            jx[3] = new int[1] {10};

            byte r = 0, c;
            while (r < jx.Length)
            {
                c = 0;
                while (c < jx[r].Length)
                {
                    Console.Write("{0} ", jx[r][c]);
                    c++;
                }
                Console.WriteLine();
                r++;
            }
        }
    }
}






































/*
//double[] array2 = new double[3] {12.3, 33.78, 51.6};

            int[] ax = new int[5] {98, -87, 123, 42, 89};

            //byte u = 0;
            //while (u < ax.Length)
            //{
            //    Console.WriteLine("{0}", ax[u]);
            //    u++;
            //}

            int[,] bx = new int[3, 4] {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}};

            byte r=0, c;
            while (r < 3)
            {
                c = 0;
                while (c < 4)
                {
                    Console.Write("{0} ", bx[r,c]);
                    c++;
                }
                r++;
                Console.WriteLine();
            }

            //int[,,,,] cx = new int[1,2,3,7,1];

            //foreach (int v in bx)
            //{
            //    Console.WriteLine("{0}",v);
            //}

            //ax[0] = 98;
            //ax[1] = -87;
            //ax[2] = 123;
            //ax[3] = 42;
            //ax[4] = 89;

            //byte u;
            //for (u = 0; u < ax.Length; u++)
            //{
            //    Console.WriteLine("{0}", ax[u]);
            //}

            //foreach (int v in ax)
            //{
            //    Console.WriteLine("{0}",v);
            //}

            //foreach (double v in array2)
            //{
            //    Console.WriteLine("{0}",v+5);
            //}

            //u = 3;

            //do
            //{
            //    Console.WriteLine("{0}", ax[u]);
            //    u++;
            //} while (u < ax.Length);
*/