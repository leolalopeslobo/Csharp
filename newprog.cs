//Implicitly declaring variables using the 'var' keyword

internal class Program
{
    private static void Main(string[] args)
    {
        var num = 12;
        Console.WriteLine(num);

    //Note: Implicitly typed variables must be initialized with a value.
    /*
        the code will give an ERROR
        var isOnline;
        isOnline = true;
    */

    //Constants store a value that cannot be changed from their intial assignment
    const double PI = 3.14;
    Console.Write(PI);

    /*
    The value of const PI cannot be changed during program execution.
    Just like 'var' values, 'const' values must be initialised with a value when declared.
    */
    }
}