using System;
class testages{
    static void Main(){
        int ages = int.Parse(Console.ReadLine());
        test(ages);
    }
    public static void test(int x){
        if(x>=0 && x<=130){
            if(x>=18){
                Console.WriteLine("tu est majeur");
            }
            else{
                Console.WriteLine("tu est mineurs");
            }
        }
        else{
            Console.WriteLine("erreur. ages impossible");
        }
    }
}