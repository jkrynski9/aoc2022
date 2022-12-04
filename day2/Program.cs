string[] input = new StreamReader("input").ReadToEnd().Split("\n");
const int win=6,draw=3,lose=0;
int score=0;
Dictionary<string, string> draws = new Dictionary<string,string>() {{"A","X"},{"B","Y"},{"C","Z"}};
Dictionary<string, string> rules = new Dictionary<string, string>() {{"A","Y"},{"B","Z"},{"C","X"}};
foreach(string line in input)
{
	string[] values = line.Split(" ");
	switch(values[1])
	{
		case "X":
		score+=1;
		break;
		case "Y":
		score+=2;
		break;
		case "Z":
		score+=3;
		break;
	}
	foreach(KeyValuePair<string, string> check in rules)
	{
		if(values[0]==check.Key)
		{
			if(check.Value==values[1]) score+=win;
			else if(check.Value!=values[0]) score+=lose;
		}
	}
	foreach(KeyValuePair<string, string> check in draws) if(values[0]==check.Key && values[1]==check.Value) score+=draw;
}
Console.WriteLine($"Part one: {score}");
//part two
score=0;
Dictionary<string, string> winningPair = new Dictionary<string, string>() {{"A","B"},{"B","C"},{"C","A"}};
foreach(string line in input)
{
	string[] values = line.Split(" ");
	string choice = "";
	switch(values[1])
	{
	case "X":
		foreach(KeyValuePair<string, string> check in winningPair)
			if(values[0]==check.Value) {
				choice=check.Key;
				score+=lose;
			}
		break;
	case "Y":
		choice=values[0];
		score+=draw;
		break;
	case "Z":
		foreach(KeyValuePair<string,string> check in winningPair)
			if(values[0]==check.Key) {
				choice=check.Value;
				score+=win;
		}
		break;
	}
	switch(choice)
	{
		case "A":
			score+=1;
			break;
		case "B":
			score+=2;
			break;
		case "C":
			score+=3;
			break;
	}
}
Console.WriteLine($"Part two: {score}");