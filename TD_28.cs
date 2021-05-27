using System;
class ver{
    static void Main(){
        string verbe = Console.ReadLine();
        affichage(verbe);
    }
    public static void affichage(string a){
        string b="";
        for(int i=0;i<a.Length;i++){
            if(a[i]!='e' && a[i]!='r'){
                b=b+a[i];
            }
        }
        Console.WriteLine(b);
    }
}