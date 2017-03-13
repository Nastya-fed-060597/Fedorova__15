using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGame
{
    class Game
    {
        public readonly int[,] field;

        public Game(params int [] gets)
        {
            
            if (canwedo(gets)) 
            {
                
                int temp = 0;
                field = new int[Convert.ToInt32(Math.Sqrt(gets.Length)), Convert.ToInt32(Math.Sqrt(gets.Length))];
                for (int i = 0; i < Math.Sqrt(gets.Length); i++)
                {
                    for (int j = 0; j < Math.Sqrt(gets.Length); j++)
                    {
                        field[i, j] = gets[temp];
                        temp++;
                    }
                }
                
            }
      
        }
      
       
        public bool Shift(int val) 
        {
            int i1 = 0;
            int j1 = 0;
            int i2 = 0;
            int j2 = 0;
            for (int i = 0; i < Math.Sqrt(field.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(field.Length); j++)
                {
                    if (field[i, j] == 0)
                    {
                        i1 = i;
                        j1 = j;
                    }
                    if (field[i, j] == val)
                    {
                        i2 = i;
                        j2 = j;
                    }
                }
            }
            if ((Math.Abs(i2-i1)+Math.Abs(j2-j1))==1) 
            {
                field[i1, j1] = val;
                field[i2, j2] = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool WIN() 
        {
            bool status = true;
            int[] temper = new int[field.Length];
            int temp = 0;
            foreach (var item in field)
            {
                temper[temp] = item;
                temp++;
            }
            for (int i = 0; i < temper.Length-1; i++)
            {
                if ((i!=temper.Length-2)&&(temper[i]>temper[i+1]))
                {
                    status = false;
                }
                if (temper[temper.Length-1]!=0)
                {
                    status = false;
                }
            }
            return status;
        }

        private bool canwedo(int[] gets)
        {
            bool ret=true;
            int gameline =(int) Math.Sqrt(gets.Length);
            if (gameline%1==0)
            {
                int zerocount = 0;
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 1; j < gets.Length; j++)
                    {
                        if (gets[i]==gets[j])
                        {
                            ret = false;
                        }
                    }
                }
                foreach (var item in gets)
                {
                    if (item==0)
                    {
                        zerocount++;
                    }
                }
                if (zerocount>1||zerocount==0)
                {
                    ret = false;
                }
            }
            else
            {
                ret = false;
            }
            return ret;
        }

    }
}
