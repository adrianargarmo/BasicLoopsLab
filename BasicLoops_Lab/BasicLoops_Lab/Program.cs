/* Description
 * Use a do-while loop to output "Hello, World!" in a loop.
 * Each time you output "Hello, World!" ask the user whether they would like to continue.
 */

/*
    bool playAgain = true;
    do
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Would you like to play again? (y/n)");
        string input = Console.ReadLine();

        if (input == "y")
        {
            playAgain = true;
        }
        else if (input == "n")
        {
            Console.WriteLine("Goodbye!");
            playAgain = false;
        }
    } while (playAgain == true);
*/
// test


/* Description
 * Prompt the user for a number. Use a for loop to output all the numbers from that number to 0.
 * After that loop finishes, use another loop to output all the numbers from 0 to that number.

    while (true)
    {
        int userNumber = -1;

        userNumber = GetNumber(userNumber);

        CountFromZeroToUserNumber(userNumber);
        CountFromUserNumberToZero(userNumber);


        Console.WriteLine("Would you like to play again? (y/n)");
        string input = Console.ReadLine();

        if (input == "n")
        {
            Console.WriteLine("Goodbye!");
            break;
        }

    static int GetNumber(int input)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number");
                bool isValid = int.TryParse(Console.ReadLine(), out input);

                if (isValid)
                {
                    break;
                }
                Console.WriteLine("That is not a valid number.");
            }
            return input;
        }

        static void CountFromZeroToUserNumber(int input)
        {
            for (int i = input; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void CountFromUserNumberToZero(int input)
        {
            for (int i = 0; i <= input; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
*/



/* Description
 * A door has a keypad entry.
 * The combination to get in is 13579.
 * Write a while loop (not a do while loop) that asks the user to enter a key code.
 * The loop will repeat as long as the user enters the wrong code.
 * After the user enters the correct code, the program will print out a welcome message.
 * 
 * Hint: There are many ways to accomplish this, but one way is to create a boolean variable that represents if the door is locked or unlocked.
 * Then think about real life, when you approach a door with a keypad, what state is it initially in before you type anything into the keypad?

    int combination = 13579;
    bool IsDoorLocked = true;

    while (IsDoorLocked)
    {
        Console.WriteLine("Please enter a key code");
        int input = int.Parse(Console.ReadLine());

        if (input == combination)
        {

            Console.WriteLine("Welcome!");
            IsDoorLocked = false;
        }
        else
        {
            Console.WriteLine("The key code is not correct, please try again.");
            IsDoorLocked = true;
        }
    }
 */



/* Description
 * Continue the previous exercise, but now add a limited number of tries, say 5.
 * After 5 unsuccessful attempts, the loop ends, but instead of printing a welcome message, it prints a message warning that there were too many incorrect attempts.
 * (But if the user entered the correct number, it will still print the welcome message as before.)

    int combination = 13579;
    bool IsDoorLocked = true;
    int attemptCounter = 1;

    while (IsDoorLocked)
    {
        Console.WriteLine("Please enter a key code to unlock the door.");
        int input = int.Parse(Console.ReadLine());
        attemptCounter++;

        if (attemptCounter <= 5)
        {
            if (input == combination)
            {
                Console.WriteLine("Welcome!");
                IsDoorLocked = false;
            }
            else
            {
                Console.WriteLine("The key code is not correct, please try again.");
                IsDoorLocked = true;
            }
        }
        else
        {
            Console.WriteLine("Sorry, you failed to enter the correct key code.");
            break;
        }

    }
*/

/* Description
 * Start a new console project, and repeat the same exercise as the previous, except this time implement it with a do while loop.

    int combination = 13579;
    bool IsDoorLocked = true;
    int attemptCounter = 1;

    do
    {
        Console.WriteLine("Please enter a key code to unlock the door.");
        int input = int.Parse(Console.ReadLine());
        attemptCounter++;

        if (attemptCounter <= 5)
        {
            if (input == combination)
            {
                Console.WriteLine("Welcome!");
                IsDoorLocked = false;
            }
            else
            {
                Console.WriteLine("The key code is not correct, please try again.");
                IsDoorLocked = true;
            }
        }
        else
        {
            Console.WriteLine("Sorry, you failed to enter the correct key code.");
            break;
        }
    } while (IsDoorLocked);
*/



/* Description
 * Move the last while loop or the do-while loop into its own function.
 * The function should return a true if access is granted,
 * or a false if the user didn’t enter the correct code within 5 tries.

    IsAccessGranted();

    static bool IsAccessGranted()
    {
        int combination = 13579;
        bool IsDoorLocked = true;
        int attemptCounter = 1;

        while (IsDoorLocked)
        {
            Console.WriteLine("Please enter a key code to unlock the door.");
            int input = int.Parse(Console.ReadLine());
            attemptCounter++;

            if (attemptCounter <= 5)
            {
                if (input == combination)
                {
                    Console.WriteLine("Welcome!");
                    IsDoorLocked = false;
                    return true;
                }
                else
                {
                    Console.WriteLine("The key code is not correct, please try again.");
                    IsDoorLocked = true;
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Sorry, you failed to enter the correct key code.");
            }
        }
    }
*/