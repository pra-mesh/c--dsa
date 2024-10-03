  int[] inputs =  [4, 3, 2, 4, 1, 3, 2, 7,7,8];
  List<int> uniqueNumbers = new List<int>();
  for (int i = 0; i < inputs.Length; i++)
  {
    int count = 0;
    for (int j = 0; j< inputs.Length; j++)
    {
      if(inputs[i] == inputs[j])
      {
        count++;
      }
      if(count>1)
      {
        break;
      }
    }
    if(count==1){
      uniqueNumbers.Add(inputs[i]);
    }
  }
  System.Console.WriteLine($"[{string.Join(", ", uniqueNumbers)}]");