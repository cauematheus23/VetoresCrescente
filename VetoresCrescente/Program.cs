﻿int size = 5, aux = 0;
int[] vetor = new int[size];
int[] vetor2 = new int[size];
int[] vetor3 = new int[size];

for (int i = 0; i < size;i++)
{
    vetor[i] = new Random().Next(0,size);
    vetor2[i] = vetor[i];
}
for (int i = 0; i < size; i++)

    for (int j = i + 1; j < size; j++)
    {
        if (vetor2[i] > vetor2[j])
        {
            aux = vetor2[i];
            vetor2[i] = vetor2[j];
            vetor2[j] = aux;
        }
    }

for (int i = 0; i < size; i++)
{

    if (vetor2[i] == vetor[i + 1])
    {
        vetor[i + 1] = vetor[i + 2];
    }
}
for (int i = 0; i < size; i++)
{
    Console.Write(vetor[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < size; i++)
{

    Console.Write(vetor2[i] + " ");
}
