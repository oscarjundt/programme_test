using System;
class mn{
    static void Main(){
        bool cd=true;
        while(cd){
            Console.Write("ecrire mot: ");
            string a = Console.ReadLine();
            if(a=="rien"){
                cd=false;
            }
            else{
                int c=a.Length-1;
                int lg=fonction(a,c);
                affichage2(lg);
            }
        }
        
    }
    public static void affichage2(int x){
        if(x==-1){
            Console.WriteLine("palindrome");
        }
        else{
            Console.WriteLine("pas palindrome");
        }
    }
    public static int fonction(string x, int y){
        for(int i=0;i<x.Length;i++){
            if(x[i]==x[y]){
                y--;
            }
        }
        return y;
    }
}