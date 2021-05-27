using System;
using System.Collections.Generic;
class TD{
    static void Main(){
        List<int> lang=new List<int> ();
        int d=0;
        int i=0;
        int var=0;
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        oscar(min,max,d,i,var,lang);
       
    }
    public static void oscar(int x, int y, int z, int a, int b,List<int> l){
        for(a=x;a<y+1;a++){
            int n=0;
            for(int m=1;m<=a;m++){
                z=a%m;
                if(z==0){
                    n=n+1;
                }
            }
            if(n>2){
                Console.WriteLine("");
            }
            else{
                l.Add(a);
                b=b+1;

            }
        }
        for(int mm=0;mm<b;mm++){
            Console.WriteLine(l[mm]);
        } 
        
    }
}