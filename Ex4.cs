/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira data (formato: dd/MM/yyyy):");
        DateTime data1 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda data (formato: dd/MM/yyyy):");
        DateTime data2 = DateTime.Parse(Console.ReadLine());

        TimeSpan diferenca = data2 - data1;

        Console.WriteLine($"A diferença entre as datas é de {diferenca.Days} dias.");
    }
}