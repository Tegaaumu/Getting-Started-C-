////✅ Question 1: Combine Control Flow and Methods
////Task:
////Write a method called CalculateSum that accepts an integer array as an argument and returns the sum of all even numbers using a foreach loop.

////In Main, create an integer array with at least 6 values.

////Call the CalculateSum method and print the result.

////Bonus: Use a ternary operator to decide whether to print "Sum is even" or "Sum is odd" after displaying the result.

//int[] arrays1 = new int[5]
//{
//    3,
//    5,
//    4,
//    9,
//    7,
//};

//List<int> listedItems = new List<int>()
//{
//    23,
//    25,
//    24,
//    28,
//    27,
//};

//int CalculateSum(int[] arrays)
//{
//    int sum = 0;

//    foreach (var item in arrays)
//    {
//        sum += item;
//        Console.WriteLine($" current sum of Array is: {sum}");
//    }
//    return sum;
//}
//int CalculateSumLism(List<int> arrays)
//{
//    int sum = 0;

//    foreach (var item in arrays)
//    {
//        sum += item;
//        Console.WriteLine($" current sum of List is: {sum}");
//    }
//    return sum;
//}

//int valueIs = CalculateSum(arrays1);
//int valueIss = CalculateSumLism(listedItems);

//string EvenOrOdd1 = (valueIs % 2 == 0) ? "Sum is odd" : "Sum is even";
//string EvenOrOdd2 = (valueIss % 2 == 0) ? "Sum is odd" : "Sum is even";

//Console.WriteLine($"Below is the final array sum of everything {valueIs} is {EvenOrOdd1}");
//Console.WriteLine($"Below is the final List sum of everything {valueIss} is {EvenOrOdd2}");

////✅ Question 2: Practice Collections and Exception Handling
////Task:
////Create a dictionary named studentScores with student names as keys and their scores (float) as values.

////Add at least 3 students to the dictionary.

////Ask the user to input a student name.

////Use a try-catch-finally block to:

////Attempt to retrieve and print the student's score.

////Handle the exception if the name is not found.

////Finally, print "Search completed."

//Dictionary<string, int> studentRecord = new()
//{
//    ["Tega"] = 30,
//    ["James"] = 20,
//    ["David"] = 40,
//};

//Console.WriteLine("Please input student name: 👇👇");
//string userInputedName = Console.ReadLine();

//try
//{
//    foreach (var item in studentRecord)
//    {
//        if (userInputedName == item.Key)
//        {
//            Console.WriteLine($"{userInputedName} score {studentRecord[userInputedName]}");
//        }
//        //else
//        //{
//        //    Console.WriteLine("The name you inputed is not in our record");
//        //}
//    }
//}
//finally
//{
//    Console.WriteLine("Search completed.");
//}

////✅ Question 3: Practice Data Types and Parsing
////Task:
////Create a method that asks the user to input two strings representing numbers. Parse the strings into float using float.TryParse.

////If both parses succeed, multiply the two numbers and display the result.

////If either fails, display an appropriate message.

////Use:

////CastingAndParsingVariables.cs concepts

////FloatDoubleVariable.cs

////Control statements for validation

//Console.WriteLine("Input First string or numbers");
//string firstOne = Console.ReadLine();

//Console.WriteLine("Input Secound string or numbers");
//string firstTwo = Console.ReadLine();
//try
//{
//    bool foaltFirstone = float.TryParse(firstOne, out float result1);
//    bool foaltFirstTwo = float.TryParse(firstTwo, out float result2);
//    if (foaltFirstTwo && foaltFirstone)
//    {
//        Console.WriteLine($"The multiplication of but digit are {result1 * result2}");
//    }
//    Console.WriteLine($" If true meaasge was a success if false did not work: --{foaltFirstone}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
