// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

/*

void Func(double x1, double y1, double x2, double y2){
double dlinna = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine(dlinna);
}

Console.WriteLine("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Func(x1, y1, x2, y2);

*/    

//-----------------------------------------------------------------------------------------------

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


/*

Console.WriteLine("Введите число или слово для его проверки на полиндром: ");
string text_orig = Console.ReadLine();              //посмотрел несколько вариантов проверок, этот показался самым простым и понятным, максимально разобрался в происходящем и постиг новые возможности))
char [] text_v_massive = text_orig.ToCharArray();   //создаем из строки массив символов
Array.Reverse(text_v_massive);                      //разворачиваем массив с#фичей 
string text_naoborot = new string(text_v_massive);  //развернутый массив обратно в строку
if (text_orig == text_naoborot)                     //сравниваем текст введенный и второй который прошел путь строка-массив-разворот-строка
	Console.WriteLine("Предоставленый текст является палиндромом.");
else 
	Console.WriteLine("Предоставленый текст не является палиндромом.");

*/


//------------------------------------------------------------------------------------

//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*

void Func(double x1, double y1, double x2, double y2, double z1, double z2){
double dlinna = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(dlinna);
}

Console.WriteLine("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Func(x1, y1, x2, y2, z1, z2);

*/

//--------------------------------------------------------------------------------------------

//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

/* 

void Qube (double n){
    int curr = 1;
    Console.WriteLine("Значения кубов всех чисел от 1 до " +n);
    while(curr<=n){
        Console.Write(Math.Pow(curr, 3) + "   ");    
        curr++;
}
}            
Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
if (num <= 0) Console.Write("Введите значение больше нуля.");
else Qube(num);

*/
          