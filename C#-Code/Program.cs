// int[] numbers =new int[3];

// for(int i = 0; i < numbers.Length;i++){
//     Console.WriteLine($"Enter the angle {i +1}");
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// }

// int total=0;
// // for(int i = 0;i<numbers.Length;i++){

// //     Console.Write($"{numbers[i]} ");
// //     total=total+numbers[i];
    
// // }
// Console.WriteLine();
// foreach(int i in numbers){
    
//     Console.Write($"{i} ");
//     total=total+i;
// }


// Console.WriteLine(total==180?"Valid":"Invalid");


int[] numbers= new int[] {1,2,3,7,5,8,9};

// foreach(int num in numbers){

// Console.Write(num);
// }

// Array.Sort(numbers);
// Array.Reverse(numbers);
//Array.Clear(numbers, 5, numbers.Length-5);

// for(int i=0 ;i< numbers.Length;i++)
// {
// Console.WriteLine($"{i} ,{numbers[i]}");
// }

Console.WriteLine("Enter the search number");
int searchNum=Convert.ToInt32(Console.ReadLine());
int position=Array.IndexOf(numbers,searchNum);
int position1=Array.IndexOf(numbers,searchNum,2);
int position2=Array.IndexOf(numbers,searchNum,2,2);
Console.WriteLine($"The index of : {position}");
// int position = -1;
// for(int i=0;i<numbers.Length;i++){

//     if(numbers[i]==searchNum){
        
       
//         position=i;
//     }
    
// }
// if(position>-1){
//      Console.WriteLine($"The index of {searchNum} is : {position}");
// }
// else{
//     Console.WriteLine($"Number not found  {position");
// }