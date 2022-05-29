using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador
    {
        public int andarAtual = 0; //o elevador vai sair do térreo, andar 0.
        public int totalAndares;
        public int numeroPessoas = 0; //o elevador vai começar vazio.
        public int lotacao;

        public void Inicializar() //esta função pedirá ao usuário alguns parâmetros de início.
        {
            // perguntar ao usuário a capacidade máxima do elevador (quantas pessoas vão caber dentro do elevador)
            Console.WriteLine("Informe qual a capacidade máxima do elevador: ");
            lotacao = int.Parse(Console.ReadLine());

            // perguntar ao usuário a quantidade de andares do prédio
            Console.WriteLine("Informe quantos andares existem no prédio: ");
            totalAndares = int.Parse(Console.ReadLine());
        }

        public void Entrar() //esta função fará uma pessoa ser adicionada ao elevador.
        {
            numeroPessoas = numeroPessoas + 1;
            if (numeroPessoas == 1)
            {
                Console.WriteLine("Você entrou no elevador. Existe 1 pessoa no elevador.");
            }
            else if (numeroPessoas > lotacao)
            {
                Console.WriteLine($"O número máximo de pessoas foi atingido, você não pode entrar no elevador. Existem {lotacao} pessoas no elevador.");
                numeroPessoas = lotacao;
            }
            else
            {
                Console.WriteLine($"Você entrou no elevador. Existem {numeroPessoas} pessoas no elevador.");
            }
        }

        public void Sair() //esta função fará uma pessoa ser retirada do elevador.
        {
            numeroPessoas = numeroPessoas - 1;
            if (numeroPessoas < 0)
            {
                Console.WriteLine("Não existe ninguém no elevador para ser removido.");
                numeroPessoas = 0;
            }
            else if (numeroPessoas == 0)
            {
                Console.WriteLine($"Você saiu do elevador. O elevador está vazio.");
            }
            else if (numeroPessoas == 1)
            {
                Console.WriteLine($"Você saiu do elevador. Existe {numeroPessoas} pessoa no elevador.");
            }
            else
            {
                Console.WriteLine($"Você saiu do elevador. Existem {numeroPessoas} pessoas no elevador.");
            }
        }
        
        public void Subir() //esta função fará o elevador subir um andar. 
        {
            andarAtual = andarAtual + 1;
            if (andarAtual <= totalAndares)
            {
                Console.WriteLine($"Você subiu para o {andarAtual}° andar.");
            }
            else
            {
                Console.WriteLine($"Você atingiu o andar máximo e não pode mais subir. Você está no {totalAndares}° andar.");
                andarAtual = totalAndares;
            }
        }
        public void Descer() //esta função fará o elevador descer um andar. 
        {
            andarAtual = andarAtual - 1;
            if (andarAtual > 0)
            {
                Console.WriteLine($"Você desceu para o {andarAtual}° andar.");
            }
            else if (andarAtual == 0)
            {
                Console.WriteLine($"Você está no térreo.");
                andarAtual = 0;
            }
            else
            {
                Console.WriteLine($"Você está no térreo, portanto não pode descer.");
                andarAtual = 0;
            }
        }
    }
}
