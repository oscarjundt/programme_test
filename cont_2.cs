using System;
class rose{
    static void Main(){
        string mot = Console.ReadLine();
        string a="";
        affichage(mot,ref a);
    }
    public static void affichage(string x, ref string xx){
        for(int i=0;i<x.Length;i++){
            if(i<x.Length-2){
                xx=xx+x[i];
            }
        }
            Console.WriteLine(xx);
    }

}