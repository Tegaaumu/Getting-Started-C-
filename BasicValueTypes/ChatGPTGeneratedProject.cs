//Task:
//Create a console application that asks the user for their name, age, and favorite number (as a float). Then:

//Greet the user.

//Display their age next year.

//Multiply their favorite number by 3.14 (π approximation) and print the result using two decimal places.

//Bonus:
//Use a ternary operator to tell the user whether their age is odd or even.

//Console.WriteLine("🔹 Question 1 – Easy: Basic Variables and Logic");

//Console.WriteLine("Good day, Please enter your details below. (Name, Age, and Favorite number");

//double toatlFavorite = 0;
//double pi = 3.14;
//float floatAge = 0;

//for (int i = 0; i < 3; i++)
//{
//    switch (i)
//    {
//        case 0:
//            Console.WriteLine("Enter your Name:");
//            var Name = Console.ReadLine();
//            Console.WriteLine($"Your name is {Name}");
//            continue;
//        case 1:
//            Console.WriteLine("Enter your Age:");
//            floatAge = float.Parse(Console.ReadLine());
//            Console.WriteLine($"Your Age is by next year is {floatAge + 1}");
//            continue;
//        case 2:
//            Console.WriteLine("Enter your Favorite Number:");
//            var FavoriteNumber = Console.ReadLine();
//            Console.WriteLine($"Your Favorite Number is {FavoriteNumber}");
//            toatlFavorite = pi * floatAge;
//            continue;
//    }
//}
//double roundedValue = Math.Round(toatlFavorite, 2);

//var isValueOldOrEven = ((int)floatAge % 2 == 0) ? "even" : "odd";

//Console.WriteLine($"User Age is {isValueOldOrEven}");


//Question 2 – Medium: Arrays, Lists, and Control Flow
//Task:
//Write a method that does the following:

//Takes an array of integers.

//Filters out all odd numbers into a List<int>.

//Returns the list.

//In Main():

//Call the method with an array of your choice.

//Use a foreach loop to print the filtered list.

//Bonus: Use TryParse to allow users to input numbers into the array and handle invalid entries.

//Console.WriteLine("Question 2 – Medium: Arrays, Lists, and Control Flow");
//List<int> generalNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
////int[] arrayOme = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//List<int> FilterOddNumbers(int[] numbers)
//{
//    List<int> evenNumbers = new List<int>();
//    foreach (var number in numbers)
//    {
//        if (number % 2 == 0)
//        {
//            evenNumbers.Add(number);
//        }
//    }
//    return evenNumbers;
//}

//var EvenList = FilterOddNumbers(generalNumbers.ToArray());

//foreach (var number in EvenList)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine("Please enter 5 numbers:");
//int[] userNumbers = new int[5];
//for (int i = 0; i < userNumbers.Length; i++)
//{
//    string NewVaalue = Console.ReadLine();
//    var input = int.TryParse(NewVaalue, out int result);
//    if (input)
//    {
//        userNumbers[i] = result;
//    }
//    else
//    {
//        Console.WriteLine("Invalid input, please enter a valid number.");
//        i--; // Decrement i to repeat this iteration
//    }
//}
//var EvenListArray = FilterOddNumbers(userNumbers);

//foreach (var number in EvenListArray)
//{
//    Console.WriteLine($"This is an even number: {number}");
//}


//🔹 Question 3 – Hard: OOP with Constructors, Fields & Properties
//Task:
//Create a class Student with the following:

//Fields: firstName, lastName

//Property: FullName(read - only, returns firstName + " " + lastName)

//Constructor to initialize both names

//Method PrintGreeting() that prints:
//"Hello, my name is {FullName}"

//In Main():

//Create 2 student objects and call PrintGreeting() for each.

//Bonus:
//Make FullName a computed property with only a get.

//Console.WriteLine("🔹 Question 3 – Hard: OOP with Constructors, Fields & Properties");
//Student studentName = new Student("John", "Doe");
//studentName.PrintGreeting();
//Student student2 = new Student("Ada", "Obi");
//student2.PrintGreeting();


//class Student
//{
//    private string firstName;
//    private string lastName;
//    public string FullName => $"{firstName} {lastName}";
//    public Student(string firstName, string lastName)
//    {
//        this.firstName = firstName;
//        this.lastName = lastName;
//    }

//    public void PrintGreeting()
//    {
//        Console.WriteLine($"Hello, my name is {FullName}");
//    }
//}


//🔹 Question 4 – Very Hard: Exception Handling & Static Methods
//Task:
//Create a static class MathUtility with a static method DivideNumbers that:

//Takes 2 strings

//Parses them into floats

//Divides the first by the second and returns the result

//Handle the following in a try-catch-finally:

//If parsing fails, show "Invalid input."

//If division by zero occurs, show "Cannot divide by zero."

//In all cases, print "Operation attempted." in the finally block.

//In Main():

//Prompt the user to enter two values

//Call the method and display the result if successful

//Console.WriteLine("🔹 Question 4 – Very Hard: Exception Handling & Static Methods");

//try
//{
//   var result =  MathUtility.DivideNumbers("5", "0");
//    Console.WriteLine($"Result was successful. Value is {result}");
//}
//catch (DivideByZeroException e) when(e.Message.Contains("divide by zero"))
//{
//    Console.WriteLine($"Cannot divide by zero.");
//}
//catch (Exception e)
//{
//    Console.WriteLine($"Invalid input.");
//}
//finally
//{
//    Console.WriteLine($" Operation attempted.");
//}
//static class MathUtility
//{
//    //public static float DivideNumbers(string FirstOne, string SecoundOne)
//    //{
//    //    float passFirst = float.Parse(FirstOne);
//    //    float passSecound= float.Parse(SecoundOne);

//    //    float division = passSecound % passFirst;

//    //    return division;
//    //}
//    //This was the correction ChatGpt gave to me
//    public static float DivideNumbers(string FirstOne, string SecoundOne)
//    {
//        if (!float.TryParse(FirstOne, out float num1) || !float.TryParse(SecoundOne, out float num2))
//        {
//            throw new Exception("Invalid input.");
//        }
//        if (num2 == 0)
//        {
//            throw new DivideByZeroException("Cannot divide by zero.");
//        }

//        return num1 / num2;
//    }

//}




//The below was generated by copilot
// Question 3 – Hard: Classes, Objects, and LINQ 
//Task: 
//Create a class called `Person` with the following properties:
//- `Name` (string)
//- `Age` (int)
//- `FavoriteNumber` (float)
//- `IsEvenAge` (bool) - a property that checks if the age is even or odd
//- `NextYearAge` (int) - a property that calculates the age next year
//- `FavoriteNumberMultiplied` (float) - a property that multiplies the favorite number by 3.14 and rounds it to two decimal places
//- `Greet()` - a method that returns a greeting string
//- `FilterOddNumbers()` - a method that takes an array of integers and returns a list of even numbers
// In the `Main()` method:
//- Create an instance of `Person` and set its properties based on user input.
//- Call the `Greet()` method and print the greeting.
//- Print the `NextYearAge`, `FavoriteNumberMultiplied`, and whether the age is even or odd.
//- Use the `FilterOddNumbers()` method to filter a predefined array of integers and print the results.
//- Bonus: Use LINQ to filter the array of integers directly in the `Main()` method.
//- Console.WriteLine("Question 3 – Hard: Classes, Objects, and LINQ");