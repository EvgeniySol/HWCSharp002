string Week(int num)
{
   if(num == 1 || num == 2 || num ==3 || num == 4 || num == 5) return ("No");
   else if(num == 6 || num == 7) return ("Yes");
   else return ("There is no such day of the week!");
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = Week(number);

Console.WriteLine(result);
