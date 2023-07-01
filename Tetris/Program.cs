using System.ComponentModel;
using System.Drawing;
using Tetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

        FigureGenerator generator = new FigureGenerator(20, 0, '*');

        Figure s = generator.GetNewFigure();

        s.Draw();

        //s.Hide();
        
        while(true)
        {
            s.MoveDown(Figure.Direction.down, s);
            s = generator.GetNewFigure();
        }


        Console.ReadLine();
    }
}