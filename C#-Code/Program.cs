int num=7;
int length=5;
int[] numbers=new int[length];

for(int i=1;i<=length; i++) {

    numbers[i-1]=i*num;
}

for(int i=0;i<length;i++)
{
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();
foreach(int i in numbers) {
    Console.Write($"{i} ");
}