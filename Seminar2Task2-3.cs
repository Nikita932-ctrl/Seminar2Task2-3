
//Найти 3 цифру слева в семизначном числе 
int thirdNumberLeft (int number)
{
    if (number >= 1000000 && number <= 9999999)
    {
        number = number / 10000;
        number = number % 10;
    }
    else if (number < 99)
    {
        Console.WriteLine($"В числе {number} нет 3 цифры ");
    }
    else if (number >= 100 && number < 999)
    {
        number = number % 10;
    }
    else if(number >= 1000 && number < 9999) {
        number = number % 100;
        number = number / 10;
    }
    else if (number >= 10000 && number < 99999)
    {
        number = number / 100;
        number = number % 10;
    }
    else if (number >= 100000 && number < 999999 )
    {
        number = number / 1000;
        number = number % 10;

    }
    return number;
}

Console.WriteLine(thirdNumberLeft(1203855)) ;


// найти 3 цифру справа в семизначном числе 

int thirdNumberRight (int number)
{
    if (number >= 1000000 && number <= 9999999)
    {
        number = number % 1000;
        number = number / 100;
    }
    else if (number >= 100000 && number < 999999)
    {
        
        number = number % 10;
    }
    else if (number > 0 && number <=99999)
    {
        Console.WriteLine($"В числе {number} нет 3 справа цифры ");
    }
    return number;
}

Console.WriteLine(thirdNumberRight(12));