using System;
class etoile{
    static void Main(){
        Console.Write("donner hauteur: ");
        int b = int.Parse(Console.ReadLine());
        string a="";
        for (int i=0;i<b;i++){
            a=a+"*";
            Console.WriteLine(a);
        }
    }
}