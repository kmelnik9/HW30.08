//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int[] array = {1,2,8,2,1};
    if (array[0]==array[4] && array[1]==array[3])
    {
        System.Console.WriteLine("да");
    }
    else {
        System.Console.WriteLine("нет");
    }

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance (int XA, int YA, int ZA, int XB, int YB, int ZB)
{
        return Math.Round(Math.Sqrt(Math.Pow((XB-XA),2)+Math.Pow((YB-YA),2)+Math.Pow((ZB-ZA),2)),2);
}
System.Console.WriteLine(Distance (7, -5, 0, 1, -1, 9));

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int N)
{
    int i = 1;
    double D = 1;
    while (i<=N){
        D = Math.Pow(i,3);
        System.Console.WriteLine(D);
        i++;
    }
}

Cube (5);