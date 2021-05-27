using System;
class bouc{
    static void Main(){
        Console.Write("entrer nombre de debut: ");
        int a=int.Parse(Console.ReadLine());
        Console.Write("entrer nombre de fin: ");
        int b=int.Parse(Console.ReadLine());
        afficher(a,b);
    }
    public static void afficher(int x,int y){
        for(int i=x;i<y;i++){
            Console.WriteLine(i);
        }
    }
}