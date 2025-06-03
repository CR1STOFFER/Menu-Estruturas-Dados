using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuInterativo
{
    class Program
    {
        static int[] vetor = new int[10];
        static int vetorIndex = 0;

        static int[,] matriz = new int[3, 3];

        static List<int> lista = new List<int>();

        static Queue<int> fila = new Queue<int>();

        static Stack<int> pilha = new Stack<int>();

        static void Main(string[] args)
        {
            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("===== MENU PRINCIPAL =====");
                Console.WriteLine("1 - Vetores");
                Console.WriteLine("2 - Matrizes");
                Console.WriteLine("3 - Trabalhar com Lista");
                Console.WriteLine("4 - Trabalhar com Fila");
                Console.WriteLine("5 - Trabalhar com Pilha");
                Console.WriteLine("6 - Algoritmos de Pesquisa");
                Console.WriteLine("7 - Encerrar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": MenuVetor(); break;
                    case "2": MenuMatriz(); break;
                    case "3": MenuLista(); break;
                    case "4": MenuFila(); break;
                    case "5": MenuPilha(); break;
                    case "6": MenuPesquisa(); break;
                    case "7": sair = true; break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            }
        }

        // --------------------- VETOR ---------------------
        static void MenuVetor()
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("===== SUBMENU - VETOR =====");
                Console.WriteLine("1 - Inserir elemento");
                Console.WriteLine("2 - Remover último elemento");
                Console.WriteLine("3 - Exibir elementos");
                Console.WriteLine("4 - Buscar elemento");
                Console.WriteLine("5 - Voltar");
                Console.Write("Escolha: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        if (vetorIndex >= vetor.Length)
                        {
                            Console.WriteLine("Vetor cheio!");
                        }
                        else
                        {
                            Console.Write("Digite o valor: ");
                            int val = int.Parse(Console.ReadLine());
                            vetor[vetorIndex++] = val;
                        }
                        break;
                    case "2":
                        if (vetorIndex > 0) vetorIndex--;
                        else Console.WriteLine("Vetor vazio.");
                        break;
                    case "3":
                        Console.WriteLine("Elementos no vetor:");
                        for (int i = 0; i < vetorIndex; i++)
                            Console.Write(vetor[i] + " ");
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.Write("Digite o valor a buscar: ");
                        int buscado = int.Parse(Console.ReadLine());
                        bool encontrado = false;
                        for (int i = 0; i < vetorIndex; i++)
                            if (vetor[i] == buscado) encontrado = true;
                        Console.WriteLine(encontrado ? "Encontrado!" : "Não encontrado.");
                        break;
                    case "5": voltar = true; break;
                    default: Console.WriteLine("Inválido."); break;
                }
                Console.ReadKey();
            }
        }

        // --------------------- MATRIZ ---------------------
        static void MenuMatriz()
        {
            Console.Clear();
            Console.WriteLine("Preenchendo matriz 3x3:");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Valor [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("\nMatriz preenchida:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(matriz[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        // --------------------- LISTA ---------------------
        static void MenuLista()
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("===== SUBMENU - LISTA =====");
                Console.WriteLine("1 - Inserir elemento");
                Console.WriteLine("2 - Remover elemento");
                Console.WriteLine("3 - Exibir todos");
                Console.WriteLine("4 - Buscar elemento");
                Console.WriteLine("5 - Voltar");
                Console.Write("Escolha: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Valor: ");
                        lista.Add(int.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        Console.Write("Valor a remover: ");
                        int rem = int.Parse(Console.ReadLine());
                        lista.Remove(rem);
                        break;
                    case "3":
                        lista.ForEach(i => Console.Write(i + " "));
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.Write("Buscar: ");
                        int busca = int.Parse(Console.ReadLine());
                        Console.WriteLine(lista.Contains(busca) ? "Encontrado!" : "Não encontrado.");
                        break;
                    case "5": voltar = true; break;
                    default: Console.WriteLine("Inválido."); break;
                }
                Console.ReadKey();
            }
        }

        // --------------------- FILA ---------------------
        static void MenuFila()
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("===== SUBMENU - FILA =====");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Exibir");
                Console.WriteLine("4 - Buscar");
                Console.WriteLine("5 - Voltar");
                Console.Write("Escolha: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Valor: ");
                        fila.Enqueue(int.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        if (fila.Count > 0) Console.WriteLine($"Removido: {fila.Dequeue()}");
                        else Console.WriteLine("Fila vazia.");
                        break;
                    case "3":
                        foreach (var item in fila)
                            Console.Write(item + " ");
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.Write("Buscar: ");
                        int busca = int.Parse(Console.ReadLine());
                        Console.WriteLine(fila.Contains(busca) ? "Encontrado!" : "Não encontrado.");
                        break;
                    case "5": voltar = true; break;
                    default: Console.WriteLine("Inválido."); break;
                }
                Console.ReadKey();
            }
        }

        // --------------------- PILHA ---------------------
        static void MenuPilha()
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("===== SUBMENU - PILHA =====");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Exibir");
                Console.WriteLine("4 - Buscar");
                Console.WriteLine("5 - Voltar");
                Console.Write("Escolha: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Valor: ");
                        pilha.Push(int.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        if (pilha.Count > 0) Console.WriteLine($"Removido: {pilha.Pop()}");
                        else Console.WriteLine("Pilha vazia.");
                        break;
                    case "3":
                        foreach (var item in pilha)
                            Console.Write(item + " ");
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.Write("Buscar: ");
                        int busca = int.Parse(Console.ReadLine());
                        Console.WriteLine(pilha.Contains(busca) ? "Encontrado!" : "Não encontrado.");
                        break;
                    case "5": voltar = true; break;
                    default: Console.WriteLine("Inválido."); break;
                }
                Console.ReadKey();
            }
        }

        // --------------------- PESQUISA ---------------------
        static void MenuPesquisa()
        {
            Console.Clear();
            Console.WriteLine("===== PESQUISA LINEAR =====");
            Console.Write("Digite elementos separados por espaço: ");
            string[] entrada = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(entrada, int.Parse);

            Console.Write("Valor a buscar: ");
            int valor = int.Parse(Console.ReadLine());

            int posicao = PesquisaLinear(array, valor);
            if (posicao != -1)
                Console.WriteLine($"Valor encontrado na posição {posicao}");
            else
                Console.WriteLine("Valor não encontrado.");

            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        static int PesquisaLinear(int[] array, int valor)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == valor) return i;
            return -1;
        }
    }
}