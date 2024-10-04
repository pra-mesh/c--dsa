int [] inputs = [1, 2, 4, 5, 10, 6, 3, 51];
int [] evennumbers = inputs.Where(x =>x%2 == 0).ToArray();
int [] oddnumbrs = inputs.Where(x =>x%2 != 0).ToArray();
System.Console.WriteLine($"The even numbers are [{string.Join(", ", evennumbers)}]");
System.Console.WriteLine($"The odd numbers are [{string.Join(", ", oddnumbrs)}]");