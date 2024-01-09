using Microsoft.VisualBasic;
using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security;

class CodingChallenges
{

    static void Main(string[] args)
    {
        Project();
    }

    static void Project()
    {
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Hello my name is Andy and today I have a variety of programs for you to choose from.");
            Console.WriteLine("Please insert an integer between 1 and 26 to begin the program, or press 0 to exit.");
            Console.WriteLine("[1] - Sum (Add two numbers)");
            Console.WriteLine("[2] - Convert (minutes into seconds)");
            Console.WriteLine("[3] - PlusOne (Takes a number and adds one)");
            Console.WriteLine("[4] - CircuitPower (Returns power with voltage and current)");
            Console.WriteLine("[5] - CalcAge (Converts years to days)");
            Console.WriteLine("[6] - triArea (Provides area through base and height)");
            Console.WriteLine("[7] - lessThanOrEqualToZero ('Is a number...?')");
            Console.WriteLine("[8] - lessThan100 ('Is the sum of two numbers...?)");
            Console.WriteLine("[9] - IsEqual (Determines if two integers are equal)");
            Console.WriteLine("[10] - GiveMeSomething (Returns 'something' and the argument)");
            Console.WriteLine("[11] - Reverse (Reverses a boolean value)");
            Console.WriteLine("[12] - howManySeconds (Converts hours to seconds)");
            Console.WriteLine("[13] - SumPolygon (The sum of internal angles of a _ sided polygon)");
            Console.WriteLine("[14] - nameString (_Edabbit)");
            Console.WriteLine("[15] - And (Returns true if both values are true)");
            Console.WriteLine("[16] - Points (Total worth of given 3 pointers and 2 pointers)");
            Console.WriteLine("[17] - FindPerimeter (Adds lengths and widths of a rectangle)");
            Console.WriteLine("[18] - HelloName (Hello _)");
            Console.WriteLine("[19] - animals (Sum of legs of given chickens, cows, and pigs)");
            Console.WriteLine("[20] - FootballPoints(Points from winds, draws, and losses)");
            Console.WriteLine("[21] - MonthName (Select a month with an integer)");
            Console.WriteLine("[22] - FindMinMax (Find minimum and xaximum values of an array)");
            Console.WriteLine("[23] - getAbsSum (Sum of the absolute value of each integer)");
            Console.WriteLine("[24] - CaluculateExponent (Calculates a base with an exponent)");
            Console.WriteLine("[25] - MultiplyByLength (Multiplies all values in the array by length)");
            Console.WriteLine("[26] - HammingDistance (Computes the number of differing characters between two strings)");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Challenge1();
                    break;
                case 2:
                    Challenge2();
                    break;
                case 3:
                    Challenge3();
                    break;
                case 4:
                    Challenge4();
                    break;
                case 5:
                    Challenge5();
                    break;
                case 6:
                    Challenge6();
                    break;
                case 7:
                    Challenge7();
                    break;
                case 8:
                    Challenge8();
                    break;
                case 9:
                    Challenge9();
                    break;
                case 10:
                    Challenge10();
                    break;
                case 11:
                    Challenge11();
                    break;
                case 12:
                    Challenge12();
                    break;
                case 13:
                    Challenge13();
                    break;
                case 14:
                    Challenge14();
                    break;
                case 15:
                    Challenge15();
                    break;
                case 16:
                    Challenge16();
                    break;
                case 17:
                    Challenge17();
                    break;
                case 18:
                    Challenge18();
                    break;
                case 19:
                    Challenge19();
                    break;
                case 20:
                    Challenge20();
                    break;
                case 21:
                    Challenge21();
                    break;
                case 22:
                    Challenge22();
                    break;
                case 23:
                    Challenge23();
                    break;
                case 24:
                    Challenge24();
                    break;
                case 25:
                    Challenge25();
                    break;
                case 26:
                    Challenge26();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please insert an acceptable choice.");
                    break;
            }

        }
    }    
        
        
    static void Challenge1()
    {
        //Challenge 1
        Console.WriteLine("What is the first number?");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the second number?");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of those two numbers is " + Sum(first, second));
    }

    static void Challenge2()
    {
        //Challenge 2
        Console.WriteLine("How many minutes would you like to convert to seconds?");
        int minutes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("In that amount of minutes there are " + ToSec(minutes) + " seconds");
    }

    static void Challenge3()
    {
        //Challenge 3
        Console.WriteLine("What is your original number?");
        int oops = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("When that number increases by 1, we get " + PlusOne(oops));
    }

    static void Challenge4()
    {
        //Challenge 4
        Console.WriteLine("What is the voltage of your circuit?");
        int voltage = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the current of your circuit?");
        int current = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The current Circuit Power is at " + Breaker(voltage, current) + " Watts");
    }

    static void Challenge5()
    {
        //Challenge 5
        Console.WriteLine("How old am I, creator?");
        int five = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("I'm " + five + " years old, meaning that I am also " + Age(five) + " days old");
    }


    static void Challenge6()
    {
        //Challenge 6
        Console.WriteLine("How long is the bottom of your triange?");
        int six = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How tall is your triange?");
        int seven = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The area of your triangle is " + triArea(six, seven) + " inches squared");
    }
    static void Challenge7()
    {
        //Challenge 7
        Console.WriteLine("Insert a value");
        int eight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("This is " + lessThanOrEqualToZero(eight));
    }
    static void Challenge8()
    {
        //Challenge 8
        Console.WriteLine("Insert the first value");
        int nine = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert the second value");
        int ten = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("This is " + lessThan100(nine, ten));
    }
    static void Challenge9()
    {
        //Challenge 9
        Console.WriteLine("We are to determine whether or not a statement is true depending on if you input the same two numbers.");
        Console.WriteLine("Insert a number");
        int eleven = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert the same number");
        int twelve = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("This statement is " + IsEqual(eleven, twelve));
    }
    static void Challenge10()
    {
        //Challenge 10
        Console.WriteLine("Give me something");
        string a = Console.ReadLine();
        Console.WriteLine(GiveMeSomething(a));
    }
    static void Challenge11()
    {
        //Challenge 11
        Console.WriteLine("Is this true or false?");
        bool a = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("It's actually " + Reverse(a));
        Console.WriteLine("What is it now?");
        bool b = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("It's " + Reverse(b) + "....");
    }
    static void Challenge12()
    {
        //Challenge 12
        Console.WriteLine("If you tell me a number of hours, I'll tell you how long that is in seconds!");
        int thirteen = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("There are " + howManySeconds(thirteen) + " seconds in that many hours.");
    }
    static void Challenge13()
    {
        //Challenge 13
        Console.WriteLine("How many sides does your polygon have?");
        int fourteen = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of the angles of your polygon is " + SumPolygon(fourteen) + " degrees.");
    }
    static void Challenge14()
    {
        //Challenge 14
        Console.WriteLine("Give me your name");
        string b = Console.ReadLine();
        Console.WriteLine(nameString(b));
    }
    static void Challenge15()
    {
        //Challenge 15
        Console.WriteLine("Is this true?");
        bool c = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Then this must be true too?");
        bool d = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("It's " + And(c, d));
    }
    static void Challenge16()
    {
        //Challenge 16
        Console.WriteLine("How many three pointers were scored?");
        int fifteen = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("And how many two pointerss were scored?");
        int sixteen = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Then they scored a total of " + Points(fifteen, sixteen) + " points");
    }
    static void Challenge17()
    {
        //Challenge 17
        Console.WriteLine("What is the length of your rectangle?");
        int seventeen = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("And what is its width?");
        int eighteen = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Then the perimeter is " + FindPerimeter(seventeen, eighteen) + " units");
    }
    static void Challenge18()
    {
        //Challenge 18
        Console.WriteLine("Could I get your name again?");
        string c = Console.ReadLine();
        Console.WriteLine(HelloName(c));
    }
    static void Challenge19()
    {
        //Challenge 19
        Console.WriteLine("How many chickens do you have?");
        int nineteen = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("And how many cows do you have?");
        int twenty = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("And your pigs?");
        int twentyone = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Then all your animals together have " + animals(nineteen, twenty, twentyone) + " legs!");
        Console.WriteLine("Why're you looking at me like that?");
    }
    static void Challenge20()
    {
        //Challenge 20
        Console.WriteLine("How many wins does your team have?");
        int twentytwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("And how many draws does your team have?");
        int twentythree = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("And your team's losses?");
        int twentyfour = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Then your team has obtained " + FootballPoints(twentytwo, twentythree, twentyfour) + " points!");

    }
    static void Challenge21()
    {
        //Challenge 21
        Console.WriteLine("In digit form, what month were you born in?");
        int twentyfive = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MonthName(twentyfive) + ", then?");
    }
    static void Challenge22()
    {
        //Challenge 22
        int[] a = { 0, 0, 0, 0, 0, };
        Console.WriteLine("Enter the first value");
        a[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second value");
        a[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third value");
        a[2] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the fourth value");
        a[3] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the fifth value");
        a[4] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(FindMinMax(a));
    }
    static void Challenge23()
    {
        //Challenge 23
        int[] b = { 0, 0, 0, 0, 0, };
        Console.WriteLine("After entering all 5 values, we will determine the sum of the absolute of all of these numbers.");
        Console.WriteLine("Enter the first value");
        b[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second value");
        b[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third value");
        b[2] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the fourth value");
        b[3] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the fifth value");
        b[4] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(getAbsSum(b));
    }
    static void Challenge24()
    {
        //Challenge 24
        Console.WriteLine("What is the value of your base value?");
        int twentysix = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the value of your exponent?");
        int twentyseven = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CalculateExponent(twentysix, twentyseven) + " should be the value of your number");
    }
    static void Challenge25()
    {
        //Challenge 25
        Console.WriteLine("Give me the amount of numbers you'd like in your array.");
        int twentyeight = Convert.ToInt32(Console.ReadLine());
        int[] c = new int[twentyeight];
        for (int i = 0; i < c.Length; i++)
        {
            Console.WriteLine("Enter an integer");
            int a = Convert.ToInt32(Console.ReadLine());
            c[i] = a;
        }
        Console.WriteLine("Your new array is " + MultiplyByLength(c));
    }
    static void Challenge26()
    {
        //Challenge  26
        Console.WriteLine("Create strings of the same length to determine how many characters are different between each string.");
        Console.WriteLine("What is the first string?");
        string d = Console.ReadLine();
        Console.WriteLine("What is the second string?");
        string e = Console.ReadLine();

        if (d.Length != e.Length)
        {
            Console.WriteLine("Please insert strings with the same length");
        }
        else
        {
            Console.WriteLine(HammingDistance(e, d));

        }
    }
    
    static int Sum(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
    public static int ToSec(int minutes)
    {
        int seconds = minutes * 60;
        return seconds;
    }

    public static int PlusOne(int original)
    {
        int total = original + 1;
        return total;
    }

    public static int Breaker(int voltage, int current)
    {
        int power = voltage * current;
        return power;
    }

    public static int Age(int years)
    {
        int days = years * 365;
        return days;
    }

    public static int triArea(int bottom, int height)
    {
        int area = (bottom * height) / 2;
        return area;
    }

    public static bool lessThanOrEqualToZero(int wow)
    {
        if (wow <= 0)
        {
            return true;
        }

        else
        {
            return false;
        }

    }

    public static bool lessThan100(int woah, int what)
    {
        if ((woah + what) < 100)
        {
            return true;
        }

        else
        {
            return false;
        }

    }

    public static bool IsEqual(int huh, int how)
    {
        if (huh == how)
        {
            return true;
        }

        else
        {
            return false;
        }

    }

    public static string GiveMeSomething(string words)
    {
        string sentence = "something " + words;
        return sentence;
    }

    public static bool Reverse(bool oppositeday)
    {
        if (oppositeday == true)
        {
            return false;
        }

        else
        {
            return true;
        }
    }

    public static int howManySeconds(int hours)
    {
        int seconds = hours * 3600;
        return seconds;
    }

    public static int SumPolygon(int sides)
    {
        int angle = (sides - 2) * 180;
        return angle;
    }

    public static string nameString(string name)
    {
        string nameplus = name + "Edabbit";
        return nameplus;
    }

    public static bool And(bool a, bool b)
    {
        if (a && b)
            return true;
        else return false;

    }
    public static int Points(int threepointers, int twopointers)
    {
        int total = (threepointers * 3) + (twopointers * 2);
        return total;
    }
    public static int FindPerimeter(int length, int  width)
    {
        int perimeter = (length * 2) + (width * 2);
        return perimeter;
    }

    public static string HelloName(string name)
    {
        string phrase = "Hello " + name + "!";
        return phrase;
    }

    public static int animals(int chickens, int cows, int pigs)
    {
        int legs = (chickens * 2) + (cows * 4) + (pigs * 4);
        return legs;
    }

    public static int FootballPoints(int wins, int draws, int losses)
    {
        int totalpoints = (3 * wins) + (1 * draws) + (0 * losses);
        return totalpoints;
    }

    public static string MonthName(int digit)
    {
        string[] month = {"January", "February", "March", "April", "May", "June", "August",
            "September", "October", "Novermber", "December",};

        if(digit > 0 && digit <= 12)
        {
            digit--;
            return month[digit];
        }

        else
        {
            return "I don't believe you understood me...";
        }
    }

    public static string FindMinMax(int [] numbers)
    {
        int min = numbers.Min();
        int max = numbers.Max();
        Console.WriteLine("The minimum number is " + min + " and the maximum number is " + max);
        return "["+ min + "," + max +"]";
    }

    public static int getAbsSum(int[] integers)
    {
        int sum = Math.Abs(integers[0]) + Math.Abs(integers[1]) + Math.Abs(integers[2]) + Math.Abs(integers[3]) +
                  Math.Abs(integers[4]);
        return sum;
    }

    public static long CalculateExponent(int foundation, int exponent)
    {
        long total = (long)Math.Pow(foundation, exponent);
        return total;
    }

    public static string MultiplyByLength(int[] multiplicand)
    {
        string a = "";
        for (int i = 0;  i < multiplicand.Length; i++)
        {
            a += "[" + (multiplicand[i] * multiplicand.Length) + "]";
        }
        return a;
    }

    public static int HammingDistance(string first, string second)
    {
        int distance = 0;

        for (int i = 0; i <first.Length; i++)
            if (first[i] != second[i])
            {
            distance++;
            }
        return distance;
    }

   
}
