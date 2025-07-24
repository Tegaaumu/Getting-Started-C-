// the most basic type of control flow that we 
//have is called the "if-statement". It allows us 
//to execute a block of code if a certain condition
//is true. If the condition is false, the block of
//code is skipped.

//the expression inside of the parentheses
//is called the "condition"
if (true)
{
    Console.WriteLine("This will always print");
}


if (false)
{
    Console.WriteLine("This will always print");
}


//we can use variable as the condition to check
//remember boolean variables?
//let's use one here!

bool condition = !true;
if (condition)
{
    Console.WriteLine("This prints when the condition is true!");
}

//we can also use the "else" keyword to execute
//a block of code if the condition is false

if (condition)
{
    Console.WriteLine("This prints when the condition is true!");
}
else
{
    Console.WriteLine("This prints when the condition is false!");
}

//we can also use "else if" keyword to check multiple conditions

if (condition)
{
    Console.WriteLine("This prints when the condition is true");
}
else if (!condition)
{
    Console.WriteLine("This prints when the condition is false");
}
else
{
    Console.WriteLine("Trick question?!");
}

//can the else block above ever print?
//no!
//this is because our boolean can only be
//tru or false, so the first two conditions
//cover all possible case!

//let's try this again with an integer!
//we'll introduce some new syntax here as well
//< is the "less than" operator
//> is the "greater than" operator
//<= is the "less than or equal to" operator
//>= is the "greater than or eual to" operator
//== is the "equal to" operator
//!= is te "not equal to" operator

int number = 1;
if (number < 5)
{
    Console.WriteLine("The number is less than 5");
}
else if(number == 5)
{
    Console.WriteLine("The number is equal 5");
}
else
{
    Console.WriteLine("The number is greater than 5");
}

//remember the && and || operators?
//we can use them to combine conditions!
number = 3;
if (number >= 1 && number <= 5)
{
    Console.WriteLine("The number is btw 1 and 5");
}
else
{
    Console.WriteLine("The number is not btw 1 and 5");
}


if (number < 1 || number > 5)
{
    Console.WriteLine("The number is not btw 1 and 5");
}
else
{
    Console.WriteLine("The number is btw 1 and 5");
}