using System;
using System.Collections.Generic;
class et{
    static void Main(){
        List<string> langage = new List<string> ();
        Console.Write("donner nombre superieur ou egal a 8: ");
        int c=int.Parse(Console.ReadLine());
        string a="";
        string b="";
        for(int i=0;i<c+1;i++){
            b=b+" ";
            langage.Add(b);
        }
        Console.WriteLine(langage[8]+"*");
        for(int n=c;n>0;n--){
            string x=langage[n];
            a=a+"**";
            Console.WriteLine(x+a);
        }
        
    }
}