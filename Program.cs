using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 78, 34, 8, 1, 2, 4, 9, 67, 45, 23 };
            int[] arr2 = new int[10] { 10, 20, 30, 40, 50, 0, 0, 0, 0, 0 };


            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }


            // C# provides built in class called Array

            Array.Sort(arr1);
            Array.Sort(arr1, 2, 6);
            Array.Reverse(arr1);
            Array.Clear(arr1, 4, 3);
            Array.Copy(arr1, arr2, 5);
            Array.Copy(arr1, 2, arr2, 5, 5);

            //Console.WriteLine("Arr2");

            foreach (int item in arr2)
            {

                Console.WriteLine(item);
            }

            


            /* StringBuilder class
            Stringbuilder class is a mutable */



            StringBuilder stringBuilder = new StringBuilder("Think Quotient");
            stringBuilder.Append("Welcome all");
            float salary = 45000.45F;
            stringBuilder.AppendFormat("Current Salary is {0:C}", salary);

            // stringBuilder.Clear();

            stringBuilder.Remove(10, 4);
            stringBuilder.Replace('T', 't');
            stringBuilder.Replace("all", "everyone");
            Console.WriteLine(stringBuilder);





        }

    }

}
