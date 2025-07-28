//Console.WriteLine("Working with Switch Statement/Expression");

//switch (5)
//{
//    case 1:
//        Console.WriteLine("One");
//        break;
//    case 2:
//        Console.WriteLine("Two");
//        break;
//    case 3:
//        Console.WriteLine("Three");
//        break;
//    case 4:
//        Console.WriteLine("Four");
//        break;
//    case 5:
//        Console.WriteLine("Five");
//        break;
//    default:
//        Console.WriteLine("Unknown number");
//        break;
//}
//Console.WriteLine("Enter a user value (Ben, Mary, Tega):");
//string valueName = Console.ReadLine();
//Console.WriteLine($"Write down the user value {valueName}");
//switch (valueName)
//{
//    case "Ben":
//    case "Mary":
//        Console.WriteLine("Ben and Mary is here");
//        break;
//    case "tega":
//        Console.WriteLine("Tega is here");
//        break;
//    default:
//        Console.WriteLine("Decimal is here");
//        break;
//}
//int ValueStringToInt = int.Parse(valueName); // Assuming valueName is a number in string format
//switch (ValueStringToInt)
//{
//    case int d when ValueStringToInt <= 2:
//        Console.WriteLine("Tega is here");
//        break;
//    case 3:
//    case 2:
//        Console.WriteLine("3 or 2 is here");
//        goto case 4;
//    case 4:
//        Console.WriteLine("4 is here");
//        break;
//    default:
//        Console.WriteLine("Decimal is here");
//        break;
//}

//string ExpressionStatement = valueName switch
//{
//    "tega" => "Tega is here",
//    "ben" or "mary3" => "Ben and Mary is here",
//    _ when valueName.Length > 3 => "Value name is longer than 3 characters",
//    _ => "Unknown value"
//};

//Console.WriteLine(ExpressionStatement);

