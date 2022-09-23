// See https://aka.ms/new-console-template for more information

//define input
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Please insert lenght in meters:");
int a=int.Parse(Console.ReadLine());
Console.Write("Please insert Weight in meters:");
double b=double.Parse(Console.ReadLine());
Console.Write("Please insert number of corridor:");
string nc=Console.ReadLine();    
Console.Write("Please insert weight of corridor:");
int corr=int.Parse(Console.ReadLine())*100*int.Parse(nc);
double l = Math.Max(a,b) * 100;
double w = Math.Min(a,b) * 100-(corr*int.Parse(nc));
double result = ((Math.Round(w / 70, 0)) * (Math.Round(l / 120, 0)))-3;
string info =result.ToString();
string c=l.ToString();  
string f=w.ToString();
string  wr="Work Place:"+result;
string nwr = "";
string nwr1 = "";
string curr = "The number of corridor is " + nc + ". Corridor size is: " + a + " x " + corr;
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("\t\nFor work area with dimmension leight {0} and weight {1}, you can add {2} work place.\t\nOr for place {0} x {1} with {3} corridors {4} x {5}  \t\nYou can add {2} work place", l,w,result,nc.ToString(),a,corr);
//draw 
Console.ForegroundColor = ConsoleColor.DarkBlue;
for (int g = 0; g < a+4;g++)
{
    Console.Write("=");
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
for (int j = 0; j < (Math.Round(Math.Max((l / 100), (w / 100)), 0) - c.Length) / 2; j++)
{
    Console.Write("*");
}
Console.Write(c);
for (int j = 0; j < (Math.Round(Math.Max((l / 100), (w / 100)), 0) - c.Length) / 2; j++)
{
    Console.Write("*");
}
Console.WriteLine();
for (int j = 0; j < (Math.Round(Math.Min((l / 100), (w / 100)), 0)) / 2; j++)
{
    Console.Write("*");
    for (int d = 0; d < Math.Round(Math.Max((l / 100), (w / 100))-1, 0) ; d++)
    {
        Console.Write(" ");
    }
    Console.Write("*");
    Console.WriteLine();
}
for (int j = 0; j < f.Length; j++)
{
    Console.Write(f[j]);
    for (int d = 0; d < a - 1; d++)
    {
        Console.Write(" ");
    }
    Console.Write(f[j]);
    Console.WriteLine();
}
for (int j = 0; j < (Math.Round(Math.Min((l / 100), (w / 100)), 0)) / 2; j++)
{
    Console.Write("*");
    for (int d = 0; d < Math.Round(Math.Max((l / 100), (w / 100)) - 1, 0); d++)
    {
        Console.Write(" ");
    }
    Console.Write("*");
    Console.WriteLine();
}
for (int j = 0; j < (Math.Round(Math.Max((l / 100), (w / 100)), 0) - c.Length) / 2; j++)
{
    Console.Write("*");
}
Console.Write(c);
for (int j = 0; j < (Math.Round(Math.Max((l / 100), (w / 100)), 0) - c.Length) / 2; j++)
{
    Console.Write("*");
}
Console.WriteLine();

Console.Write("\t{0}\t{1}", nwr, nwr1);
for (int numdraw=0; numdraw<int.Parse(nc); numdraw++) { 
Console.WriteLine();
    for (int j = 0; j < (Math.Round(Math.Max((l / 100), (w / 100)), 0) - c.Length) / 2; j++)
    {
        Console.Write("*");
    }
    Console.Write(c);
    for (int j = 0; j < (Math.Round(Math.Max((l / 100), (w / 100)), 0) - c.Length) / 2; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    for (int j = 0; j < (Math.Round(Math.Min((l / 100), (w / 100)), 0)) / 2; j++)
    {
        Console.Write("*");
        for (int d = 0; d < Math.Round(Math.Max((l / 100), (w / 100)) - 1, 0); d++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        Console.WriteLine();
    }
    for (int j = 0; j < f.Length; j++)
    {
        Console.Write(f[j]);
        for (int d = 0; d < a - 1; d++)
        {
            Console.Write(" ");
        }
        Console.Write(f[j]);
        Console.WriteLine();
    }
    for (int j = 0; j < (Math.Round(Math.Min((l / 100), (w / 100)), 0)) / 2; j++)
    {
        Console.Write("*");
        for (int d = 0; d < Math.Round(Math.Max((l / 100), (w / 100)) - 1, 0); d++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        Console.WriteLine();
    }
    for (int j = 0; j < (Math.Round(Math.Max((l / 100), (w / 100)), 0) - c.Length) / 2; j++)
    {
        Console.Write("*");
    }
    Console.Write(c);
    for (int j = 0; j < (Math.Round(Math.Max((l / 100), (w / 100)), 0) - c.Length) / 2; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int tr = 0; tr < wr.Length; tr++)
{
    nwr += wr[tr];
}
for (int ct = 0; ct < curr.Length; ct++)
{
    nwr1 += curr[ct];
}
for (int g = 0; g < nwr1.Length + 2; g++)
{
    Console.Write("=");
}
Console.WriteLine();
Console.Write("\t{0}", nwr1);
Console.WriteLine();
for (int g = 0; g < nwr1.Length + 2; g++)
{
    Console.Write("=");
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
for (int g = 0; g < a +4; g++)
{
    Console.Write("=");
}
