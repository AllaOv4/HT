/*/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*int Degree(int A, int B)
  {
    int i=1;
    int result = 1;
    while(i<=B) 
    {
    result = result*A;
    i++;
    }

    return result;
    
  }
Console.Write("Input number A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B ");
int numberB = Convert.ToInt32(Console.ReadLine());
int x= Degree (numberA, numberB);
Console.WriteLine($" A to the degree of B is {x}");*/


/*double FindDegree(double A, double B)
{
    return Math.Pow(A,B);
}
Console.WriteLine("Input number A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input number B: ");
double B = Convert.ToDouble(Console.ReadLine());
double i= FindDegree(A,B);
Console.WriteLine($" The degree {i}");*/


//Задача 27: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*

int Sum (int num)
{
int ed;
int sum=0;

while(num>0)
{
ed=num%10;
sum=sum+ed;
num/=10;
}
return sum;

}

Console.Write (" Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = Sum(number);
Console.WriteLine($" The sum of numbers is {x}");*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*int[] CrateArray()
{
  
  Console.WriteLine("Input size of the array: ");
  int size = Convert.ToInt32(Console.ReadLine());
  int[] newArray = new int[size];
  
  for (int i =0; i<size; i++)
  {
    Console.WriteLine($" Input number {i+1}");
    newArray [i]= Convert.ToInt32(Console.ReadLine());
  }
  return newArray;
}
void ShowArray(int[]array)
{
  for (int i=0; i<array.Length; i++)
  Console.Write(array[i]+" ");
  Console.WriteLine();
}

ShowArray(CrateArray());*/