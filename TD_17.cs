using System;
using System.Collections.Generic;
class us{
    static void Main(){
        List<string> lang = new List<string> ();
        int b = int.Parse(Console.ReadLine());
        string a="";
        for(int i=0;i<b;i++){
            a=a+"*";
            lang.Add(a);
        }
        for(int m=0;m<b;m++){
            Console.WriteLine(lang[m]);
        }
    }
}