// See https://aka.ms/new-console-template for more information
Console.WriteLine("Anna luku");
int luku = int.Parse(Console.ReadLine());

int[] lukuArray = new int[luku];

for (int i = 0; i< lukuArray.Length; i++)
{
    Console.WriteLine(i * 5);
}

