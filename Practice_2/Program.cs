
//Задание 2. Поиск максимального и минимального элемента массива

//Напиши программу, которая:

//-Запрашивает у пользователя размер массива (целое положительное число).
//- Вводит элементы массива (целые числа).
//- Находит и выводит максимальный и минимальный элементы массива.

//Требования:

//-Использовать массив для хранения элементов.
//- Использовать цикл для ввода элементов.
//- Выделить в отдельные методы поиск максимума и минимума.
//- Обработать ошибку ввода размера массива (если введено число меньше 1).

int lenghtMass = 0;

while (lenghtMass <= 0)
{
    Console.Write("Введите длину масива: ");
    lenghtMass = Convert.ToInt32(Console.ReadLine());
    if (lenghtMass < 0)
    {
        Console.WriteLine("Ошибка ввода");
    }
}

int[] mass = new int[lenghtMass];

for (int i = 0; i < lenghtMass; i++)
{
    Console.Write($"Введите число элемента {i + 1}:");
    mass[i] = Convert.ToInt32(Console.ReadLine());
}


for (int i = 0; i < lenghtMass - 1; i++)
{
    for (int j = 0; j < lenghtMass - i - 1; j++)
    {
        if (mass[j] > mass[j + 1])
        {
            int x = mass[j];
            mass[j] = mass[j + 1];
            mass[j + 1] = x;
        }
    }


}

Console.WriteLine($"Минимальное значение массива: {mass[0]}");
Console.WriteLine($"Максимальное значение массива: {mass[lenghtMass-1]}");


