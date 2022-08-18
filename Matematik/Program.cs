using System;
using System.Linq;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5,9);
            Console.WriteLine(Add(5,10));
            int number = 35;
            Console.WriteLine(Add2(ref number));

            //number referans tipe dönüşte number metotda artık güncelleniyor.
            //ref yerine out kullanabilirsin tek farkı out ta değeri baştan tanımlamazsan sonradan tanımlarsın ama kullanmadan önce değer tekrar da olsa tanımlaman lazım.
            Console.WriteLine(number);

            Console.WriteLine(add3(4,5,6,7,8,9,1,0,10));
        }

        static int Add(int number1, int number2)
        {
            return number1 + number2;

        }
        //overload
        static int Add(int number1, int number2,int number3)
        {
            return number1 + number2+number3;
        }
        //params son eleman olmak zorunda başında int değer olabilir.
        static int add3(params int[] numbers)
        {
            return numbers.Sum();
        }
        static int Add2(ref int number, int number2 = 30)
        {
            number = 30;
            return number + number2;
        }
    }
}
