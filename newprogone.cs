//OPERATORS & OPERATOR PRECEDENCE

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Write a program to calculate and output how many toys will be left over after packing the boxes.
        Problem: We  need to pack 142 toys in boxes. Each box holds 15 toys.
        Task: Write a program to calculate and output how many toys will be left after packing.
        */

        //use case of operators
        int toys_left = 142%15;
        Console.WriteLine("Therefore {0} toys will be left",toys_left);

        //operator precedence
        int x = 4 + 3 * 2;
        Console.WriteLine(x);

        //with parenthesis
        int x_paren = (4 + 3) * 2;
        Console.WriteLine(x_paren);

    /* Remember parentheses then multiplication (multiplication, division, modulus) operators
        will be evaluated before addition (addition, subtraction) operators. Operators of equal
        precedence are evaluated from left to right.
    */
    }
}