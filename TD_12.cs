using System;
class bou{
    static void Main(){
        Console.Write("donner nombre de fin: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("donner nombre de debut: ");
        int b = int.Parse(Console.ReadLine());
        affichage(a,b);
    }
    public static void affichage(int x, int y){
        while(y<x){
            Console.WriteLine(y);
            y++;
        }
    }
}