using System;

class Nullable
{

    // Main Method
    static void Main(string[] args)
    {

        // defining Nullable type
        Console.WriteLine("Nullable Value is ");
        Nullable<int> n = null;

        // using the method
        // output will be 0 as default
        // value of null is 0
        Console.WriteLine(n.GetValueOrDefault());

        // defining Nullable type
        Console.WriteLine("Nullable Value is ");
        int? n1 = null;

        // using the method
        // output will be 0 as default
        // value of null is 0
        Console.WriteLine(n1.GetValueOrDefault());


        // using Nullable type syntax
        // to define non-nullable
        Console.WriteLine("NonNullable Value is ");
        int? n2 = 44;

        // using the method
        Console.WriteLine(n2.GetValueOrDefault());

        // using Nullable type syntax
        // to define non-nullable
        Console.WriteLine("NonNullable Value is ");
        Nullable<int> n3 = 458;
        // using the method
        Console.WriteLine(n3.GetValueOrDefault());

    }

}