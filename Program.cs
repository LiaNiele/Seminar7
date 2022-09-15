// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray(int m, int n){               //создаем массив из случайных чисел
    double[,] array = new double[m,n];
    for(int i = 0; i<m; i++)
        for(int j =0; j<n; j++)
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
    return array;
}

void Show2dArray(double[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input numb of m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArray(m,n);
Show2dArray(array);



// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int cols){
    int[,] array = new int[rows,cols];
    for(int i = 0; i<rows; i++)
        for(int j =0; j<cols; j++)
            array[i,j] = new Random().Next(0, 10);
    return array;
}

void Show2dArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void Position(int[,] array){
    Console.Write("Введите индекс строки: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int pos = 0;
        for(int i = 0; i<array.GetLength(0); i++){
            for(int j = 0; j<array.GetLength(1); j++){ 
            
                if(i == m && j == n){                            //проверяем есть ли в массиве элемент с индексами m,n
                    pos = array[i,j];
                    Console.WriteLine("Значение: "+ pos);
                }
            }
        }
    if(pos == 0) Console.WriteLine("Значение не существует");
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows,cols);
Show2dArray(array);
Position(array);


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int cols){             //задаем массив со значениями от 0 до 10
    int[,] array = new int[rows,cols];
    for(int i = 0; i<rows; i++)
        for(int j =0; j<cols; j++)
            array[i,j] = new Random().Next(0, 10);
    return array;
}

void Show2dArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows,cols);
Show2dArray(array);

Console.Write("Среднее арифметическое каждого столбца: ");
    
    for(int j = 0; j<array.GetLength(1); j++){                  
        double sum = 0;
        double aver = 0;
        for(int i = 0; i<array.GetLength(0); i++){            // находим сумму значений каждого столбца
            sum += array[i,j];
        }
        aver = sum/array.GetLength(0);                        // находим среднее арифметическое столбца
        Console.Write(aver + "; ");
    }

