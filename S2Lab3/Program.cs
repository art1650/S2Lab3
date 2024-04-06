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

    //Chas hours = new Chas();
    //hours.setZnachenna(x);
    //Chas minutes = new Chas();
    //minutes.setZnachenna(y);
    //Chas seconds = new Chas();
    //seconds.setZnachenna(z);

    Chas Time1 = new Chas();    

    Time1.setHours(x);
    Time1.setMinutes(y);
    Time1.setSeconds(z);

    Time1.Write();

    //hours.WriteH();
    //minutes.WriteM();
    //seconds.WriteS();

    int xp, yp, zp;
    Console.Write("додати годин = ");
    xp = int.Parse(Console.ReadLine());
    Console.Write("додати хвилин = ");
    yp = int.Parse(Console.ReadLine());
    Console.Write("додати секунд = ");
    zp = int.Parse(Console.ReadLine());

    Time1.AddTimeH(xp);
    Time1.AddTimeM(yp);
    Time1.AddTimeS(zp);

    Time1.Write();

    //hours.AddTime(xp);
    //minutes.AddTime(yp);
    //seconds.AddTime(zp);

    //hours.WriteH();
    //minutes.WriteM();
    //seconds.WriteS();

   Console.WriteLine(Chas.ToJSON(Time1.getHours(), Time1.getMinutes(), Time1.getSeconds()));
   Console.WriteLine(Chas.FromJSON(Chas.ToJSON(Time1.getHours(), Time1.getMinutes(), Time1.getSeconds())));

   
}
catch
{
    Console.WriteLine(" syntax error");
}


