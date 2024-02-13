// Задача: Написать программу, которая из имеющегося 
// массива строк формирует новый массив из строк, длина которых 
//меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("введите количество строк / макс количество символов в строке (не менее 5) через ENTER");
(int i, int j) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

char[,] massiv = new char[i, j]; //исходный массив
Random Dlina = new Random(); // случайная длина строки исходного массива
Random Slych = new Random(); // случайные символы в исходный массив  
string[] Stroka = new string[i];  //строки полученне из исходного массива

char[] simbols = "1234567890!@#$%^&*)(}{:<>+_-=?abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); // одномерный массив чаров
int r; int d;

Console.WriteLine();
Console.WriteLine("Строки в которых не более 3 символов : ");
void Fill(char[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        d = Dlina.Next(1, j + 1); // случайная длина i строки
        for (int j = 0; j < d; j++)
        {
            r = Slych.Next(simbols.Length); // случайное значение j элемента
            massiv[i, j] = simbols[r];

            if (d < 4) //макс число символов в строке
            {
                Stroka[i] = Stroka[i] + massiv[i, j];
            }
        }
        Console.WriteLine("Строка" + i + ":  " + Stroka[i]);
    }
}

void Print(char[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write(massiv[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Fill(massiv);

Console.WriteLine();
Console.WriteLine("Исходный массив");
Print(massiv);


