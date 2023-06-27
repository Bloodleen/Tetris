using System.ComponentModel;
using System.Drawing;
using Tetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

        Figure[] f = new Figure[1];
        f[0] = new Square(20, 5, '*');
        //f[1] = new Stick(3, 7, '*');

        foreach (Figure fig in f)
        {
            fig.Draw();
        }

        Figure.Direction dir = Figure.Direction.right;

        Thread.Sleep(3000);

        f[0].Hide();
        f[0].Move(dir);
        f[0].Draw();

        Console.ReadLine();
    }
}