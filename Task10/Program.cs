int IsNumb(int num)
{
    int a = num % 100;
    int b = a /10;

    return b;
}

int number = new Random().Next(100,999);
int result = IsNumb(number);

Console.WriteLine(number);
Console.WriteLine(result);
