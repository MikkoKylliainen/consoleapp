// See https://aka.ms/new-console-template for more information
int age;
string fname;
int byear;

Console.WriteLine("Name?");
fname=Console.ReadLine();

Console.WriteLine("Hello "+fname);

Console.WriteLine("jotain");

int.TryParse(Console.ReadLine(), out age);

byear=2022-age;
Console.WriteLine("yea " +byear);