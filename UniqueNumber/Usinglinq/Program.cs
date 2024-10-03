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

//Instead of where used SelectMany whit a new int array defined;
 uniqueNumbers = inputs.GroupBy(x=>x).SelectMany(g=>g.Count()==1 ? new [] {g.Key} : new int[]{}).ToList();
System.Console.WriteLine($"[{string.Join(", ", uniqueNumbers)}]");
