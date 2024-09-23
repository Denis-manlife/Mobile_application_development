internal static class Geometry
{
    internal static void PrintSnailChar(int row, int column, bool isRight = true)
    {
        char[,] Snail = new char[row, column];
        int direction = 1;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Snail[i, j] = '▯';
            }
        }
        int a = 0, b = 0, c = 0, d = 0;
        while (true)
        {
            if (a >= column || b >= row || c >= column || d >= row)
            {
                break;
            }
            if (isRight == true)
            {
                if (direction == 1)
                {
                    if (a > 1)
                    {
                        for (int i = 0 + a - 1; i < column - 1 - a; i++)
                        {
                            Snail[a, i] = '▮';
                        }
                    }
                    else
                    {
                        for (int i = 0 + a; i < column - 1 - a; i++)
                        {
                            Snail[a, i] = '▮';
                        }
                    }
                    a += 2;
                    direction = 2;
                }
                if (direction == 2)
                {
                    for (int i = 0 + b; i < row - 1 - b; i++)
                    {
                        Snail[i, column - 2 - b] = '▮';
                    }
                    b += 2;
                    direction = 3;
                }
                if (direction == 3)
                {
                    for (int i = column - b - 1; i > c; i--)
                    {
                        Snail[row - 2 - c, i] = '▮';
                    }
                    c += 2;
                    direction = 4;
                }
                if (direction == 4)
                {
                    for (int i = row - c; i > c - 1; i--)
                    {
                        Snail[i, d] = '▮';
                    }
                    d += 2;
                    direction = 1;
                }
            }
            else
            {
                if (direction == 1)
                {
                    if (a > 1)
                    {
                        for (int i = column - 1 - a; i > 0 + a - 1; i--)
                        {
                            Snail[a, i] = '▮';
                        }
                    }
                    else
                    {
                        for (int i = column - 1 - a; i > 0 + a; i--)
                        {
                            Snail[a, i] = '▮';
                        }
                    }
                    a += 2;
                    direction = 2;
                }
                if (direction == 2)
                {
                    for (int i = 0 + b; i < row - 1 - b; i++)
                    {
                        Snail[i, b] = '▮';
                    }
                    b += 2;
                    direction = 3;
                }
                if (direction == 3)
                {
                    for (int i = c; i < column - c - 1; i++)
                    {
                        Snail[row - 2 - c, i] = '▮';
                    }
                    c += 2;
                    direction = 4;
                }
                if (direction == 4)
                {
                    for (int i = row - c - 1; i > c - 1; i--)
                    {
                        Snail[i, column - 2 - d] = '▮';
                    }
                    d += 2;
                    direction = 1;
                }
            }
        }
        for (int i = 0; i < row - 1; i++)
        {
            for (int j = 0; j < column - 1; j++)
            {
                Console.Write(Snail[i, j]);
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Geometry.PrintSnailChar(10, 10);
    }
}