namespace MaaskingNumberwithmetod;
public class Program {
  public static void Main(string[] args) {
    string[] input = ["1234-56785-902-3456", "9876-542-1098-76541"];
    List<string> output = MaskingNumber(input);
    System.Console.WriteLine($"[{string.Join(", ", output)}]");
  }
  public static List<string> MaskingNumber(string[] input)
  {
    List<string> MaskedNumber = new List<string>();
    foreach (string inputItem in input) {
      string[] parts = inputItem.Split('-');
      for (int i = 0;  i < parts.Length -1; i++) {
        parts[i] = new string('*', parts[i].Length);
      }
      MaskedNumber.Add(string.Join("-", parts));
    }
    return MaskedNumber;
   
  }
}