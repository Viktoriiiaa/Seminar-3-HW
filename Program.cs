//Задача 1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
 Console.WriteLine( "Введите пятизначное число " );
 int number = Convert.ToInt32(Console.ReadLine());

     int n1 = number / 10000;
     int n2 = number / 1000%10;
     int n3 =number / 10%10;
     int n4 =number % 10;

 if(number>=10000 && number<100000)
 {
     if(n1 == n4 &&  n2 == n3)
     {
   
         Console.WriteLine("Число " +number+ " является палиндромом ");
     }
     else
     {
         Console.WriteLine("Число " +number+ "  не является палиндромом ");
     }
 }
 else
 {
     Console.WriteLine("Это не пятизначное число");
 }
 */


//Задача 2
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//AB = √(xb - xa)^2 + (yb - ya)^2 + (zb - za)^2 
/*
double Distance(int xa, int xb, int ya, int yb, int za, int zb){
    double ab = Math.Sqrt(((xb-xa)*(xb-xa)) + ((yb-ya)*(yb-ya)) + ((zb - za)));
    return ab;
}

Console.Write("Введите xa: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите xb: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ya: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите yb: ");
int n4 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите za: ");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите zb: ");
int n6 = Convert.ToInt32(Console.ReadLine());
double result = Distance(n1, n2, n3, n4, n5, n6); 
Console.Write($"Расстояние между точками ({n1}, {n3}, {n5} и {n2}, {n4}, {n6}) равно {result}");
*/


//Задача 3 
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void TableOfSquares(int n){
    for (int i = 1; i<=n; i++){
        Console.Write($"{i*i*i} ");
    }
}

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
TableOfSquares(n);
*/ 