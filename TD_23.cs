using System;
class her{
    static void Main(){
        string a=Console.ReadLine();
        string b=Console.ReadLine();
        affichage(a,b);
    }
    public static void affichage(string x,string y){
        if(x.Length>y.Length){
            Console.WriteLine("plus grand et: "+x);
        }
        else if(x.Length<y.Length){
            Console.WriteLine("plus grand et: "+y);
        }
        else{
            Console.WriteLine("egale");
        }
    }
}