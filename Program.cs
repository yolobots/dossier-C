using System;

namespace calculatrice
{
    class Program
        //methods
         
    { public static int Add(int a, int b)// méthode de l'addition
        { return a + b; }
        public static int sous(int a, int b)// méthode de la soustraction
        { return a - b; }
        public static int fois(int a, int b)// méthode de la multiplication 
        { return a * b; }
        public static int divi(int a, int b)// méthode de la division
        { return a / b; }



        static void Main(string[] args)

        {
            Console.WriteLine("calculette");//écrit le mot(calculette)
            Console.WriteLine();// mets à la ligne 

            char Op;
         int a;//stocke un valeur 
         int b;//stocke une valeur
           
         Console.WriteLine("écrivez un chifre"); // affiche la phrase (écrit un chiffre)
         a = Convert.ToInt32( Console.ReadLine()); //(Convert)convertit les string en int car readline ne peut pas lire les sring/lit et stocke la valeur de (a)
         Console.WriteLine("un deuxième");// affiche la phrase (un deuxième)
         b = Convert.ToInt32( Console.ReadLine());//(Convert) convertit 
         Console.WriteLine("quelle opération voulez-vous effectuer?");
         Console.WriteLine("(+) (-) (*) (/) ");
            Op = Convert.ToChar(Console.ReadLine());// ca va convertir le sttring en char
            switch (Op)
            {
                case '+':
                    Console.WriteLine(Add(a, b));// cest la case de l'addition
               // Console.WriteLine(a + b);
                break;

                case '-':
                    Console.WriteLine(sous(a, b));//cest la case de la soustraction
                    // Console.WriteLine(a - b);
                    break;

                case '*':
                    Console.WriteLine(fois(a, b));//cest la case de la multiplication
                    //  Console.WriteLine(a * b);
                    break;

                case '/':
                    Console.WriteLine(divi(a, b));//cest la case de la division
                    //  Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("error"); 
                    break;
            }
           

           


            

        }
    }
}
