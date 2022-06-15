Console.WriteLine("Digite um número: ");
int num = int.Parse(Console.ReadLine());

int primeiro = 0;
int segundo = 1;
int proximo = segundo + primeiro;

while (true)
{
    if (num == proximo || num == 1 || num == 0)
    {
        Console.WriteLine("O número PERTENCE a sequência de Fibonacci");
        break;
    }
    if (proximo > num)
    {
        Console.WriteLine("O número NÃO PERTENCE a sequência de Fibonacci");
        break;
    }
    primeiro = segundo;
    segundo = proximo;
    proximo = segundo + primeiro;
}
