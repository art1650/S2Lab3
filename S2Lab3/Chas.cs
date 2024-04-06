using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace S2Lab3
{
    public class Chas
    {
        //private int Znachenna;
        private int Hours;
        private int Minutes;
        private int Seconds;

        //public void AddTime(int time)
        //{
        //    try
        //    {
        //        if (time < 0)
        //        {
        //            throw new ArgumentOutOfRangeException();
        //        }
        //        Znachenna += time;
        //    }
        //    catch (ArgumentOutOfRangeException e)
        //    {
        //        Console.WriteLine("Time can't be negative");
        //    }
        //}

        public static string ToJSON(int h, int m, int s)
        {
            string s1 = JsonSerializer.Serialize($"{h} : {m} : {s}");
            return s1;
        }

        public static string FromJSON (string s1)
        {
            string s2 = JsonSerializer.Deserialize<string>(s1);
            return s2;
        }

        //public void setZnachenna (int i)
        //{
        //    try
        //    {
        //        if (i < 0)
        //        {
        //            throw new ArgumentOutOfRangeException();
        //        }
        //        Znachenna = i;
        //    }
        //    catch(ArgumentOutOfRangeException e)
        //    {
        //        Console.WriteLine("Time can't be negative");
        //    }
        //}

        public void setHours(int i)
        {
            try
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Hours = i;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Time can't be negative");
            }
        }

        public void setMinutes(int i)
        {
            try
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Minutes = i;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Time can't be negative");
            }
        }

        public void setSeconds(int i )
        {
            try
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Seconds = i;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Time can't be negative");
            }
        }

        public void Write()
        {
            Console.WriteLine($" {Hours} : {Minutes} : {Seconds}");
        }

        public void AddTimeH(int x)
        {
            try
            {
                if (x < 0 || x > 24 - Hours)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Hours += x;
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Hours can't be negative or more than 24");
            }
        }

        public void AddTimeM(int y)
        {
            try
            {
                if (y < 0 || y > 60 - Minutes)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Minutes += y;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Minutes can't be negative or more than 60");
            }
        }

        public void AddTimeS(int z)
        {
            try
            {
                if (z < 0 || z > 60 - Seconds)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Seconds += z;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Seconds can't be negative or more than 60");
            }
        }

        public int getHours()
        {
            return Hours;
        }

        public int getMinutes()
        {
            return Minutes;
        }

        public int getSeconds()
        {
            return Seconds;
        }



        //public void WriteH()
        //{
        //    Console.WriteLine($"години {Znachenna}");
        //}
        //public void WriteM()
        //{
        //    Console.WriteLine($"хвилини {Znachenna}");
        //}
        //public void WriteS()
        //{
        //    Console.WriteLine($"секунди {Znachenna}");
        //}
    }
}
