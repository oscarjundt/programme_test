using System;
using System.Collections.Generic;
class m{
    static void Main(){
        List<char> le = new List<char> ();
        string a = Console.ReadLine();
        affichage(a,le);
    }
    public static void affichage(string x, List<char> y){
        for(int i=0;i<x.Length;i++){
            y.Add(x[i]);
        }
        for(int n=0;n<x.Length;n++){
            Console.WriteLine(y[n]);
        }
    }
}