////The switch statement is use to select one of
//// many code blocks to be executed.
////The switch expression is used to select one of 
////many code blocks to be executed.

////here is an exmaple of a switch statement
//int dayOfWeek = 4;
//switch (dayOfWeek)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wensday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Invalid day");
//        break;
//}

//Console.WriteLine("This is after the switch!");

////here is an example of a switch expression
//string dayOfWeekName = "Ben";
//string result = dayOfWeekName switch
//{
//    "Monday" or "Ben" => "First day of the week",
//    "Tuesday" => "Secound day of the week",
//    "Wednesday" => "Third day of the week",
//    "Thursday" => "Fourth day of the week",
//    "Friday" => "Fifth day of the week",
//    "Saturday" => "Sixth day of the week",
//    "Sunday" => "Seventh day of the week",
//    _ => "Invalid day"
//};
//Console.WriteLine(result);

//object obj = "hello";

//string type = obj switch
//{
//    int i when i >= 1 && i <= 3 => $"Integer between 1-3: {i}",
//    string s => $"It's a string: {s}",
//    _ => "Unknown"
//};
//Console.WriteLine(type);

//int tega = 5;

//int tegaa = tega switch
//{
//    1 => 10,
//    2 => 20,
//    3 => 30,
//    4 => 40,
//    5 => 50,
//    _ => -1
//};

//Console.WriteLine(tegaa);
