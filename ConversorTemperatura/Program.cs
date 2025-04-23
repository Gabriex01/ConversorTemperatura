namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.WriteLine("CONVERSOR DE TEMPERATURA");
                    Console.WriteLine("Digite 1 para converter de Celsius para Farenheint ou digite 2 para converter de Farenheint para Celsius.");
                    Console.WriteLine("Digite 0 para sair do programa.");
                    Console.WriteLine("---------------------------------------------------");

                    int resp = int.Parse(Console.ReadLine());

                    if (resp == 1)
                    {
                        Console.Write("Informe a temperatura em Celsius: ");
                        float celsius = float.Parse(Console.ReadLine());
                        float farenheint = celsius * 1.8f + 32f;
                        Console.WriteLine("A temperatura em Farenheint é: " + farenheint);
                    }
                    else if (resp == 2)
                    {
                        Console.Write("Informe a temperatura em Farenheint: ");
                        float farenheint = float.Parse(Console.ReadLine());
                        float celsius = (farenheint - 32f) / 1.8f;
                        Console.WriteLine("A temperatura em Celsius é: " + celsius);
                    }
                    else if (resp == 0)
                    {
                        continuar = false;
                        Console.WriteLine("Encerrando o programa. Até logo!");
                    }
                    else
                    {
                        throw new Exception("Escolha não identificada. Digite 1 para converter para Farenheint, 2 para Celsius ou 0 para sair.");
                    }

                    Console.WriteLine(); // Linha em branco para separar as execuções
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                    Console.WriteLine();
                }
            }
        }
    }
}