using System;
using System.Threading;
using System.Text;

namespace LazyClass
{
    class Program
    {
        static void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine($"{x * i}");
            }
            Console.WriteLine("__________");

        }
        static void MyTime(object obj)
        {
            Console.WriteLine("Privet mir");
        }
        static void Main(string[] args)
        {
            int num = 0;
            TimerCallback timerCallback = MyTime;//metod obratnogo vizova
            Timer timer = new Timer(timerCallback, null, 2000, 1000);
            Console.ReadLine();
        }
    }
}