int RandonDigit( int arg1, int arg2)
{
    int number = new Random().Next(arg1, arg2 + 1);
    return number;
}

int FindSecondDigit (int number)
{
    number = number / 10;
    number = number % 10; 
    return number;
}

int number = RandonDigit(100, 999);
Console.WriteLine(number);
int SecondDigit = FindSecondDigit(number);
Console.WriteLine(SecondDigit);
