//Assignment and Compound Assignment Operators
class Program
{
    static void Main(string[] args)
    {
        int x = 42;  //assignment operator
        Console.WriteLine(x);
        x += 2; // compound assignment operator
        Console.WriteLine(x);
        x -= 6; //equivalent to x = x - 6
        Console.WriteLine(x);

        x *= 8; // equivalent to x = x * 8
        Console.WriteLine(x);
        x /= 5; // equivalent to x = x / 5
        Console.WriteLine(x);
        x %= 2; // equivalent to x = x % 2
        Console.WriteLine(x);


//Increment Operator
        int y = 10;
        y++;
        Console.WriteLine(y);


//Prefix & Postfix Forms
        int z = 15;
        int a = ++z;
        Console.WriteLine("z = "+z+" "+"a = "+a); // z = 16  a = 16

        z = 15;
        a = z++;
        Console.WriteLine("z = "+z+" "+"a = "+a); // z = 16  a = 15

/*
    Prefix increments the value, and then proceeds with the expression.
    Postfix evaluates the expression and then performs the incrementing.
*/

//Decrement Operator
//it decrements the value by one

        --z;
        Console.WriteLine("--z is "+z);
        z--;
        Console.WriteLine("z-- is "+z);

//The decrement operator (--) works in much the same way as the increment operator.

    }
}