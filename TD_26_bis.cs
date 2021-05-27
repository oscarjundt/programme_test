using System;
using System.Collections.Generic;
class m{
    static void Main(){
        List<char> lang = new List<char> ();
        string a=Console.ReadLine();
        int mn=a.Length;
        int n=0;
        for(int i=0;i<a.Length;i++){
            mn--;
            lang.Add(a[mn]);
        }
        for(int m=0;m<a.Length;m++){
            if(lang[m]==a[m]){
                n=n+1;
            }
        }
        if(n==a.Length){
            Console.WriteLine("ok");
        }
        else{
            Console.WriteLine("pas ok");
        }
    }
}