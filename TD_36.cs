using System;
class rose{
    static void Main(){
        int[] tab = new int[25];
        affichage(tab);
    }
    public static void affichage(int[] x){
        Random t = new Random();
        int cc=0;
        int c=0;
        int c2=x.Length-1;
        for(int i=0;i<x.Length;i++){
            x[i]=t.Next(10);
        }
        for(int n=0;n<x.Length;n++){
            c=n+1;
            c2=n-1;
            if(c!=x.Length && c2!=(-1)){
                if(x[n]>x[c] && x[n]>x[c2] && cc<x[n]){    
                    cc=x[n];
                }
            }
        }
        Console.WriteLine("le max est: "+cc);
    }
}