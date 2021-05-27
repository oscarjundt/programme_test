using System;
using System.Collections.Generic;
class coucle{
    static void Main(){
        int min=0;
        for(int i=0;i<5;i++){
            int res = int.Parse(Console.ReadLine());
            if(i==0 || min>res){
                min=res;

            }
        }
        Console.WriteLine(min);
    }
}