void task25()
{
    int a = 5;
    int b = 3;
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);
}
//task25();

void task27()
{
    int number = 18542;
    SumOfDigits(number);
}
void SumOfDigits(int num)
{
    int sum = 0;
    Console.Write("Сумма цифр числа " + num);
    while(num > 0)
    {
        sum += num%10;
        sum /= 10;
    }
    Console.WriteLine(" равна " + sum);
}
//task27();

void task29()
{
    int size = 8;
    int[] array = new int[size];

    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    for(int i = array.Length - 1; i > 0; i--)
    {
        for(int k = 0; k < i; k++)
        {
            if (Math.Abs(array[k]) > Math.Abs(array[k+1]))
            {
                int temp = array[k];
                array[k] = array[k+1];
                array[k+1] = temp;
            }
        }
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
task29();
