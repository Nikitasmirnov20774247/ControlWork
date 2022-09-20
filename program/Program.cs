string[] array = {"man", "bike", "-45", "^-^", "machine", "1", "truffle", "pet", "hello", "ton", "world", "32"};
string[] newArray = new string[array.Length];
int size = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        newArray[size] = array[i];
        size++;
    }
}

void WriteArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < size - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
}

WriteArray(newArray);