using System;

namespace SalarioCargos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Informe o salário: ");
            Console.ResetColor();

            salario = float.Parse(Console.ReadLine());

            if (salario == 1500.00f)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Cargo: Estagiário.");
                Console.ResetColor();
            }
            else if (salario >= 2000.00f && salario <= 2400.00f)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Cargo: Professor Nível 1.");
                Console.ResetColor();
            }
            else if (salario > 2400.00f && salario <= 3000.00f)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cargo: Professor Nível 2.");
                Console.ResetColor();
            }
            else if (salario > 4250.92f && salario <= 5000.00f)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Cargp: Diretor.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este salário não existe no quadro de funcionários da nossa escola.");
                Console.ResetColor();
            }

            Console.ReadKey();

        }
    }
}
