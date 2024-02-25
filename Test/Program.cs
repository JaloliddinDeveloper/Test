using Test.Classes;

Console.WriteLine("Ismingizni kiriting: ");
string name=Console.ReadLine();
Console.WriteLine("Tug'ilgan Yilingiz: ");
int birthYear=int.Parse(Console.ReadLine());

var redonly=new Redonly(name,birthYear);

redonly.OutName();
redonly.CalculateAge(birthYear);
redonly.OutAge();


