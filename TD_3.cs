//ce programme cerre a calculer perimetre
using System;
class cercle{
    static void Main(){
        //initialistation de pi
        const double pi = 3.14;
        //declaration de r
        double r;
        //initialisation de r
        r = double.Parse(Console.ReadLine());
        //on met l'appelle de la fonction dans une variable
        double resultat = calcule(r,pi);
        //on appelle de la procedure
        affichage(resultat);
    }
    //definition de la procedure
    public static void affichage(double m){
        //affichage du reslutat
        Console.Write("p=");
        Console.WriteLine(m);
    }
    //definition de la fonction
    public static double calcule(double x, double y){
        //calcule et declaration
        double p = 2*y*x;
        return p;
    }
}