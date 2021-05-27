using System;
class tableaux{
    static void Main(){
        int[,] tab = new int [3,3];
        for(int i=0;i<tab.GetLength(0);i++){
            for(int i2=0;i2<tab.GetLength(1);i2++){
                tab[i,i2]=i2;
            }
        }
        for(int i3=0;i3<tab.GetLength(0);i3++){
            for(int i4=0;i4<tab.GetLength(1);i4++){
                Console.WriteLine(tab[i3,i4]);
            }
        }
    }
}