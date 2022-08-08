void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        
        Console.WriteLine("["+ String.Join(", ", array) +  "]");
        
    }
    Console.WriteLine();

}
Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine());

int[] myArr = new int[n];

    for (int i = 1; i<= myArr.Length; i++)
    {
        Console.Write("Введите элементы массива: ");
        myArr[i-1] = int.Parse(Console.ReadLine());

    }

PrintArray(myArr);
