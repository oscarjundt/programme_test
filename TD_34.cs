using System;
class Rose{
    static void Main(){
        string [,] tab = new string [8,8];
        int [,] tab2 = new int [8,8];
        Random aleatoire = new Random();
        bool c=true;
        for(int i=0;i<tab.GetLength(0);i++){
            for(int n=0;n<tab.GetLength(1);n++){
                int a=aleatoire.Next(2);
                tab[i,n]="[ ]";
                tab2[i,n]=a;
            }
        }
        tab[0,0]="[**]";
        for(int i1=0;i1<tab.GetLength(0);i1++){
            for(int n1=0;n1<tab.GetLength(1);n1++){
                Console.Write(tab[i1,n1]);
            }
            Console.WriteLine(" ");
        }
        while(c){
            Console.Write("lignem: ");
            int cc=int.Parse(Console.ReadLine());
            Console.Write("colonne: ");
            int cc2=int.Parse(Console.ReadLine());
            tab[cc,cc2]="[**]";
            if(tab2[cc,cc2]==1){
                Console.WriteLine("juste parce que case true");
            }
            else{
                Console.WriteLine("faut parce que case false");
            }
            for(int i0=0;i0<tab.GetLength(0);i0++){
                for(int n0=0;n0<tab.GetLength(1);n0++){
                    if(tab[i0,n0]=="[**]" && (i0!=cc && n0!=cc2)){
                        tab[i0,n0]="[ ]";
                    }
                }
            }
            for(int i3=0;i3<tab.GetLength(0);i3++){
                for(int n3=0;n3<tab.GetLength(1);n3++){
                    Console.Write(tab[i3,n3]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}