using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tabuada_DotNET.Models
{
    /// <summary>
    /// Tabuada dos números
    /// </summary>
    public class Tabuada
    {
        public void ExibirMenu()
        {
            Console.WriteLine("Bem vindo a Tabuada .NET Console");
            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Multiplicação");
            Console.WriteLine("3 - Subtração");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
        }
        double num;
        public void Adicao()
        {
            Console.WriteLine("Tabuada da Adição");
            Console.Write("Digite o número desejado: ");
            num=Convert.ToDouble(Console.ReadLine());
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine($"{num} + {i} = {num+i}");          
            }
            Console.WriteLine("Digite ENTER para voltar ao menu");
            Console.ReadLine();
            ExibirMenu();
        }
        public void Multiplicacao()
        {
            Console.WriteLine("Tabuada de Multiplicação");
            Console.Write("Digite o número desejado: ");
            num=Convert.ToDouble(Console.ReadLine());
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine($"{num} * {i} = {i*num}");
                
            }
            Console.WriteLine("Digite ENTER para voltar ao menu");
            Console.ReadLine();
            ExibirMenu();
        }

        public void Subtracao()
        {
            
            Console.WriteLine("Tabuada da Subtração");
            Console.Write("Digite o número desejado: ");
            num=Convert.ToDouble(Console.ReadLine());
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine($"{num} - {i} = {num-i}");
            }
            Console.WriteLine("Digite ENTER para voltar ao menu");
            Console.ReadLine();
            ExibirMenu();
    
        }

        public void Divisao()
        {
            Console.WriteLine("Tabuada da Divisão");
            Console.Write("Digite o número desejado: ");
            num=Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {

                num.ToString("f2");
                if (i == 0)
                {
                    Console.WriteLine($"{num} / {i} = 0");
                    i++;
                }
                Console.WriteLine($"{num} / {i} = {Math.Round(num/i,2)}");  
            }
            Console.WriteLine("Digite ENTER para voltar ao menu");
            Console.ReadLine();
            ExibirMenu();
            
        }
        
    }
}