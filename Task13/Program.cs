// int ThirdDigit(int num)
// {
//     int b = x / 100;
//     int a = x % 100;
//     int c = a % 10;
//     int sum = b * 10 + c;

//     return sum;
// }

// int number = new Random().Next(100,999);
// int gtr = IsNumb(number);

// Console.WriteLine(number);
// Console.WriteLine(gtr);


int x = 1645;
int third = -1;
if(x > 99)
{
    third = ((x / 100) % 10);
}
Console.WriteLine(third);