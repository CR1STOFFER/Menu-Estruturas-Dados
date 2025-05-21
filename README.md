# VegaStructures

VegaStructures é um projeto em C# para manipulação prática de estruturas de dados fundamentais, como vetores, matrizes, listas, filas e pilhas. Além disso, inclui algoritmos básicos de pesquisa, com um menu interativo para facilitar o uso e aprendizado.

---

## Organização do Projeto

O código está organizado em namespaces e pastas para facilitar manutenção e entendimento:

- **VegaStructures.DataStructures:** Classes das estruturas de dados, cada uma em arquivo separado.
- **VegaStructures.Algorithms:** Implementações dos algoritmos de busca (sequencial e binária).
- **Program.cs:** Ponto de entrada que gerencia o menu e interação com o usuário.

---

## Como Funciona

Ao executar o programa, o usuário vê um menu principal com opções para manipular diferentes estruturas ou executar buscas. O programa fica em loop até o usuário escolher sair.

Menu principal:

- Vetores
- Matrizes
- Listas
- Filas
- Pilhas
- Algoritmos de Pesquisa
- Sair

Cada opção abre um submenu com operações específicas, como inserir, remover, mostrar e consultar elementos.

---

## Exemplos de Uso

### Gerenciamento de Vetores

```csharp
private static void GerenciarVetor()
{
    var vetor = new Vetor(5);
    int opcao;
    do
    {
        Console.Clear();
        Console.WriteLine("Operações no Vetor:");
        Console.WriteLine("1. Inserir");
        Console.WriteLine("2. Remover");
        Console.WriteLine("3. Mostrar");
        Console.WriteLine("4. Consultar");
        Console.WriteLine("0. Voltar");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Write("Elemento: ");
                int valor = int.Parse(Console.ReadLine());
                vetor.InserirElemento(valor);
                break;
            case 2:
                vetor.RemoverElemento();
                break;
            case 3:
                vetor.ExibirElementos();
                break;
            case 4:
                Console.Write("Consultar valor: ");
                int consulta = int.Parse(Console.ReadLine());
                vetor.ConsultarElemento(consulta);
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        Console.WriteLine("Pressione uma tecla para continuar...");
        Console.ReadKey();
    } while (opcao != 0);
}
