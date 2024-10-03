//input = ["1234-56785-902-3456", "9876-542-1098-76541"]
//output = ["****-*****-***-3456", "****-***-****-76541"]

string[] input = {"1234-56785-902-3456", "9876-542-1098-76541"};
List<string> maskedValue = new();
foreach (string inputItem in input){
  string[] part = inputItem.Split('-');
  for(int i = 0; i < part.Count()-1; i++)
  {
    part[i]  = new string('*' ,part[i].Length);
  }
  maskedValue.Add(string.Join("-", part));
}
Console.WriteLine($"[{string.Join(',', maskedValue)}]");
