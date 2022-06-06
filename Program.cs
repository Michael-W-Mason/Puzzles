static void RandomArray()
{
    Random rand = new Random();
    int[] ranArr = new int[10];
    int min = int.MaxValue;
    int max = int.MinValue;
    int sum = 0;
    for (int i = 0; i < ranArr.Length; i++)
    {
        ranArr[i] = rand.Next(5, 26);
        if (ranArr[i] > max)
        {
            max = ranArr[i];
        }
        if (ranArr[i] < min)
        {
            min = ranArr[i];
        }
        sum += ranArr[i];
    }
    Console.WriteLine(min.ToString());
    Console.WriteLine(max.ToString());
    Console.WriteLine(sum.ToString());
}
RandomArray();

static string TossCoin()
{
    Random rand = new Random();
    Console.WriteLine("Tossing a Coin");
    int toss = rand.Next(0, 2);
    if (toss == 1)
    {
        Console.WriteLine("Heads");
        return "Heads";
    }
    Console.WriteLine("Tails");
    return "Tails";
}
TossCoin();

static double TossMultipleCoins(int num)
{
    Random rand = new Random();
    int heads = 0;
    int tails = 0;
    for (int i = 0; i < num; i++)
    {
        string result = TossCoin();
        if (result == "Heads")
        {
            heads++;
        }
        else
        {
            tails++;
        }
    }
    Console.WriteLine((double)heads / (double)tails);
    return (double)heads / (double)tails;
}
TossMultipleCoins(4);

static List<string> Names()
{
    List<string> names = new List<string>();
    names.Add("Todd");
    names.Add("Tiffany");
    names.Add("Charlie");
    names.Add("Geneva");
    names.Add("Sydney");
    for (int i =0; i <  names.Count; i++)
    {
        if (names[i].Length < 5)
        {
            names.RemoveAt(i);
        }
    }
    return names;
}
Names();