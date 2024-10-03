class Program
{
  static void Main(string[] args)
  {
    int[] inputs =  [4, 3, 2, 4, 1, 3, 2, 7];
    int[] outputs = FindUniqueNumber(inputs);
    System.Console.WriteLine($"[{string.Join(", ", outputs)}]");
  }
  static int[] FindUniqueNumber(int[] inputs)
  {
    Dictionary<int,int> countNumber = new ();
     foreach (int input in inputs)
     {
      if(countNumber.ContainsKey(input))
      {
        countNumber[input]++;
      }
      else
      {
        countNumber.Add(input, 1);
        //countNumber[input] =1;
      }
     }
     //using linq
     var value = countNumber.Where(x => x.Value == 1).Select(g =>g.Key).ToArray();
     //using loop
     List<int> uniqueElements = new List<int>();
     foreach (var number in countNumber)
     {
      if(number.Value == 1){
        uniqueElements.Add(number.Key);
      }
     }
     return uniqueElements.ToArray();
  }
}