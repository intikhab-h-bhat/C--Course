// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstName="   Intikhab";
string lastName="Bhat         ";
lastName=lastName.Replace(lastName,"Hussain Bhat");
Console.WriteLine($"My full name is {firstName.TrimStart()}  {lastName.TrimEnd()}");