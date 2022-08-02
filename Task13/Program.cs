// string ThirdDigit(int num)
//  {
//      int b = x / 100;
//      int a = x % 100;
//      int c = a % 10;
//      int sum = b * 10 + c;

//     return sum;
//  }

// int number = new Random().Next(100,999);
// int gtr = IsNumb(number);

// Console.WriteLine(number);
// Console.WriteLine(gtr);


int x = 6;
//string third = GetSecondDigit(x);
string str = x.ToString();
Console.WriteLine(str[2]);
//Console.WriteLine(third);