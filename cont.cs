using System;
class rose{
    static void Main(){
        Console.Write("donner mot: ");
        string mot = Console.ReadLine();
        bool fonc = osc(mot);
        Console.WriteLine(fonc);
    }
    public static bool osc(string x){
        int ch=x.Length-1;
        int ch2=x.Length-2;
        if(x[ch]=='r' && x[ch2]=='e' && x!="aller"){
            return true;
        }
        else{
            return false;
        }
    }
}