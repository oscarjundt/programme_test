using System;
class cercle{
    static void Main(){
        const double pi = 3.14;
        double r;
        double p;
        r = double.Parse(Console.ReadLine());
        p = 2*pi*r;
        Console.Write("p=");
        Console.WriteLine(p);
    }
}