using System;
class gagne{
    static void Main(){
        Console.Write("entrer un nombre: ");
        int entier = int.Parse(Console.ReadLine());
        res(entier);
    }
    public static void res(int x){
        if(x>=12 && x<=24){
            Console.WriteLine("vous avez gagner");
        }
        else{
            for(int i=0;i<10;i++){
                Console.WriteLine("a ta perdu");
            }
        }
    }
}