using System;
class impot{
    static void Main(){
        int a = int.Parse(Console.ReadLine());
        string b = Console.ReadLine();
        afficher(a,b);
    }
    public static void afficher(int x, string y){
        if((x>20 && y=="homme")||(x>=18 && x<35 && y=="femme")){
            Console.WriteLine("tu paix");
        }
        else{
            Console.WriteLine("tu paix pas");
        }
    }
}