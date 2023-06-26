using System.Drawing;
using Tetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

        Stick st = new Stick(3, 7, '*');
        st.Draw();

        Square s = new Square(2, 5, '*');
        s.Draw();

        Console.ReadLine();
    }
}