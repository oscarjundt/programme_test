using System;
class chai{
    static void Main(){
        string a = Console.ReadLine();
        string c = Console.ReadLine();
        affichage(a,c);
    }
    public static void affichage(string x, string y){
        int res = x.Length;
        int res2 = y.Length;
        if(res>res2){
            Console.WriteLine("c'est "+x+" qui gagne");
        }
        else if(res<res2){
            Console.WriteLine("c'est "+y+" qui gange");
        }
        else{
            Console.WriteLine("rien");
        }
    }
}