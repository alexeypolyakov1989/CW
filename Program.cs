
textTask();
string[] arrayInput = GetArrayStringRandom(); 
int len = arrayInput.Length; 
int quantity = 0; 
quantity = lengthArrayOutput(arrayInput); 
string[] arrayOutput = new string[quantity]; 
arrayOutput = FillArray(arrayInput, arrayOutput); 
Console.Write($"Имеющийся массив из {arrayInput.Length} строк");
if (arrayInput.Length % 10 == 1 && arrayInput.Length != 11) Console.Write("и");
Console.WriteLine(":\n");
PrintArray(arrayInput);
if (arrayOutput.Length != 0) 
    {
        Console.Write($"Сформирован массив из {arrayOutput.Length} строк");
        if (arrayOutput.Length % 10 == 1 && arrayOutput.Length != 11) Console.Write("и");
        Console.Write(" c длиной, меньшей либо равной 3:\n"); 
        PrintArray(arrayOutput);
    }
else Console.WriteLine("[] \n\nСтрок, длина которых меньше либо равна 3, нет. "); 
Console.WriteLine("\n"); Console.ReadKey();

string[] GetArrayStringRandom() 
{
    Random random = new Random();
    int lengthArray = random.Next(1, 101); 
    string[] array = new string[lengthArray];
    for (int i = 0; i < lengthArray; i++)
    {
        string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#$%&'()*+,-\"./:;<=>?@[]^_'{|}~";
        
        int lengthString = random.Next(1, 21);
        for (int j = 0; j < lengthString; j++)
        {
            int numberSymbol = random.Next(0, symbols.Length -1);
            array[i] = array[i] + symbols.Substring(numberSymbol, 1);
        }
    }
    return array;
}

int lengthArrayOutput (string[] array) 
{   
    int counter = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++) 
        if (array[i].Length <= 3) counter++;
    return counter;
}

string[] FillArray(string[] array1, string[] array2) 
{
    int size = array1.Length;
    int i = 0;
    int j = 0;
    while (i < size)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
        i++;
    }
    return array2;
}

void PrintArray (string[] matrix) 
{Console.Write("[");
    for (int i = 0; i < matrix.Length; i++)
        {
        Console.Write($"\"{matrix[i]}\"");
         if (i == matrix.Length - 1) Console.Write("]");
                else Console.Write(", ");
        }
        Console.WriteLine("\n");
}

void textTask() 
{
    Console.WriteLine(
        "\nЗадача: Написать программу, которая из имеющегося массива строк"
        + "\nформирует массив из строк, длина которых меньше либо равна 3 символам.\n"); 
}
