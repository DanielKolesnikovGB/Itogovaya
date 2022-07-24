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

void FillOSA(string[] ISA, string[] OSA)                     //ISA - входящий массив строк
{                                                            //OSA - исходящий массив строк
    int index = 0;
    for (int i = 0; i < ISA.Length; i++)
    {
        if (ISA[i].Length <= 3)
        {
            OSA[index] = ISA[i];
            index++;
        }
    }
}

//Вывод исходящего массива

void PrintOSA (string[] OSA)                                //OSA - исходящий массив строк
{
    if (OSA[0] == String.Empty)
    {
        Console.Write("Элементов, подходящих для вывода, не обнаружено!");
    }
    else
    {
        for (int i = 0; i < OSA.Length; i++)
        {
            Console.WriteLine("Элемент " + (i+1) + ", подходящий под вывод равен " + OSA[i]);
        }
    }
}

//Блок работы с пользователем