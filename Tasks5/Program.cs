using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks5ClassLibrary2;

namespace Tasks5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1 - deklariranje tipovi, task 2, task 3
            //bool VistinIliNe=default(bool);
            //char Bukva = default(char);
            //string Name = default(string);
            //float dec1 = default(float);
            //double dec2 = default(double);
            //decimal dec3 = default(decimal);
            //int int1 = default(int);
            //long long1 = default(long);
            //short short1 = default(short);
            //Console.WriteLine(short1);
            //bool? VistinIliNe1;
            //char? Bukva1;
            //string Name1=null;
            //float? dec11;
            //double? dec21;
            //decimal? dec31;
            //int int11;
            //long? long11;
            //short? short11;
            //bool? aBool;
            #endregion
            #region task 4 -conversion types
            int number = 23;
            double aDouble = 3.54;
            string aNumber = number.ToString();
            string bNumber = aDouble.ToString();
            Console.WriteLine("The result from conversion is {0}", aNumber);
            Console.WriteLine("The result from conversion is {0}", bNumber);
            #endregion
            #region task 5
            string str1 = "234324";
            int StrToInt;
            int.TryParse(str1, out StrToInt);
            if (StrToInt==0)
            {
                Console.WriteLine("Please enter INTEGER"); 
            }
            else
            {
                Console.WriteLine("The result from conversion is: {0}", StrToInt);
            }
            #endregion
            #region task 6
            var temp="temp";
            for (var i = 1; i <=10; i++)
            {
                Console.WriteLine(temp);
            }
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region task 7
            string[] array = new string[3];
            array[0] = "Ilche";
            array[1] = "Dejan";
            array[2] = "Mitko";
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
            int[] array1 = new int[3];
            array1[0] = 5;
            array1[1] = 15;
            array1[2] = 10;
            Array.Sort(array1);
            foreach (var item in array1)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion
            #region task 8
            Console.WriteLine("The number of elements of the first array is: " +array.Count());
            Console.WriteLine("The number of elements of the second array is: " + array1.Count());

            Console.WriteLine("The First element of the second array is: " + array1.First());
            Console.WriteLine("The First element of the first array is: " + array.First());
            Console.WriteLine("The Last element of the second array is: " + array1.Last());
            Console.WriteLine("The Last element of the first array is: " + array.Last());

            Console.WriteLine("The Min element of the second array is: " + array1.Min());
            Console.WriteLine("The Min element of the first array is: " + array.Min());
            Console.WriteLine("The Max element of the second array is: " + array1.Max());
            Console.WriteLine("The Max element of the first array is: " + array.Max());
            Console.WriteLine("The Sum of the elements of the second array is: " + array1.Sum());
            //Console.WriteLine("The Sum of the elements of the first array is: " + array.Sum()); Не можиме да сумираме стринг
            #endregion
            #region task 9
            Person Ilche = new Person()
            {
                FirstName = "Ilche",
                LastName = "Ivanovski"
            };
            Console.WriteLine(Ilche.FirstName+" "+Ilche.LastName);
            #endregion
            #region task 10
            Person[] Akteri = new Person[]
            {
                new Person(){ FirstName = "Sylvester", LastName="Stalone" },
                new Person(){ FirstName = "Jason", LastName="Statham" },
                new Person(){ FirstName = "Paul", LastName="Walker" },
            };
            foreach (Person item in Akteri)
            {
                Console.WriteLine("The actor name is: "+item.FirstName+" " +item.LastName);
            }
            #endregion
        }
    }
}
