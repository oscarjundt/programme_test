using System;
class ti{
    static void Main(){
        string mot = Console.ReadLine();
        affichage(mot);
    }
    public static void affichage(string a){
        string b="";
        int ch=a.Length-1;
        for(int i=1;i<a.Length-1;i++){
            b=b+"-";
        }
        Console.WriteLine(a[0]+b+a[ch]);
    }
}