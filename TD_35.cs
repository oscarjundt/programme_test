using System;
class vo{
    static void Main(){
        int[] tab = new int[10];
        Random hel = new Random();
        int a=int.Parse(Console.ReadLine());
        affichage(tab,hel,a);
    }
    public static void affichage(int[] x,Random xx,int xy){
        int rose=0;
        for(int i=0;i<x.Length;i++){
            x[i]=xx.Next(10);
        }
        for(int n=0;n<x.Length;n++){
            if(x[n]==xy){
                rose=rose+1;
            }
        }
        Console.WriteLine(rose);
    }
}