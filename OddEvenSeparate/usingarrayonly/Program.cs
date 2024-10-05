
class Program
{
  static void Main(string[] args)
  {
    int[] inputs = [1, 2, 4, 5, 10, 6, 3, 51];
    int[] evens = GetEvens(inputs);
    int[] odds = inputs.Except(evens).ToArray();
    System.Console.WriteLine($"Odd numbers are [{string.Join(", ", odds)}]");
    System.Console.WriteLine($"Even numbers are [{string.Join(", ", evens)}]");
  }

  private static int[] GetEvens(int[] inputs)
  {
    int count = 0;
    for (int i = 0; i < inputs.Length; i++)
    {
      if (inputs[i] % 2 == 0)
        count++;
    }
    int[] evennumbers = new int[count];
    int index = 0;
    for (int i = 0; i < inputs.Length; i++)
    {
      if (inputs[i] % 2 == 0)
      {
        evennumbers[index] = inputs[i];
        index++;
      }
    }
    return evennumbers;
  }

}