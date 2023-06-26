using Tetris;


//int[] nums1 = new int[5];

//for (int i = 0; i < nums1.Length; i++)
//    {
//        Console.WriteLine(nums1[i]);
//    }

//foreach (int i in nums1)
//{
//    Console.WriteLine(i);
//}

//Dot[] points  = new Dot[3];
//points[0] = new Dot(1, 2, '*');
//points[1] = new Dot(3, 4, '#');
//points[2] = new Dot(5, 6, '&');

//foreach (Dot i in points)
//{
//    i.Draw();
//}

char[][] field = new char[3][];
field[0] = new char[3];
field[1] = new char[3];
field[2] = new char[3];


for (int i = 0; i < field.Length; i++)
{
    for (int j = 0; j < field[i].Length; j++)
    {
        Console.Write(field[i][j] = '*');
    }
    Console.WriteLine();
}


Console.ReadLine();