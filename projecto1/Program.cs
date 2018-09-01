using System;
using System.Globalization;

namespace projecto1
{
    class Program
    {
        static void Main(string[] args){   
            /*
            int count=0,soma=0, idade =0;

            float media = 0;
            Console.Write("Idade"+(count+=1)+": ");
            idade = int.Parse(Console.ReadLine());
            while(idade >=0){                
                soma += idade;
                Console.Write("Idade"+(++count)+": ");
                idade = int.Parse(Console.ReadLine());                
            } 
            count--;
            if(count>0){
                media = (float)soma/count;
                Console.WriteLine("Média = "+ media.ToString("F2",CultureInfo.InvariantCulture)); 
            }                
            else{                
                Console.WriteLine("IMPOSSIVEL CALCULAR"); 
            }
             */
            int N = int.Parse(Console.ReadLine());
            for(int x =0; x<N; x++){
                string [] vet = Console.ReadLine().Split(' ');
                float y = float.Parse(vet[0]);
                float z = float.Parse(vet[1]);
                if(z>0){
                    Console.WriteLine((y/z).ToString("F3",CultureInfo.InvariantCulture));
                } else{
                    Console.WriteLine("Não existe");
                }
            }
            Console.ReadLine();
        }
    }
}
