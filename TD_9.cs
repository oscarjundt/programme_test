using System;
class sport{
    static void Main(){
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();
        int res=0;
        string de = a+b+c;
        Boolean abc = true;
        while(abc){
            res=res+1;
            if(res==int.Parse(de)){
                Console.WriteLine(a+" et "+b+" et "+c+" = "+res);
                abc =false;
            }
        }
    }  
}