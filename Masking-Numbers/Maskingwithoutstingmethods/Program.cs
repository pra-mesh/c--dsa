string[] input = {"1234-56785-902-3456", "9876-542-1098-76541"};
List<string> maskedvalue = new List<string>();
string output="";
foreach (string item in input){
 string[] parts = item.Split("-");
 string masked ="";
 for(int i=0; i<parts.Length; i++)
 {
 
  if(i<parts.Length-1)
   {
    for(int j=0; j<parts[i].Length; j++){
      masked+="*";
      
    }
    masked +="-";
   
  }
  else
  masked +=parts[i];

 }
 maskedvalue.Add(masked);
}
for (int i=0; i<maskedvalue.Count; i++){
if(i==0){
  output+="[" + maskedvalue[i] + ",";
}
else if(i==maskedvalue.Count-1){
  output += maskedvalue[i] +"]";
}
else
output+=maskedvalue[i] +",";
}
System.Console.WriteLine(output);