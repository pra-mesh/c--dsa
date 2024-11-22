//OrderBY can be used for odering the list into ascending and OrderByDescending for desending order
//.Distinct() is used for distinct value and .Expecpt can be used for geting not unique. To get not unique Distinct is must.

//using group by the array list is converted with distinct value as Key with Count() as value we the select key value into a new list; 
int[] inputs =  [4, 3, 2, 4, 1, 3, 2, 7];
var uniqueNumbers = inputs.GroupBy(x=>x).Where(x=>x.Count()==1).Select(g=>g.Key).ToList();
System.Console.WriteLine($"[{string.Join(", ", uniqueNumbers)}]");

//using where below where clause finds the value from original data with condition for selected value. 
//Using Distinct can help if you don't want to iterate all value 
int[] uniqueNumbers1 = inputs.Where(x=> inputs.Count(y=>y==x)==1).ToArray();
System.Console.WriteLine($"[{string.Join(", ", uniqueNumbers1)}]");
inputs.Distinct();
System.Console.WriteLine();

//Instead of where used SelectMany whit a new int array defined;
 uniqueNumbers = inputs.GroupBy(x=>x).SelectMany(g=>g.Count()==1 ? new [] {g.Key} : new int[]{}).ToList();
System.Console.WriteLine($"[{string.Join(", ", uniqueNumbers)}]");

/*Performance and Memory Efficiency Analysis
First Approach (GroupBy, Where, Select):
Time Complexity: O(n + k log k) where n is the number of elements and k is the number of unique elements.
Memory Usage: Moderate, as it creates intermediate groupings and a list of unique elements.
Second Approach (Where with Count):
Time Complexity: O(n^2) because for each element, it counts occurrences in the entire array.
Memory Usage: Low, but the quadratic time complexity makes it inefficient for large arrays.
Third Approach (GroupBy and SelectMany):
Time Complexity: O(n + k log k) similar to the first approach.
Memory Usage: Moderate, similar to the first approach, as it also creates intermediate groupings and a list of unique elements.
Conclusion
Fastest: The first and third approaches are faster due to their linearithmic time complexity.
Most Memory Efficient: The second approach uses less memory but is significantly slower due to its quadratic time complexity. */