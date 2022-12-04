string[] input = new StreamReader("input").ReadToEnd().Split("\n");
List<int> elves = new List<int>();
int calories=0;
for(int i=0;i<input.Length;i++) {
	if(input[i] == "") {
		elves.Add(calories);
		calories=0;
	}
	else calories+=int.Parse(input[i]);
}
Console.WriteLine(elves.Max());
elves.Sort();
elves.Reverse();
Console.WriteLine(elves[0]+elves[1]+elves[2]);