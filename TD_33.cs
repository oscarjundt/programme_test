using System;
class td{
    static void Main(){
        //declaration du tableau
        int[] tab = new int[10];
        //appelle de la fonction d'affichage
        affichage(tab);
        //declaration de la variable qui appelle la fonction
        int cf=osc(tab);
        affichage2(cf);
    }
    public static void affichage2(int x5){
        Console.WriteLine(x5);
    }
    public static void affichage(int[] x){
        //declaration de la variable randome
        Random aleatoire = new Random();
        for(int i=0;i<x.Length;i++){
            int a = aleatoire.Next(25);
            x[i]=a;
        }
    }
    /*
    fonction osc
    osc : int : fonc
    parametre : 
    x2 : tableau
    retourn : 
    retourn la moyenne du tableau
    */
    public static int osc(int[] x2){
        int a4=0;
        int rose=x2.Length;
        for(int i2=0;i2<x2.Length;i2++){
            a4=a4+x2[i2];
        }
        return a4/rose;
    }
}