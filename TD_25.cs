using System;
class mnop{
    static void Main(){
        string a = Console.ReadLine();
        string b = "";
        affichage(a,b);
    }
    public static void affichage(string x,string y){
        for(int i=0;i<x.Length;i++){
            if(x[i]!='c'){
                y=y+x[i];
            }
        }
        Console.WriteLine(y);
    }
}