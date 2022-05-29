using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROJETO FINAL: Software para gerenciamento de um elevador.
            Console.WriteLine("SOFTWARE PARA GERENCIAMENTO DE UM ELEVADOR \n");
            
            //criar um objeto elevador a partir da classe Elevador
            Elevador elevador = new Elevador();

            //função Inicializar para pedir ao usuário a capacidade do elevador e total de andares do prédio
            elevador.Inicializar();

            bool continuar = true;

            do
            {
                //4 opções de escolha para o usuário
                Console.WriteLine($@"
                Este prédio possui {elevador.totalAndares} andares e a lotação máxima do elevador é de {elevador.lotacao} pessoas.
                            Escolha uma opção
                                    1 - Entrar;
                                    2 - Sair;
                                    3 - Subir;
                                    4 - Descer;
            ");

                //lê a opção que o usuário escolher e como retorno é ativada uma função.
                string OpcaoEscolhida = Console.ReadLine();

                Console.Clear();

                // Cada uma das escolhas irá ativar uma função (método).
                switch (OpcaoEscolhida)
                {
                    //Escolhendo 1, uma pessoa será adicionada no elevador.
                    case "1":
                        elevador.Entrar();
                        //Escrevi esta parte do código para informar ao usuário o que está armazenado na classe Elevador, a cada ação que ele tomar.
                        Console.WriteLine($"" +
                            $"\n Informações do elevador:" +
                                $" \n   Andar atual: {elevador.andarAtual}" +
                                $" \n   Quantidade de pessoas no elevador: {elevador.numeroPessoas}"); break;
                    //Escolhendo 2, uma pessoa será retirada do elevador.
                    case "2":
                        elevador.Sair();
                        Console.WriteLine($"" +
                            $"\n Informações do elevador:" +
                                $" \n   Andar atual: {elevador.andarAtual}" +
                                $" \n   Quantidade de pessoas no elevador: {elevador.numeroPessoas}"); break;
                    //Escolhendo 3, o elevador irá subir um andar.
                    case "3":
                        elevador.Subir();
                        Console.WriteLine($"" +
                            $"\n Informações do elevador:" +
                                $" \n   Andar atual: {elevador.andarAtual}" +
                                $" \n   Quantidade de pessoas no elevador: {elevador.numeroPessoas}"); break;
                    //Escolhendo 4, o elevador irá descer um andar.
                    case "4":
                        elevador.Descer();
                        Console.WriteLine($"" +
                            $"\n Informações do elevador:" +
                                $" \n   Andar atual: {elevador.andarAtual}" +
                                $" \n   Quantidade de pessoas no elevador: {elevador.numeroPessoas}"); break;

                    //Caso o usuário não escolha um número de 1 a 4, dará um erro, obrigando-o a sempre escolher de 1 a 4.
                    default: 
                        Console.WriteLine("Escolha não válida.");
                        Console.WriteLine($"" +
                            $"\n Informações do elevador:" +
                                $" \n   Andar atual: {elevador.andarAtual}" +
                                $" \n   Quantidade de pessoas no elevador: {elevador.numeroPessoas}");  break;
                }
            }
            while (continuar);
        }
    }
}
