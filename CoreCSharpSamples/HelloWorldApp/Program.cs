using static System.Console;

namespace Wrox.HelloWorldApp
{
    class Program
    {
        static void Main()
        {
            // Variables and Declarations
            /*var name = "Gabriela Gutierrez";
            var age = 24;
            var isRabbit = true;
            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type IsRabbitType = isRabbit.GetType();
            WriteLine($"name is type {nameType}");
            WriteLine($"age is type {ageType}");
            WriteLine($"isRabbit is type {IsRabbitType}");*/

            // String interpolation
            /*string s1 = "a string";
            string s2 = s1;
            WriteLine($"s1 is {s1}");
            WriteLine($"s2 is {s2}");
            s1 = "another string";
            WriteLine($"s1 is now {s1}");
            WriteLine($"s2 is now {s2}");*/

            // CONDITIONAL STATEMENTS
            // IF STATEMENTS
            bool isZero;
            if (i == 0)
            {
                isZero = true;
                WriteLine("i is Zero");
            }
            else
            {
                isZero = false;
                WriteLine("i is Non-zero");
            }

            // IF/ELSE STATEMENTS
            WriteLine("Type in a string");
            string input;
            input = ReadLine();
            if (input == "")
            {
                WriteLine("You typed in an empty string.");
            }
            else if (input.Length < 5)
            {
                WriteLine("The string had less than 5 characters.");
            }
            else if (input.Length < 10)
            {
                WriteLine("The string had at least 5 but less than 10 Characters.");
            }
            WriteLine("The string was " + input);

            // SWITCH STATEMENTS
            switch (integerA)
            {
                case 1:
                    WriteLine("integerA = 1");
                    break;
                case 2:
                    WriteLine("integerA = 2");
                    break;
                case 3:
                    WriteLine("integerA = 3");
                    break;
                default:
                    WriteLine("integerA is not 1, 2, or 3");
                    break;
            }

            // FOR LOOP
            for (int i = 0; i < 100; i++)
            {
                // etc.
            }
            //Also you can use type inference
            for (var i = 0; i < 100; i++)
            {
                // etc.
            }
            // Nested For Loop
            // This loop iterates through rows
            for (int i = 0; i < 100; i += 10)
            {
                // This loop iterates through columns
                for (int j = i; j < i + 10; j++)
                {
                    Write($" {j}");
                }
                WriteLine();
            }

            // WHILE LOOP 
            bool condition = false;
            while (!condition)
            {
                // This loop spins until the condition is true.
                DoSomeWork();
                condition = CheckCondition(); // assume CheckCondition() returns a bool
            }

            //DO/WHILE LOOP
            bool condition;
            do
            {
                // This loop will at least execute once, even if Condition is false.
                MustBeCalledAtLeastOnce();
                condition = CheckCondition();
            } while (condition);

            // FOR EACH LOOP : ITERATE THROUGH EACH ITEM IN A COLLECTION
            foreach (int temp in arrayOfInts)
            {
                WriteLine(temp);
            }
            // For each loop with type inference
            // Note: cannot change the value of the item in the collection  
            foreach (var temp in arrayOfInts)
            {
                // etc.
            }


            // JUMP STATEMENTS: LETS YOU JUMP TO ANOTHER LINE OF CODE
            goto Label1;
            WriteLine("This won't be executed");
        Label1:
            WriteLine("Continuing execution from here");

        }
    }
}