using System;

namespace Test
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("This is a .NET test code.");

            MyInfo.Info data = new MyInfo.Info();

            data.INFO();

        }
    }
}
namespace MyInfo
{
    class Info
    {
       public void INFO()
        {
            Console.WriteLine("My name is Anzamul Haque Akash and I'm 24.");
        }
    }
}
