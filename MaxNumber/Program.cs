int[] arr = { 0, 1, 2, 19, 9, 12, 5, 6, 6 };
int maxnumber = 0;

//maxnumber using linq
maxnumber = arr.Max();
Console.WriteLine("Max number using max linq medthod " + maxnumber);

//using sort and first  value
maxnumber = arr.OrderByDescending(x => x).FirstOrDefault();
Console.WriteLine("Max number using orderby linq medthod " + maxnumber);

// using array sort 
Array.Sort(arr);
maxnumber = arr[arr.Length - 1];
Console.WriteLine("Using array Sort " + maxnumber);

//using simple loop
for (int i = 0; i < arr.Length - 1; i++)
{
    if (maxnumber < arr[i])
    {
        maxnumber = arr[i];
    }
}
Console.WriteLine("Using simple loop " + maxnumber);

//using recursive method
int[] arr1 = { 0, 1, 2, 19, 9, 12, 5, 6, 6 };
maxnumber = FindMaxRecursive(arr1, 0);
int FindMaxRecursive(int[] arr1, int index
)
{
    if (arr1.Length - 1 == index)
    {
        return arr1[index];

    }
    Console.WriteLine(index);
    int maxnumber = FindMaxRecursive(arr1, index + 1);
    Console.WriteLine(index);
    return arr1[index] > maxnumber ? arr1[index] : maxnumber;
}
System.Console.WriteLine("MAx Number using recursive method " + maxnumber);