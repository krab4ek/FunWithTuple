#region 1 code
(string, int, string) values1 = ("a", 56, "y");
var values = ("a", 56, "y");
(string FirstLetter, int TheNumber, string SecondLetter)
    valueWithNames = ("AAAA", 6, "bbbb");
var valueWithNames2 = (FirstLetter: "AAAA", TheNumber: 6, SecondLetter: "bbbb");

Console.WriteLine($"Values, Item 1: {valueWithNames2.FirstLetter}");
Console.WriteLine($"Values, Item 2: {valueWithNames2.TheNumber}");
Console.WriteLine($"Values, Item 3: {valueWithNames2.SecondLetter}\n");
Console.WriteLine($"Values, Item 1: {valueWithNames2.Item1}");
Console.WriteLine($"Values, Item 2: {valueWithNames2.Item2}");
Console.WriteLine($"Values, Item 3: {valueWithNames2.Item3}\n");
#endregion

#region 2 code

Console.WriteLine("=> Inferred Tuple Names\n");
var foo = new { Prop1 = "first", Prop2 = "second" };
var bar = (foo.Prop1, foo.Prop2);
Console.WriteLine($"{bar.Prop1}:{bar.Prop2}");
Console.WriteLine();
#endregion

#region 3 code
static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Andrei";
    c = false;
}

static (int a, string b, bool c) FillTheseValuesWithTuple()
{
    return (9, "Andrei", false);
}

static (string firstName, string midleName, string lastName)
    SplitNames(string fullName) => ("Andrei", "Valeri", "Melnik");

var samples = FillTheseValuesWithTuple();
Console.WriteLine($"Int is:\t\t{samples.a}");
Console.WriteLine($"String is:\t{samples.b}");
Console.WriteLine($"Bool is:\t{samples.c}");
Console.WriteLine();
//var fullName="Nikki";
var vivod = SplitNames("Andrei Valeri Melnik");
Console.WriteLine($"First name is:\t{vivod.firstName}");
Console.WriteLine($"Midle name is:\t{vivod.midleName}");
Console.WriteLine($"Last name is:\t{vivod.lastName}\n");
var (firstName, _, lastName) = SplitNames("Andrei Valeri Melnik");
Console.WriteLine($"{firstName}:{lastName}\n");
#endregion

#region 4 code
Point p = new Point(7, 5);
var pointValues = p.Deconstruct();
Console.WriteLine($"x is: {pointValues.XPos}");
Console.WriteLine($"y is: {pointValues.YPos}");
#endregion

Console.ReadLine();

struct Point
{
    public int x;
    public int y;
    public Point(int XPos, int YPos)
    {
        x = XPos;
        y = YPos;
    }
    public (int XPos, int YPos) Deconstruct() => (x, y);
}