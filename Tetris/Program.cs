﻿using System.Drawing;
using Tetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

        dot p1 = new dot();
        p1.x = 2;
        p1.y = 3;
        p1.c = '*';
        p1.Draw();


        Console.ReadLine();
    }
}