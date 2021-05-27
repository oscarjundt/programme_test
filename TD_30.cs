using System;
class test{
    static void Main(){
        int [] test = new int [20];
        Console.Write("donner table: ");
        int b = int.Parse(Console.ReadLine());
        for(int i=0;i<test.Length;i++){
            test[i]=i*b;
        }
        Console.Write("donner nombre: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(b+" * "+a+" = "+test[a]);
    }
}