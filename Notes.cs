using System;
public class program{
    public static void Main(){}   

    // Gather Theory in 1st 2 Modules

    void Keywords(){
        // Mutable
        int height = 60;
        double length = 66.6;
        bool action = true;
        string name = "Ravi";
        int[] array = {1,2,3,4,5};

        // Immutable
        const int a = 6; // You cant change it again
        // readOnly int maxAttempts; // You can define but declare in anywhere in code & make it constant
    }

    void TypeCast(){
        // Implicit (Automatically happens)
        int a = 6;
        double b = 4.5;
        double c = a+b;  // c=10.5
        Console.WriteLine(c);

        // Explicit -> int.Parse()
        Console.WriteLine("Enter age:");
        int age = int.Parse(Console.ReadLine()); // Parsing
    }
    
    void InputOutput(){
        // String
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        // Intger
        Console.WriteLine("Enter age:");
        int age = int.Parse(Console.ReadLine()); //  (Parse to int)

        // Float/Double
        Console.WriteLine("Enter salary");
        float income = float.Parse(Console.ReadLine()); //  (Parse to float)

        // Boolean
        Console.WriteLine("Are you resident: (true/false)");
        bool resident = bool.Parse(Console.ReadLine().ToLower());  // (Parse to bool + ToLower)
    
        // Parameters in output
        int score = 85;
        string result = "Pass";
        Console.WriteLine($"Score: {score} Result: {result}");
        Console.WriteLine("Score: " + score + "Result: " + result);
    }

    void IfElse(int income, bool resident){
        int tax;
        if(income<50000){
            if(resident) tax = 10;
            else tax = 15;
        }
        else if(income <100000){
            if(resident) tax = 20;
            else tax = 25;
        }
        else{
            if(resident) tax = 30;
            else tax = 35;
        }
        Console.WriteLine("Total tax is: " + tax*0.01*income);
    }
    
    void Switch(){
        Console.WriteLine("Enter which flood (A/B/C/D)");
        string response = Console.ReadLine();

        switch (response){
            case "A":
                Console.WriteLine("You are in");
                Console.WriteLine("1st floor");
                break;
            case "B":
            case "C":
                Console.WriteLine("You are in"); //Combining multiple cases
                Console.WriteLine("2nd floor");
                break;
            case "D":
                Console.WriteLine("You are in");
                Console.WriteLine("3rd floor");
                break;
            default:
                Console.WriteLine("Please check your response");
                break;

        }
    }
    
    void ForLoop(){
        int[] array = {1,2,3,4,5};
        int sum = 0;
        for(int i=0;i<array.Length;i++){
            sum+= array[i];
        }   
        Console.WriteLine(sum);
    }
    
    void WhileLoop(){
        int[] a = {1,2,3,5,4};
        int sum = 0;
        int i = 0;
        while(i<5){
            sum+=a[i];
            i++;
        }
        Console.WriteLine(sum);
    }

    void DoWhile(){
        // To make sure code executes atleast once
        // This code runs until you enter even number < 10
        // See the importance of break
        do {
            Console.WriteLine("Enter an even number between 1 and 10:");
            // input = int.Parse(Console.ReadLine());
            int input = 6;
            if (input >= 1 && input <= 10 && input % 2 == 0) {
                Console.WriteLine("Valid input: " + input);
                break;
            } else {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (true);
    }

    void Array(){
        // integer array
        int[] array = {1,1,4,3,5};
        Console.WriteLine("4th element:" + array[3]);

        for(int i=0;i<array.Length;i++){
            if(array[i]%2==0)
                Console.WriteLine(array[i] + " is even");
            else
                Console.WriteLine(array[i] + " is odd");
        }   

        // string array with switch
        string[] weather = {"Sunny", "Rainy", "Cloudy"};
        for(int i=0; i<weather.Length; i++){
            switch (weather[i]){
                case "Sunny":
                    Console.WriteLine("Today will be Hot");
                    break;
                case "Rainy":
                    Console.WriteLine("Today will be Rainy");
                    break;
                default:
                    Console.WriteLine("Today will be Cloudy");
                    break;
            }
        }

    }
    
    void ForEach(){
        string text = "Hello World";
        text = text.ToLower();
        int count = 0;
        for (int i=0; i<text.Length; i++){
            char c = text[i];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                count++;
        }

        // The above can be written in this way simply
        count = 0;
        foreach (char c in text.ToLower()){
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                count++;
        }
        Console.WriteLine("#Vowels = " + count);
    }
}

