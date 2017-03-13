using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlayGame
{
    class Program
    {
        static void Main(string[] args)
        {
   
            {
                var game = new Game(1,2,3,4,5,6,8,7,0); 
                while (!game.WIN())
                {
                    Draw.Print(game);

                    Console.WriteLine("ВВедите число которое хотите передвинуть");
                    int choise = Convert.ToInt32(Console.ReadLine());
                    while (!game.Shift(choise))
                    {
                        Console.WriteLine("Введите другое число");
                        choise = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Draw.Print(game);



                Console.Read();
            }
        }
    }
}

