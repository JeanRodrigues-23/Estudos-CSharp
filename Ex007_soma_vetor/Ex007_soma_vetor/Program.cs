using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

int n, i;
double soma = 0, media;

Console.WriteLine("Quantos numeros você vai digitar? ");
n = int.Parse(Console.ReadLine());

double[] vet = new double[n];
for(i = 0; i < n; i++)
{
    Console.Write("Digite um numero: ");
    vet[i] = double.Parse(Console.ReadLine(), CI);
    soma = soma + vet[i];
}

Console.WriteLine();
Console.Write("VALORES = ");
for (i = 0; i < n; i++)
{
    Console.Write(vet[i].ToString("F1", CI) + " ");
}
Console.WriteLine();
f
Console.WriteLine("SOMA = " + soma.ToString("F2", CI));

media = soma / n;

Console.WriteLine("MEDIA = " + media.ToString("F2", CI));



