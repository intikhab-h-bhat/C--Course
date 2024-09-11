
Console.WriteLine("Enter the password");
string password =Console.ReadLine();
Console.WriteLine("Enter the Confirm password");
string confirm=Console.ReadLine();

if(string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm)){
    Console.WriteLine("Enter both password and confirm password");
}
else if(password.Equals(confirm))
{
    Console.WriteLine("Password match");
}
else{
    Console.WriteLine("Password and cionfirm password does not match");
}
