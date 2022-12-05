string[] input = new StreamReader("input").ReadToEnd().Split("\n");
int count=0,count2=0;
foreach(string line in input)
{
	string[] assigments = line.Split('-',',');
	List<int> elf1 = new List<int>();
	List<int> elf2 = new List<int>();
	for(int i=Int32.Parse(assigments[0]);i<=Int32.Parse(assigments[1]);i++) elf1.Add(i);
	for(int i=Int32.Parse(assigments[2]);i<=Int32.Parse(assigments[3]);i++)	elf2.Add(i);
	if(!((elf1.Except(elf2).Any())&&(elf2.Except(elf1).Any()))) count++;
	// Part two
	foreach(int value in elf1)
		if(elf2.Contains(value)) {
			count2++;
			break;
		}
}
Console.WriteLine($"Part one: {count}\nPart two: {count2}");
