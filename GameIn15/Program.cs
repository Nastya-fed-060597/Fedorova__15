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
            //пытаемся создать игру
            {
                var game = new Game(1,2,3,4,5,6,8,7,0); //создаем игру
                while (!game.WIN()) //играем пока не достигнем победы
                {
                    Draw.Print(game); //рисуем игру

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

