#region Task1
string greets(string name)
{
    return name;
}

Console.Write("Enter your full name: ");
string name = Console.ReadLine();
Console.WriteLine("\nGreetings " + greets(name));
#endregion
Console.WriteLine("\n____________________________\n");
#region Task2
float volume(float length, float width, float height)
{
    float vol = length * width * height;
    return vol;
}

Console.Write("Enter length: ");
float length = float.Parse(Console.ReadLine());

Console.Write("Enter width: ");
float width = float.Parse(Console.ReadLine());

Console.Write("Enter height: ");
float height = float.Parse(Console.ReadLine());

Console.WriteLine("\nVolume of a box is: " + volume(length, width, height));
#endregion
Console.WriteLine("\n____________________________\n");
#region Task3
double take(double num)
{
    double lol;
    if (num % 2 == 0)
    {
        lol = num * 2;
        return lol;
    }
    else if (num % 2 == 1)
    {
        lol = Math.Pow(num, 2);
        return lol;
    }
    else return 1;
}

Console.Write("Enter a number: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nFinal result: " + take(num));
#endregion
Console.WriteLine("\n____________________________\n");
#region Task4
float convert(float celNum)
{
    float res = (celNum * 9 / 5) + 32;
    return res;
}

Console.Write("Enter the temperature in Celsius °C: ");
float celNum = float.Parse(Console.ReadLine());

Console.WriteLine("\nTemperature in Fahrenheit: " + convert(celNum) + " °F");
#endregion
Console.WriteLine("\n____________________________\n");
#region Task5
char determine(char ch)
{
    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
    {
        return ch = 'v';
    }
    else if (!(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') && Char.IsLetter(ch))
    {
        return ch = 'c';
    }
    else return ch = 'n';
}

Console.Write("Enter a letter: ");
char ch = Convert.ToChar(Console.ReadLine());

char res = determine(ch);
if (res == 'v')
{
    Console.WriteLine("\nThe letter you've entered '" + ch + "' is a vowel!");
}

else if (res == 'c')
{
    Console.WriteLine("\nThe letter you've entered '" + ch + "' is a consonant!");
}
else if (res == 'n')
{
    Console.WriteLine("\nThe letter you've entered '" + ch + "' Not a letter or you wrote more than one letter!");
}
#endregion
Console.WriteLine("\n____________________________\n");
#region Task6
decimal converted(decimal amount)
{
    amount *= 0.31m;
    return amount;
}

Console.Write("Enter an amount in USD: ");
decimal amount = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\nThe amount in Kuwaiti Dinar= " + converted(amount)+" KWD");
#endregion