internal class Geometry
{
    private static List<string> GetZebra(
    int width,
    int height,
    int LineBold = 1,
    bool isVertical = false,
    char symbol = '*',
    char symbolClear = ' ')
    {
        List<string> result = new();
        string horiz = "";
        for (int r = 0; r < height; r++)
        {
            if (isVertical == false)
            {
                if (r % 2 == 0)
                    for (int i = 0; i < LineBold; i++)
                        result.Add(new string(symbol, width));
                else
                    for (int i = 0; i < LineBold; i++)
                        result.Add(new string(symbolClear, width));
            }
            else
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < LineBold; j++)
                    {
                        horiz += symbol;
                    }
                    for (int c = 0; c < LineBold; c++)
                    {
                        horiz += symbolClear;
                    }
                }
                result.Add(horiz);
                horiz = "";
            }
        }

        return result;
    }

    private static List<string> GetClock(
    int width,
    int height,
    bool isFill = true,
    char symbol = '*',
    char symbolClear = ' ')
    {
        List<string> result = new();

        for (int r = 0; r < height; r++)
        {
            if (isFill == true)
            {
                if (r < height / 2)
                    result.Add(new string(symbolClear, r) +
                    new string(symbol, width - r * 2) +
                    new string(symbolClear, r));
                else
                    result.Add(new string(symbolClear, height - r - 1) +
                    new string(symbol, width - (height - r - 1) * 2) +
                    new string(symbolClear, height - r - 1));
            }
            else
            {
                if (r == 0 || r == height - 1)
                {
                    result.Add(new string(symbol, width));
                }
                else
                {
                    if (r < height / 2)
                        result.Add(new string(symbolClear, r) +
                        new string(symbol, 1) +
                        new string(symbolClear, width - r * 2 - 2) +
                        new string(symbol, 1) +
                        new string(symbolClear, r));
                    else
                        result.Add(new string(symbolClear, height - r - 1) +
                        new string(symbol, 1) +
                        new string(symbolClear, width - (height - r - 1) * 2 - 2) +
                        new string(symbol, 1) +
                        new string(symbolClear, height - r - 1));
                }

            }

        }
        return result;
    }

    private static List<string> GetSnail(
    int width,
    int height,
    bool isRight = true)
    {
        char symbol = '▮';
        char symbolClear = '▯';
        string EndStr = $"{symbolClear}{symbol}";
        string StartStr = $"{symbol}{symbolClear}";
        List<string> result = new();

        string boof = "";
        int k = 0;
        for (int r = 0; r < height + 0; r++)
        {
            if (r == 0 || r == height - 1)
            {
                result.Add(new string(symbol, width));
                continue;
            }
            if (r < height / 2 + 1)
            {
                if (r % 2 == 1)
                {
                    boof = new string(symbolClear, width - (r * 2));
                    for (int i = 0; i < (r / 2) + 1; i++)
                    {
                        if (isRight == true)
                        {
                            boof += EndStr;
                            if (i > 0)
                            {
                                boof = StartStr + boof;
                            }
                        }
                        else
                        {
                            boof = StartStr + boof;
                            if (i > 0)
                            {
                                boof += EndStr;
                            }
                        }
                    }
                    result.Add(boof);
                    boof = "";
                }
                else
                {
                    boof = new string(symbol, width - (r + k) + 1);
                    for (int i = 0; i < r - (i + 1); i++)
                    {
                        if (isRight == true)
                        {
                            if (i == 0)
                            {
                                boof += EndStr;
                            }
                            else
                            {
                                boof += EndStr;
                                boof = StartStr + boof;
                            }
                        }
                        else
                        {
                            if (i == 0)
                            {
                                boof = StartStr + boof;
                            }
                            else
                            {
                                boof += EndStr;
                                boof = StartStr + boof;
                            }
                        }
                    }
                    result.Add(boof);
                    boof = "";
                }
                k += 1;
            }
            else
            {
                if (r % 2 == 1)
                {
                    if (height % 2 == 0)
                    {
                        boof = new string(symbolClear, width - 2 - ((height - r) * 2));
                        for (int i = 0; i < ((height - r + 1) / 2); i++)
                        {
                            boof = StartStr + boof;
                            boof += EndStr;
                        }
                        result.Add(boof);
                        boof = "";
                    }
                    else
                    {
                        boof = new string(symbolClear, width - ((height - r) * 2));
                        for (int i = 0; i < ((height - r + 1) / 2); i++)
                        {
                            boof = StartStr + boof;
                            boof += EndStr;
                        }
                        result.Add(boof);
                        boof = "";
                    }
                }
                else
                {
                    if (height % 2 == 0)
                    {
                        boof = new string(symbol, width - ((height - r) + k) + 1);
                        for (int i = 0; i < (height - r + 2) - (i + 1); i++)
                        {
                            if (i == 0)
                            {
                                continue;
                            }
                            else
                            {
                                if (i > 0)
                                    boof += EndStr;
                                boof = StartStr + boof;
                            }
                        }
                        result.Add(boof);
                        boof = "";
                    }
                    else
                    {
                        boof = new string(symbol, width - ((height - r) + k) + 2);
                        for (int i = 0; i < (height - r + 2) - (i + 1); i++)
                        {
                            if (i == 0)
                            {
                                continue;
                            }
                            else
                            {
                                if (i > 0)
                                    boof += EndStr;
                                boof = StartStr + boof;
                            }
                        }
                        result.Add(boof);
                        boof = "";
                    }
                }
                k -= 1;
            }
        }
        return result;
    }



    internal static void PrintZebra(
    int width,
    int height,
    int LineBold = 1,
    bool isVertical = false,
    char symbol = '*',
    char symbolClear = ' ')
    {
        Console.WriteLine(string.Join(Environment.NewLine, GetZebra(width, height, LineBold, isVertical, symbol, symbolClear)));
    }

    internal static void PrintClock(
    int width,
    int height,
    bool isFill = true,
    char symbol = '*',
    char symbolClear = ' ')
    {
        Console.WriteLine(string.Join(Environment.NewLine, GetClock(width, height, isFill, symbol, symbolClear)));
    }

    internal static void PrintSnail(
    int width,
    int height,
    bool isRight = true)
    {
        Console.WriteLine(string.Join(Environment.NewLine, GetSnail(width, height, isRight)));
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Geometry.PrintZebra(5, 5, 4);
        Geometry.PrintClock(30, 30, false);
        Geometry.PrintSnail(10, 10);
    }
}