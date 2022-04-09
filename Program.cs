using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal a;
            int tl = 0;
            Animal[] animais = new Animal [20]; //array

            int tlCachorro = 0, tlGato = 0, tlPeixe = 0; // contadores
            int tipoAnimal = 0; //variavel

            // leitura da quantidade de animais
            try
            {
                Console.Write("Quantos animais deseja informar? (máximo 20) ");
                tl = Convert.ToInt32(Console.ReadLine());
                if (tl > 20) tl = 20;
            }
            catch
            {
                tl = 0;
            }
            for (int i = 0; i < tl; i++)
			{
                a = new Animal();
                Console.WriteLine("Informe o nome do "+(i+1)+" animal: ");
                a.Nome = Console.ReadLine();
                Console.Write("Informe o tipo do "+(i+1)+"° animal (Cachorro - 0, Gato - 1 ou Peixe - 2): ");
                try
                {
                    tipoAnimal = Convert.ToInt32(Console.ReadLine());

                    //if((tipoAnimal < 0) && (tipoAnimal > 2)) tipoAnimal = 2;

                    if(tipoAnimal < 0) tipoAnimal = 2;
                    if(tipoAnimal > 2) tipoAnimal = 2;

                }
                catch
                {
                    tipoAnimal = 2;
                }
                a.Tipo = (TipoAnimal) tipoAnimal;
                
            // contando o tipo informado
            if (a.Tipo == TipoAnimal.Cachorro) tlCachorro++;
            if (a.Tipo == TipoAnimal.Gato) tlGato++;
            if (a.Tipo == TipoAnimal.Peixe) tlPeixe++;
            // armazenar o animal no vetor
            animais[i] = a;

			}
            


            //resultado
            Console.WriteLine("Total de animais");
            Console.WriteLine("Cachorros: " + tlCachorro + " \nGatos: " + tlGato + " \nPeixes: " + tlPeixe);
            Console.ReadKey();
        }
    }
}
