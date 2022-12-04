string[] input = new StreamReader("input").ReadToEnd().Split("\n");
int result = 0;
foreach (string rucksack in input)
{
	string compartment1 = rucksack.Substring(0,rucksack.Length/2);
	string compartment2 = rucksack.Substring(rucksack.Length/2);
	foreach (char item in compartment1)
		if(compartment2.Contains(item))
		{
			if(Char.IsUpper(item)) result+=(item-38);
			else result+=(item-96);
			break;
		}
}
Console.WriteLine($"Part one: {result}");
//Part two
result=0;
for(int i=0;i<input.Length;i+=3)
	foreach(char item in input[i])
		if((input[i+1].Contains(item))&&(input[i+2].Contains(item)))
		{
			if(Char.IsUpper(item)) result+=(item-38);
			else result+=(item-96);
			break;
		}
Console.WriteLine($"Part two: {result}");