// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//using if else statement to calculate grate

//Console.Write("Enter your number : ");
//int marks =Convert.ToInt32(Console.ReadLine());



//if (marks>=80 && marks<=100)
//{
//    Console.WriteLine(" Your grate is A+");
//}
//else if (marks >= 70 && marks <80)
//{
//    Console.WriteLine(" Your grate is A");
//}
//else if (marks >= 60 && marks < 70)
//{
//    Console.WriteLine(" Your grate is A-");
//}
//else if (marks >= 50 && marks < 60)
//{
//    Console.WriteLine(" Your grate is B");
//}
//else if (marks >= 40 && marks < 50)
//{
//    Console.WriteLine(" Your grate is C");
//}
//else if (marks >= 33 && marks < 40)
//{
//    Console.WriteLine(" Your grate is D");
//}
//else
//{

//    Console.WriteLine("you are failed");
//}

//Using switch statement to calculate grate

Console.Write("Enter your number : ");
int marks = Convert.ToInt32(Console.ReadLine());



switch (marks)
{
    case >= 80 and <= 100:
        Console.WriteLine(" Your grate is A+");
        break;
    case >= 70 and < 80:
        Console.WriteLine(" Your grate is A");
        break;
    case >= 60 and < 70:
        Console.WriteLine(" Your grate is A-");
        break;
    case >= 50 and < 60:
        Console.WriteLine(" Your grate is B");
        break;
    case >= 40 and < 50:
        Console.WriteLine(" Your grate is C");
        break;
    case >= 33 and < 40:
        Console.WriteLine(" Your grate is D");
        break;
    default:
        Console.WriteLine("you are failed");
        break;
}