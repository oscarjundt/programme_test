using System;
class ttc{
    static void Main(){
        Console.Write("donner prix: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("remise: ");
        float b = float.Parse(Console.ReadLine());
        float remise = 0;
        if(b==1){
            remise=15;
        }
        else if(b==2){
            remise=25;
        }
        float resultat = calcule(a,remise);
        affichage(resultat);
    }
    public static float calcule(float x,float y){
        float res = ((100-y)/(100))*x;
        return(res);
    }
    public static void affichage(float x1){
        Console.WriteLine(x1);
    }
}