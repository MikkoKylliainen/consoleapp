// See https://aka.ms/new-console-template for more information
int age;
string fname;
int byear;

Console.WriteLine("Name?");
fname=Console.ReadLine();

Console.WriteLine("Hello "+fname);

Console.WriteLine("jotain");

//int.TryParse(Console.ReadLine(), out age);

try {
    age=int.Parse(Console.ReadLine());
    byear=2022-age;
    Console.WriteLine("yea " +byear);    
}
catch (System.Exception){
    Console.WriteLine("numbah please");
}
