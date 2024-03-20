using S2Lab3;
using System.Text.Json;

try 
{
    int x;
    Console.Write("hours = ");
    x = int.Parse(Console.ReadLine());
    int y;
    Console.Write("minutes = ");
    y = int.Parse(Console.ReadLine());
    int z;
    Console.Write("seconds = ");
    z = int.Parse(Console.ReadLine());

    Chas hours = new Chas();
    hours.setZnachenna(x);
    Chas minutes = new Chas();
    minutes.setZnachenna(y);
    Chas seconds = new Chas();
    seconds.setZnachenna (z); 

    hours.WriteH();
    minutes.WriteM();
    seconds.WriteS();

    int xp, yp, zp;
    Console.Write("додати годин = ");
    xp = int.Parse(Console.ReadLine());
    Console.Write("додати хвилин = ");
    yp = int.Parse(Console.ReadLine());
    Console.Write("додати секунд = ");
    zp = int.Parse(Console.ReadLine());

    hours.AddTime(xp);
    minutes.AddTime(yp);
    seconds.AddTime(zp);

    hours.WriteH();
    minutes.WriteM();
    seconds.WriteS();

   Console.WriteLine(Chas.ToJSON(hours.getZnachenna(), minutes.getZnachenna(), seconds.getZnachenna()));
   Console.WriteLine(Chas.FromJSON(Chas.ToJSON(hours.getZnachenna(), minutes.getZnachenna(), seconds.getZnachenna())));

   
}
catch
{
    Console.WriteLine(" syntax error");
}


