using System;
using System.Collections.Generic;
class hello{
    static void Main(){
        int d=0;
        int b=0;
        int a = int.Parse(Console.ReadLine());
        bool c=oscar(d,b,a);
        Console.WriteLine(c);
        
       
    }
    public static bool oscar(int x,int y,int z){
        for(int i=1;i<z+1;i++){
            y=z%i;
            if(y==0){
                x=x+1;
            }
        }
        if(x>2){
            return false;
        }
        else{
            return true;
        }
    }
}