using System;
class etoile2{
    static void Main(){
        //declaration du variable aleatoire
        Random aleatoire = new Random();
        //declarartion et definiton de la variable b
        int b = aleatoire.Next(0,100);
        //declaration et definition d'un varaible boolean
        Boolean c = true;
        while(c){
            Console.Write("a quel nombre je pence: ");
            //declaration et definition de la variable a
            int a = int.Parse(Console.ReadLine());
            //appelle de la procedure affichage
            affichage(a,b, ref c);
        }
    }
    public static void affichage(int x,int y,ref Boolean c1){
        if(x>y){
            string res="x_grand";
            int res0 = oscar(res,x,y);
            Console.WriteLine("reponse trop grande de "+res0);
        }
        else if(x<y){
            string res="x_petit";
            int res1 = oscar(res,x,y);
            Console.WriteLine("reponse trop petite de "+res1);
        }
        else{
            Console.WriteLine("bon nombre");
            c1 = false;
        }
    }
    /*
    defintion de la fonction oscar
    parametre : 
    xy : resultat de la procédure d'affichage
    x2 : nombre donner par l'utilisateur
    y2 : nombre random
    return : 
    la variable c
    */
    public static int oscar(string xy, int x2, int y2){
        if(xy=="x_grand"){
            int c = x2-y2;
            return(c);
        }
        else if(xy=="x_petit"){
            int c = y2-x2;
            return(c);
        }
        else{
            int c=0;
            return(c);
        }
    }
}