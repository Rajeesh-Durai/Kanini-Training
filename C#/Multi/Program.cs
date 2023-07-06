using System;
using System.Runtime.Intrinsics.X86;

namespace Multi
{
    internal class program
    {
        static void Main(string[] args)
        {
            Abst abst = new Multicl();
            abst.Method();
            Interf interf = new Multicl();
            interf.Interact();
        }
    }
}
public void jagged()
{
    int i, j;
    int[][] jaggedArray = new int[4][];
    jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
    jaggedArray[1] = new int[] { 40, 50, 11, 4 };
    jaggedArray[2] = new int[] { 55, 17 };
    jaggedArray[3] = new int[4];

    Console.WriteLine(jaggedArray[0][2]);

    for (i = 0; i < jaggedArray[3].Length; i++)
    {
        jaggedArray[3][i] = Convert.ToInt32(Console.ReadLine());
    }


    int[][,] jaggy = new int[3][,];
    jaggy[0] = new int[5, 4];
    jaggy[1] = new int[6, 5];
    jaggy[2] = new int[7, 6];

    for (i = 0; i < 5; i++)
    {
        for (j = 0; j < 4; j++)
        {
            jaggy[0][i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    for (i = 0; i < 5; i++)
    {
        for (j = 0; j < 4; j++)
        {
            Console.Write(jaggy[0][i, j]);
        }
        Console.WriteLine();
    }
}