

        Console.Write("Enter number 1 or 2: ");

        string option = Console.ReadLine();
        switch (option)
        {
            case "1":
                FirstOption();
                break;
            case "2":
                int result = SecondOption();
                Console.WriteLine($"Sum is {result}");
                break;
            default:
                Console.WriteLine("No such options");
                break;
        }
        Console.ReadLine();

    void FirstOption()
    {
        //opening and reading file with specified path
        string text = File.ReadAllText("C:\\Users\\Anna\\source\\repos\\lab_1\\text.txt");

        //splitting the text into array of words
        //getting array's length
        int size = text.Split(new char[] { ' ', '\n' }).Length;
        Console.WriteLine($"Word count: {size}");
    }
    int SecondOption()
    {
        Console.Write("Enter an int number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another int number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        return num1 + num2;
    }
