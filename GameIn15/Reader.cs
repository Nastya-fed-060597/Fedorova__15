using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlayGame
{
 static   class Reader //класс для считывания значений из файла
    {
        
       static public int [] read (string path)
        {
            var stringgets = File.ReadAllText(path).Split(',');
            var gets = new int[stringgets.Length];
            for (int i = 0; i < gets.Length; i++)
            {
                gets[i] = Convert.ToInt32(stringgets[i]); //преобразуем элементы массива строк в интовские цифры
            }
            return gets;
        }
    }
}
