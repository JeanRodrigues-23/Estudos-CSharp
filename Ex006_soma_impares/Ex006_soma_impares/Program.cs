﻿using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

int x, y, soma = 0 ,troca, i;

Console.WriteLine("Digite dois numeros:");
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());

if (x > y)
{
    troca = x;
    x = y;
    y = troca;
}

for(i = x + 1; i < y; i++)
{
       if(i % 2 != 0)
    {
        soma = soma + i;
    }
 }

Console.WriteLine("SOMA DOS IMPARES = " + soma);