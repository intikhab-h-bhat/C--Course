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


// Console.WriteLine("Enter the number");
// int num =Convert.ToInt32(Console.ReadLine());

// for (int i = 1;i<=10;i++){
//    // Console.WriteLine(Convert.ToString(num) + " x " + Convert.ToString(i)+ " = " + Convert.ToString(num*i));
// Console.WriteLine("{0} X {1} = {2}",num,i,num*i);

// }

//Fiz Buzz

// bool threeDiv=false;
// bool fiveDiv=false;
// for(int i = 1;i<=15;i++){

//     threeDiv=(i%3==0);
//     fiveDiv=(i%5==0); 

//     if(threeDiv && fiveDiv)
//     {
//         Console.WriteLine("FizBuzz");
//     }
//     else if(threeDiv) {
//         Console.WriteLine("Fizz");
//     }
//     else if (fiveDiv) {
//         Console.WriteLine("Buzz");
//     }
//     else {
//         Console.WriteLine(i);
//     }
// }

// string interpolation and conacatination
// string[] names={"A ", "B ", "C ",};
// var contcatNames=string.Concat(names);
// Console.WriteLine(contcatNames);

// Console.WriteLine("Enter your name");
// string name=Console.ReadLine();

// if(!name.Equals(string.Empty))
// {
//     Console.WriteLine($"Your name is : {name}");

// }
// else{
//     Console.WriteLine("You did nnot enter any thing");
// }

string x="Hello";
string y="Hello";
Console.WriteLine(x.Equals(y));