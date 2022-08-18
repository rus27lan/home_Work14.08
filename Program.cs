// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void PrintArray(int rows, int columns) // метод для создания двумерного массива с заполнением случайных чисел
// {
//     int [,] array = new int [rows,columns];
//     Random rnd = new Random();
//     // int rows = array.GetUpperBound(0) + 1; // количество строк
//     // int columns = array.Length / rows; // количество столбцов
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = rnd.Next(-99,99);
//             Console.Write($"{array[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Задайте количество строк : ");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Задайте количество столбцов: ");
// int columns = int.Parse(Console.ReadLine());
// PrintArray(rows,columns);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве, и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// 4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
// 2, 3 -> такой элемент есть и равен 4
// 5, 5 -> такой элемент отсутствует


// void Print(int number , int index , int indexRows , int indexColumns) 
// {
//     int[,] array = new int[,]{ { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
//     int rows = array.GetUpperBound(0) + 1;    // количество строк
//     int columns = array.Length / rows;  //количество столбцов
//     int findNumber = 0;
//     int findIndexRow = 0;
//     int findIndexColumn= 0;
//     int findElement= 0;
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if(number == array[i,j]) findNumber = number;
//             if(index == array[i,j]) 
//             {
//             findIndexRow = i;
//             findIndexColumn = j;
//             Console.WriteLine($"{index} -> такой элемент есть и его индекс равен {findIndexRow}, {findIndexColumn}");
//             }
//             if(indexRows == i & indexColumns == j) findElement = array[i,j];
//         }
//     }
//     if (findNumber > 0) Console.WriteLine($"{number} -> таких чисел в массиве {findNumber}");
//     else Console.WriteLine($"{number} -> такого числа в массиве нет");
//     if(findElement > 0) Console.WriteLine($"{findIndexRow}, {findIndexColumn} ->такой элемент есть и равен {findElement}");
//     else Console.WriteLine($"{findIndexRow}, {findIndexColumn} ->такой элемент отсутствует");
// }
// void PrintArray()
// {
//     int[,] array = new int[,]{ { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
//     int rows = array.GetUpperBound(0) + 1;    // количество строк
//     int columns = array.Length / rows;  //количество столбцов
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write($"{array[i, j]} \t");

//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Какое число будем искать в массиве? ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine("Индекс какого числа нужно найти? ");
// int index = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите индекс для поиска числа");
// Console.WriteLine("строка: ");
// int indexRows = int.Parse(Console.ReadLine());
// Console.WriteLine("столбец: ");
// int indexColumns = int.Parse(Console.ReadLine());
// PrintArray();
// Print(number, index , indexRows, indexColumns);





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2  00 01 02 03
// 5 9 2 3  10 11 12 13
// 8 4 2 4  20 21 22 23
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray() 
{
    int[,] array = new int[,]{ { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.Length / rows;  //количество столбцов
    double sum1 = 0;
    double sum2 = 0;
    double sum3 = 0;
    double sum4 = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} \t");
            if(j == 0) sum1= sum1 + array[i,j];
            if(j == 1) sum2= sum2 + array[i,j];
            if(j == 2) sum3= sum3 + array[i,j];
            if(j == 3) sum4= sum4 + array[i,j];
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: {sum1/rows}; {sum2/rows}; {sum3/rows}; {sum4/rows}.");
}
PrintArray();






// доп задача к 7 семинару. Доделать Тетрис в консоли, плюс сделать функцию для генерации случайной фигуры.