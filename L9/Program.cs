﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8PR2
{
    internal class Program


    {

        public static void Exercicio1()
        {
            float soma=0,media;
            Console.WriteLine("entre com o tamanho do seu vetor:");
            int num = int.Parse(Console.ReadLine());
            int[] vetor = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Entre com o valor:");
                vetor[i] = int.Parse(Console.ReadLine());
                soma =+ vetor[i];
            }
            media = soma / (float)num;
            Console.WriteLine("A media é: " + media ); 
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("vetor[{0}]={1}", i, vetor[i]);
            }    


        }
        public static void Exercicio2()
        {
        }
        public static void Exercicio3()
        {

        }


        public static void Exercicio4()
        {





        }


        static void Main(string[] args)
        {
            int menuzin;
            do
            {
                Console.WriteLine("========MENU=========");
                Console.WriteLine("Digite 0 para sair");
                Console.WriteLine("exercicio 1");
                Console.WriteLine("exercicio 2");
                Console.WriteLine("exercicio 3");
                Console.WriteLine("exercicio 4");


                menuzin = int.Parse(Console.ReadLine());

                switch (menuzin)
                {
                    case 0:
                        Console.WriteLine("Obrigada por utilizar o sistema");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;

                    default:
                        Console.WriteLine("Exercicio invalido");
                        break;
                }


            } while (menuzin != 0);
        }
    }
}
