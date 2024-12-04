/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        int dias = int.Parse(Console.ReadLine());
        int anos = dias / 365;
        dias %= 365;
        int meses = dias / 30;
        dias %= 30;
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}