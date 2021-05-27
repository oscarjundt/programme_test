using System;
class bo{
    static void Main(){
        //déclaration du tableau
        int[] tab = new int[5];
        //appelle de la procédure d'affichage
        affichage(tab);
    }
    public static void affichage(int[] x){
        //déclaration et initialisation des différente variable
        int c1=0;
        int c2=0;
        for(int i=0;i<x.Length;i++){
            //déclaration est initialisation de la variable a
            int a = int.Parse(Console.ReadLine());
            x[i]=a;
        }
        for(int n=0;n<x.Length-1;n++){
            //calcule de c1
            c1=n+1;
            //si c1 est différent du nombre de chiffre dans le tableaux
            if(c1!=x.Length){
                //si le chiffre d'avant et suppérieur au chiffre d'après
                if(x[n]<x[c1]){
                    //alors il incrémente
                    c2=c2+1;  
                }

            }
        }
        //si la variable c2 et supérieur a 0
        if(c2==x.Length-1){
            //alors il affiche vrais
            Console.WriteLine(true);
            Console.WriteLine(c2);
        }
        else{
            //sinon il affiche faux
            Console.WriteLine(false);
            Console.WriteLine(c2);
        }
        
    }
}