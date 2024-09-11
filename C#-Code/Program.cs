

Console.WriteLine(Add(5,5));

int i= ReadInt("Angle.");
int j= ReadInt("number");

int firstNum=ReadInt("First Number");
int secondNum=ReadInt("Second Number");

int result=Add(firstNum,secondNum);
Console.WriteLine(result);

string name=ReadString("Enter your name");
int age=ReadInt("age");
string details=UserDetails(name,age);
Console.Write(details);

static string UserDetails(string name,int age)
{
    return $" Hello my name is {name} and my age is {age}";
}


static string ReadString(string str){
     Console.WriteLine($"Enter the {str} ");
        return  Console.ReadLine();
}

static int ReadInt(string message){

    Console.WriteLine($"Enter the {message} ");
    int readnNum=Convert.ToInt32(Console.ReadLine());
    return readnNum;
}



static int Add(int a,int b){
    return a + b;
}