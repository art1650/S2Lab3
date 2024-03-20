using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace S2Lab3
{
    public class Chas
    {
        private int Znachenna;

        public void AddTime(int time)
        {
            try
            {
                if (time < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Znachenna += time;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Time can't be negative");
            }
        }

        public static string ToJSON(int ho, int min, int sec)
        {
            string s1 = JsonSerializer.Serialize($"{ho}:{min}:{sec}");
            return s1;
        }

        public static string FromJSON (string s1)
        {
            string s2 = JsonSerializer.Deserialize<string>(s1);
            return s2;
        }

        public void setZnachenna (int i)
        {
            try
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Znachenna = i;
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Time can't be negative");
            }
        }

        public int getZnachenna()
        {
            return Znachenna;
        }


        public void WriteH()
        {
            Console.WriteLine($"години {Znachenna}");
        }
        public void WriteM()
        {
            Console.WriteLine($"хвилини {Znachenna}");
        }
        public void WriteS()
        {
            Console.WriteLine($"секунди {Znachenna}");
        }
    }
}
