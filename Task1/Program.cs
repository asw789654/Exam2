int[] list = { 2, 3, 8, 1, 3, -5, 4 };
var result = list.OrderBy(x => x).ToList().Skip(list.Length / 2).OrderByDescending(x => x);
foreach (int number in result)
{
    Console.WriteLine(number * number);
}