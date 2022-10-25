internal class Program
{
    enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Raiz, Potencia, Sair };
    private static void Main(string[] args)
    {
        bool escolheuSair = false;
        while (!escolheuSair) // ENQUANTO O USUARIO NÃO(!) ESCOLHER SAIR EXIBA O CÓDIGO.
        {
            Console.WriteLine("Bem-Vindo a calculadora Mário, escolha uma das opção abaixo: ");
            Console.WriteLine("=============================================================");
            Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Raiz\n6-Potência\n7-Sair");
            /*
            esse código enorme abaixo é como se fosse assim:

                string opcaoTXT = Console.ReadLine();
                int opcaoInt = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoInt;
            */
            Menu opcao = (Menu)int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case Menu.Soma:
                    Soma();
                    break;
                case Menu.Subtracao:
                    Subtrair();
                    break;
                case Menu.Multiplicacao:
                    Multiplicar();
                    break;
                case Menu.Divisao:
                    Divisao();
                    break;
                case Menu.Raiz:
                    Raiz();
                    break;
                case Menu.Potencia:
                    Potencia();
                    break;
                case Menu.Sair:
                    escolheuSair = true;
                    break;
            }


            Console.Clear();
        }

        static void Soma()
        {
            Console.WriteLine("Some dois números.");
            Console.WriteLine("=========================");
            Console.Write("Digite o Primeiro número: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo número : ");
            int number2 = int.Parse(Console.ReadLine());
            int resposta = number1 + number2;
            Console.WriteLine($"A soma de {number1} e {number2} é igual a {resposta}");
            Console.WriteLine("");
            Console.WriteLine("||Pressione ENTER para voltar ao Menu||");
            Console.ReadLine();
        }

        static void Subtrair()
        {
            Console.WriteLine("Subtrair dois números.");
            Console.WriteLine("=========================");
            Console.Write("Digite o Primeiro número: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo número : ");
            int number2 = int.Parse(Console.ReadLine());
            int resposta = number1 - number2;
            Console.WriteLine($"A subtração de {number1} e {number2} é igual a {resposta}");
            Console.WriteLine("");
            Console.WriteLine("||Pressione ENTER para voltar ao Menu||");
            Console.ReadLine();
        }

        static void Multiplicar()
        {
            Console.WriteLine("Multiplique dois números.");
            Console.WriteLine("=========================");
            Console.Write("Digite o Primeiro número: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo número : ");
            int number2 = int.Parse(Console.ReadLine());
            int resposta = number1 * number2;
            Console.WriteLine($"A multiplicação de {number1} e {number2} é igual a {resposta}");
            Console.WriteLine("");
            Console.WriteLine("||Pressione ENTER para voltar ao Menu||");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divida dois números.");
            Console.WriteLine("=========================");
            Console.Write("Digite o Primeiro número: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo número : ");
            int number2 = int.Parse(Console.ReadLine());
            float resposta = (float)number1 / (float)number2; // para mostrar a casa decimal (casting)
            Console.WriteLine($"A divisão de {number1} e {number2} é igual a {resposta}");
            Console.WriteLine("");
            Console.WriteLine("||Pressione ENTER para voltar ao Menu||");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz quadrada do número");
            Console.WriteLine("=========================");
            Console.Write("Digite o número: ");
            int number = int.Parse(Console.ReadLine());
            double raiz = Math.Sqrt(number);
            Console.WriteLine($"A raiz quadrada de {number}  é igual a {raiz}");
            Console.WriteLine("");
            Console.WriteLine("||Pressione ENTER para voltar ao Menu||");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potencia de um número");
            Console.WriteLine("=========================");
            Console.Write("Digite o número base: ");
            int numberbase = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            int potencia = (int)Math.Pow(numberbase, expoente); //para fazer a potencia de um numero
            Console.WriteLine($"O número base {numberbase} elevado ao expoente {expoente} será {potencia}");
            Console.WriteLine("");
            Console.WriteLine("||Pressione ENTER para voltar ao Menu||");
            Console.ReadLine();
        }


    }
}