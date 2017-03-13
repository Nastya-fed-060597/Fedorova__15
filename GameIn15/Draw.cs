using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGame
{
    static class Draw
    {
        public static void Print(Game game)
        {
        
            for (int i = 0; i < Math.Sqrt(game.field.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(game.field.Length); j++)
                {
                   
                    Console.Write(game.field[i,j] + " ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
