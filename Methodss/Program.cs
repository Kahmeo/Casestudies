using System;
using System.Linq;

namespace Methodss
{
    class Program
    {
        static void Main(string[] args)
        {
           // Add();
            //
            var result1 = Add2(20, 30);
            //Console.WriteLine(result1);
            //
            var result2 = Add3(10,50);
           // Console.WriteLine(result2);
            //
            int number1;
            int number2 = 100;
            var result3 = Add4(out number1, number2);
            //Console.WriteLine(result3);
            //Console.WriteLine(number1);
            //
            Console.WriteLine(Multiply(1,2));
            Console.WriteLine(Multiply(1,2,3));
            //
            Console.WriteLine(Add5(1,2,3,4,5,6,7,8,9));
            


            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!!!");
        }

        //Parametreli metot
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        //Default methodlar her zaman metotun en sonunda olmak zorunda
        static int Add3(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        //ref keywordu - out keyword
        static int Add4(out int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //method overloading
        static int Multiply(int number1,int number2)
        {
            return number1 + number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 + number2+number3;
        }

        //Params Keyword
        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }


    }
}
