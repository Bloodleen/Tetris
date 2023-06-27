using System.Drawing;
using Tetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

        Figure[] f = new Figure[2];
        f[0] = new Square(2, 5, '*');
        f[1] = new Stick(3, 7, '*');

        foreach(Figure fig in f)
        {
            fig.Draw();
        }

        //Stick st = new Stick(3, 7, '*');
        //st.Draw();

        //Square s = new Square(2, 5, '*');
        //s.Draw();

        Console.ReadLine();
    }
}