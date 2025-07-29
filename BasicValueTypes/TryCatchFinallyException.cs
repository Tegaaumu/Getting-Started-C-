//// debugging is the process of finding and 
//// fixing errors within a computer program
//// errors in our C# programs are called execeptions 
//// exceptions are "thrown" when the program encounters an error

//// let's create a simple program that throws an exception

//int IntegerDivision(int x, int y)
//{
//    return x / y;
//}

//// the program will throw an exception when we try to divide by zero
////int result = IntegerDivision(10, 0);

//// exeptions are caught using try -catch block
//// try-catch blocks look like this:
//try
//{
//    // code that might throw an exception
//}
//catch (Exception e)
//{
//    // code that runs if an exception is thrown
//}

//// let's catch the exception from our IntegerDivision method
//try
//{
//    IntegerDivision(10, 0);
//}
//catch (Exception e) when (e.Message.Contains("divide by zero"))
//{
//    Console.WriteLine("You can't divide by zero! main");
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine("You can't divide by zero!");
//}
//catch (Exception e)
//{
//    Console.WriteLine("An exception was trown!");
//    Console.WriteLine(e.Message);
//}
//finally
//{
//    Console.WriteLine("This code always run one an error type is cut.");
//}