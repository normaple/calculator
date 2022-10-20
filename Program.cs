bool loop = true;
Console.WriteLine("Enter a number");
double calc = Convert.ToDouble(Console.ReadLine());
while (loop)
{
    Console.WriteLine("Enter an operator");
    char math_operator = Convert.ToChar(Console.ReadLine());
    if (math_operator == '*')
    {
        Console.WriteLine("Enter a number");
        double number = Convert.ToDouble(Console.ReadLine());
        calc *= number;
    }
    else if (math_operator == '/')
    {
        Console.WriteLine("Enter a number");
        double number = Convert.ToDouble(Console.ReadLine());
        calc /= number;
    }
    else if (math_operator == '+')
    {
        Console.WriteLine("Enter a number");
        double number = Convert.ToDouble(Console.ReadLine());
        calc += number;
    }
    else if (math_operator == '-')
    {
        Console.WriteLine("Enter a number");
        double number = Convert.ToDouble(Console.ReadLine());
        calc -= number;
    }
    else if (math_operator == '=')
    {
        Console.WriteLine(calc);
    } else if (math_operator == 'c')
    {
        calc = 0;
        Console.WriteLine("Enter a number");
        calc = Convert.ToDouble(Console.ReadLine());
    } else if (math_operator == '0')
    {
        loop = false;
    } else
    {
        Console.WriteLine("Error");
        Console.WriteLine("Enter a number");
        calc = Convert.ToDouble(Console.ReadLine());
    }

     

} 
    
    
    




