using System;

namespace CSharpMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //double result=Sum(10, 20);
            //Console.WriteLine(result);
            //FullName("Ferrux", "Eliyev",19); //"Ferrux", "Eliyev",19 - arguments
            //int[] numbers = { 10,20,-100 };
            //Console.WriteLine(SumArr(10));
            //Console.WriteLine(Sum(10,20));
            //Sum(n3: 10,n1:20);
            //int num = 5;
            //Sum(num);
            //FullName("Kamran",31);
            //Print("asfad");
            Console.WriteLine(SumNumber(3));
        }

        //recursive funktion
        static int SumNumber(int n)
        {
            if (n == 1)
                return n;
            return n + SumNumber(n - 1);
        }

        static void Print(string str)
        {
            Console.WriteLine("simple method");
        }

        static void Print(params string[] words)
        {
            Console.WriteLine("params method");
        }

        static void Print(string s1, string s2 = "test")
        {
            Console.WriteLine("default value method");
        }

        

        //method signature - method's name, patametrs count, parametr's type
        //method overloading - static polymorphism
        static void FullName(string name, string surname, int age) //age,name,surname - parametrs
        {
            #region Return
            //Console.WriteLine(name+" "+surname);
            //Console.WriteLine("{0} {1}",name,surname);

            //if (age > 18)
            //{
            //    Console.WriteLine($"{name} {surname}");
            //    return;
            //}
            //Console.WriteLine($"{name} {surname} yashiniz chatmir");
            #endregion

            Console.WriteLine($"{name} {surname} {age}");
        }

        static void FullName(string name,int age)
        {
            Console.WriteLine($"{name} {age}");
        }

        static void FullName(string name, string surname)
        {
            Console.WriteLine($"{name} {surname}");
        }

        static int SumArr(params int[] arr)
        {
            int result = 0;
            foreach (int number in arr)
            {
                result += number;
            }
            return result;
        }

        static double Sum(double n1=1,double n2=10)
        {
            return n1 + n2;
        }

        static double Sum(double n1,double n2,double n3)
        {
            return Sum(n1,n2) + n3;
        }
    }
}
