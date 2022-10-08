using System.Linq;


var input = Console.ReadLine();
var sings = ",.?!;".ToCharArray();
var br = 0;

foreach (char item in input)
{
    if (sings.Contains(item))
        br++;
}
Console.WriteLine(br);
