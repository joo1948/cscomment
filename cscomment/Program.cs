using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscomment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("--숫자를 입력해--");
            Console.Write("x: ");
            x = int.Parse(Console.ReadLine());//입력~
            Console.Write("y: ");
            y = int.Parse(Console.ReadLine());//입력~

            if (x > 4)
            {
                if (y > 2)
                {
                    Console.WriteLine(x * y);
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
