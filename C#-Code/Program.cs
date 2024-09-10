// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.IO.Compression;

Console.WriteLine("Welcome To C#!");

//switch statement

// Console.WriteLine("Enter the text yoyu want to repeat:");
// string message= Console.ReadLine(); 

// Console.WriteLine("How many times you want to repeat the text");
// int count=Convert.ToInt32(Console.ReadLine());

// if(count==0){
//     Console.WriteLine("Enter the value greater than 0");
// }
// else
// {
//     for(int i=0; i<count;i++)
//     {
//     Console.WriteLine(i);
//     Console.WriteLine(message);
//     }  
// }

//While loop
// Console.WriteLine("Enter the number");
// int j=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("");
// while(j==7){
//     Console.WriteLine("Hello");
// }

//Do while
// int k=5;
// int z=7;
// do{
// Console.WriteLine("Welcome");
// k++;
// }while(k<z);

//Conditional operator
// int age = Convert.ToInt32(Console.ReadLine());
// string result=age>0? "Valid":"InValid";
// Console.WriteLine(result);

//Number format
// double x=-10D/3D;
// Console.WriteLine(string.Format("10$/3$ is ${0:0}",x));
// Console.WriteLine(string.Format("{0:0.0}",x));
// Console.WriteLine(string.Format("{0:0.00}",x));
// Console.WriteLine(x.ToString("C"));
// Console.WriteLine(x.ToString("C1"));
// Console.WriteLine(x.ToString("C2"));
// Console.WriteLine(x.ToString("C2"));
// Console.WriteLine(x.ToString("C",CultureInfo.CreateSpecificCulture("en-GB")));


// using  Tryparse

bool success = true;
while (success){
string x = Console.ReadLine();


if(int.TryParse(x, out int num)){
   
   success=false;
    Console.WriteLine(num);
}
else{
    Console.WriteLine("Failed to convert");
}

}


