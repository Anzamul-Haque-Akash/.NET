using System;
using System.Collections.Generic;

namespace Temp
{
    class Program
    {
        enum PlayerState
        {
            Idle,
            Jump
        }
        static PlayerState playerState;

        static void Main(string[] args)
        {
            Console.WriteLine("This is the Code where you find all the basic of C# programming language.");
            int a = 2297;
            float b = 2.1345f;
            double c = 2.345349593345;
            char ch = 'A';
            string name = "Anzamul Haque Akash";
            bool d = true;
            Console.WriteLine("My name is {0} \n{1}\n{2}\n{3}\n{4}", name,a,b,c,ch);

            if (d)
            {
                Console.WriteLine("True.");
            }

            int[] intArray = new int[] {1, 2, 3, 4, 5};
            foreach(int i in intArray)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            List<int> intList = new List<int>() {2297, 2, 3, 1};
            intList.Add(5);
            intList.Remove(1);
            for(int i=0; i<intList.Count; i++){
                Console.Write(intList[i] + " ");
                if(i == intList.Count - 1)
                {
                    Console.WriteLine();
                }
            }

            int x = 0;
            while(x < 5)
            {
                Console.WriteLine("Anzamul Haque Akash in while loop.");
                x++;
            }

            int y = 0;
            do
            {
                Console.WriteLine("Anzamul Haque Akash in do while loop.");
                y++;
            } while (y < 5);

            switch (playerState)
            {
                case PlayerState.Idle:
                    Console.WriteLine("Idle is True.");
                    break;
                case PlayerState.Jump:
                    Console.WriteLine("Jump is True.");
                    break;
                default:
                    Console.WriteLine("Idle and Jump both are False.");
                    break;
            }

            MyInfo myInfo = new MyInfo(); 
            MyInfo.INFO();

            int X = Int32.Parse(Console.ReadLine());
            Console.WriteLine(X);

            Console.ReadKey();
        }
    }

    class MyInfo
    {
        public static void INFO()
        {
            Console.WriteLine("Anzamul Haque Akash, I'm 24.");
        }
        private static void PRIVATE()
        {
            Console.WriteLine("Daffodil International University");
        }
    }
}
