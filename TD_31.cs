using System;
class tt{
    static void Main(){
        int [] hello = new int[11];
        int rep = int.Parse(Console.ReadLine());
        int a=1;
        affichage(hello,a, rep);
        int rp = int.Parse(Console.ReadLine());
        affichage2(hello,rp);
       
    }
    public static void affichage(int [] hello, int x, int xx){
        for(int i=0;i<10;i++){
            hello[i]=x*xx;
            x=x+1;
        }
    }
    public static void affichage2(int [] hello, int xy){
        Console.WriteLine("le nombre demander est: "+hello[xy]);
    }
}