using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

int n, i, j, negativos = 0;

Console.Write("Qual a ordem da matriz? ");
n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];
for (i = 0; i < n; i++)
{
    for (j = 0; j < n; j++)
    {
        Console.Write
            ("Elemento [" + i + "," + j + "]: ");
        mat[i, j] = int.Parse(Console.ReadLine());
        if (mat[i,j] < 0)
        {
            negativos++;
        }
    }
}

Console.WriteLine("Diagonal principal: ");
for(i = 0; i < n; i++)
{
    Console.Write(mat[i, i] + " ");
}
Console.WriteLine();

Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + negativos);


    