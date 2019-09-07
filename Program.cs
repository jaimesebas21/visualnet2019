using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("--------------PROGRAMA PARA DOS NUMEROS--------------------");
            Console.WriteLine("DIGITE NUMERO:");
            numero= int.Parse(Console.ReadLine());
            if (numero > 9){
                Console.WriteLine("DIGITE NUMERO: "+numero+" Tiene dos digitos");
                
            }
            else if (numero>=100){
                Console.WriteLine("DIGITE NUMERO: "+numero+" Tiene tres digitos");
            }
            else{
                Console.WriteLine("DIGITE NUMERO: "+numero+" No Tiene dos digitos");
            }

            Console.ReadKey();

        }
    }
}
