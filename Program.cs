//Блок главной подзадачи (см. README.md)

//Заполнение входящего массива строк

void FillISA (string[] ISA)                                 //ISA - входящий массив строк
{
    for (int i = 0; i < ISA.Length; i++)
    {
        Console.Write("Введите строку " + (i + 1) + ": ");
        string Str = Console.ReadLine();
        ISA[i] = Str;
    }
}

//Определение кол-ва элементов в исходящем масиве строк

int ElementCountingInISAForOSA (string[] ISA)                //ISA - входящий массив строк
{                                                            //OSA - исходящий массив строк
    int count = 0;                                           //count - переменная для определения кол-ва элементов в исходящем массиве строк
    for (int i = 0; i < ISA.Length; i++)
    {
        for (int index = 0; ISA[index].Length <= 3; index++)
        {
            count++;
        }
    }
    return count;
}

//Заполнение исходящего массива строк

//Вывод исходящего массива

//Блок работы с пользователем