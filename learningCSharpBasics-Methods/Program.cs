// C# basics

// ** METHODS ** //

// a method (aka function) is a block fo code which only runs when its called
// use a method if I want to resue code multiple times
// predefined method main

using System.Security.Cryptography.X509Certificates;

class Program
{
    //static void main(string[] args)
    //{
    //    Console.WriteLine("hi");
    //}

    // create own method. Must begin with a CAPITAL letter
    // 'static' means that the method belongs to the Program class and not an object of the Program class
    // void means the methods doesn't have to return a value
    static void MyMainMethod()
    {
        Console.WriteLine("Bonjour");
    }

    // how to call a method
    static void AMethod()
    {
        Console.WriteLine("I love cats");
    }
    //static void Main(string[] args)
    //{
    //    AMethod();
    //}

    // passing parameters/varaibles inside a method
    // fname is a paramter
    static void MyFamily(string fName)
    {
        Console.WriteLine(fName + " Smith");
    }
    /*static void Main(string[] args)
    {
        Console.WriteLine("Kyle");      // "kyle", "Greg" and "Neve" are arguments
        Console.WriteLine("Greg");
        Console.WriteLine("Neve");
    }*/


    // Multiple parameters
    // arguments must be passed in the same order
    static void TheFamily(string fName, string relation, int ages)
    {
        Console.WriteLine(fName + " is my " + relation + " and they are " + ages + " years old");
    }
    /*static void Main(String[] args)
    {
        TheFamily("Harry", "cousin", 34);
        TheFamily("Violet", "antie", 56);
        TheFamily("Manilla", "sister", 12);
    } */

    // Dafault Parameter value
    // if you dont call an argument then the method uses the default parameter 'No name and 'Meat + fish'.
    static void MealChoice(string fName = "No name", string meal = "Meat and fish")
    {
        Console.WriteLine(fName + " would like a " + meal + " meal");
    }
    /* static void Main(string[] args)
    {
        MealChoice("Darius", "Vegan");
        MealChoice("Maya", "Meat and Fish");
        MealChoice();
        MealChoice("Emily", "Vegaterian");
    } */

    // Return Values
    // if we want the method to return a value we must call a data tyle insetad of using 'void'
    static int AddMethod(int x, int y)      // use int instead void
    {
        return x + y + 7;
    }
    /*  static void Main(string[] args)
    {
        int z = AddMethod(1, 2);            // storing the result in a variable makes it eas
        Console.WriteLine(z);
    } */


    // Named Arguments
    // send arguments with the key: value, that way the order of the arguments doesn't matter
    static void MyChildren(string child1, string child2, string child3)
    {
        Console.WriteLine("the youngest child is: " + child3);
    }
    /* static void Main(string[] args)
    {
        MyChildren(child3: "Will", child1: "Bill", child2: "Jordan");
    } */


    // Method Overloading
    // multiple methods can have the same name with different parameters
    static int AMethod(int x, int y)
    {
        return x * y;
    }
    static double AMethod(double x, double y) 
    {
        return x + y;
    }
    static void Main(string[] args)
    {
        int myNum1 = AMethod(1, 2);
        double myNum2 = AMethod(1.1, 2.1);
        Console.WriteLine(myNum1);
        Console.WriteLine(myNum2);
    }





}


