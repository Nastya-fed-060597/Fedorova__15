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
        
       static public string [] read (string path)
        {
            return File.ReadAllText(path).Split(',');
            
            
           
        }
    }
}
