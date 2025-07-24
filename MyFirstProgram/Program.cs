//Date and time can be stored in a DateTime variable
//Dates can be assigned to a DateOnly variable
//Times can be assigned to a TimeOnly variable

//we can declare a DateTime Variable
DateTime myDateTime;

DateOnly myDate;

TimeOnly myTime;

//We can assign a value to these variables
myDateTime = DateTime.Now;
myDate = new DateOnly(2024, 1, 23);
myTime = new TimeOnly(1, 23, 45);

//We can declare and assign in one line
DateTime myDateTime2 = DateTime.Now;
DateOnly myDate2 = new DateOnly(2024, 1, 23);
TimeOnly myTime2 = new TimeOnly(1, 23, 45);

//We can re-assign a value to these variables
myDateTime = DateTime.Now;
myDate = new DateOnly(2024, 1, 23);
myTime = new TimeOnly(1, 23, 45);

//Dates and times are complex... Consider
//That we haven't factored in time zone

//we can make a DateTime variale out of 
//a DateOnly  and a TimeOnly variable
DateTime dateTimeFromCombination = new DateTime( myDate, myTime);

//Let declare this to the console
Console.WriteLine($"Date Only: {myDate}");
Console.WriteLine($"Time Only: {myTime}");
Console.WriteLine($"Date Time: {dateTimeFromCombination}");
