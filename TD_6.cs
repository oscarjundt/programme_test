using System;
class coef{
    static void Main(){
        Boolean b=true;
        while(b){
            float a = float.Parse(Console.ReadLine());
            if(a==0){
                b=false;
            }
            else{
                affichage(a);
            }
            
        }
    }
    public static void affichage(float x){
        if(x>=10 && x<=12){
            Console.WriteLine("votre mention pour "+x+" est passable");
        }
        else if(x>=12 && x<14){
            Console.WriteLine("votre mention pour "+x+" est assez bien");
        }
        else if(x>=14 && x<16){
            Console.WriteLine("votre mention pour "+x+" est bien");
        }
        else if(x>16){
            Console.WriteLine("votre mention pour "+x+" est tres bien");
        }
    }
}