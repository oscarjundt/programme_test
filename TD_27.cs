using System;
class verif{
    static void Main(){
        string verbe = Console.ReadLine();
        affichage(verbe);
    }
    public static void affichage(string a){
        int ch=a.Length-1;
        if(a[ch-1]=='e' && a[ch]=='r' && a!="aller"){
            Console.WriteLine(true);
        }
        else{
            Console.WriteLine(false);
        }
    }
}