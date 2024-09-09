// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using EnumSample;

//Console.WriteLine("Enter a number between 1 and 12 to find out corresponding month.");
//int monthNumber = int.Parse(Console.ReadLine());

//string month = Enum.GetName<Months>((Months)monthNumber).ToString();
//string month2 = Enum.GetName(typeof(Months), monthNumber);
//Console.WriteLine($"Month number: {monthNumber}, month: {month}");
//Console.WriteLine($"Month number: {monthNumber}, month: {month2}");

//string[] months = Enum.GetNames(typeof(Months));
//foreach (string m in months)
//{
//    Console.WriteLine(m);
//}

//int[] values = (int[])Enum.GetValues(typeof(Months));
//foreach (int i in values)
//{
//    Console.WriteLine(i);
//}

using EnumSample;

List<string> days = new List<string>(Enum.GetNames(typeof(Days)));
foreach (string day in days)
{
    Console.WriteLine(day);
}

Console.WriteLine(Days.Friday); // Friday
Console.WriteLine(Colors.Black); // Black
Console.WriteLine(EnumExtentions.GetDisplayName(Colors.RedAndYellow)); // EnumExtentions class'ı oluşturacağım
