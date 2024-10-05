int [] inputs = [1, 2, 4, 5, 10, 6, 3, 51];
List<int> evens = new List<int>();
List<int> odds = new List<int>();

evens = GetEvenNumber(inputs);
odds = inputs.Except(evens).ToList();
System.Console.WriteLine($"Even Numbers are [{string.Join(", ", evens)}]");
System.Console.WriteLine($"Odd Numvers are [{string.Join(", ", odds)}]");
static List<int> GetEvenNumber(int [] inputs)
{
  List<int> evenNumbers = new ();
   foreach (int i in inputs){
    if(i%2==0)
      evenNumbers.Add(i);
   }

   return evenNumbers;
}

//uing tuple
//var v = GetOddEven(inputs);
(List<int> odds, List<int> evens) v = GetOddEven(inputs);

evens = v.Item2;
odds = v.Item1;
System.Console.WriteLine($"Even Numbers are [{string.Join(", ", evens)}]");
System.Console.WriteLine($"Odd Numvers are [{string.Join(", ", odds)}]");

static (List<int> odd, List<int> even) GetOddEven(int[] inputs)
{
  List<int> oddNumbers = new ();
  List<int> evenNumbers = new ();
  for (int i = 0;i<inputs.Count();i++){
    if(inputs[i]%2 ==0){
      evenNumbers.Add(inputs[i]);
    }
    else
      oddNumbers.Add(inputs[i]);
     
  }
   return(oddNumbers,evenNumbers);
}