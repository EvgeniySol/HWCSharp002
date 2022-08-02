string ThirdDigit(int num)
 {

     if(num < 100) return ("There is no third digit.");
    
 }

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = ThirdDigit(number);

Console.WriteLine(result);