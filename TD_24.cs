using System;
class mn{
    static void Main(){
        string a = Console.ReadLine();
        int d=0;
        for(int i=0;i<a.Length;i++){
            if(a[i]=='e'){
                d=d+1;
            } 
        } 
        Console.WriteLine(d);
    }
}