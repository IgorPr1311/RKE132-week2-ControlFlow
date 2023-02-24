// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutaja vanust
//kui vanus on alla 13, siis konsoolis kuvatakse teade:
//"You are too young to use Instagram"
//muul juhul konsoolis kuvatakse
//"Welcome to Instagram

using System.ComponentModel.Design;

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if (userAgeNum >= 13) 
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else 
    {
        Console.WriteLine("You are too young!");
    }
}
else
{
    Console.WriteLine("Could not read your age");
}







//int userAge = Int32.Parse(Console.ReadLine());//"13"- "sõne" heap(hunnik), nõuab rohkem aega ja arvuti resurssi, et info üles leida. 13 - läheb stack-i
//if(userAge >= 13)
{
    //Console.WriteLine("Welcome to Instagram!");
}    
//else
{
    //Console.WriteLine("You are too young to use the Instagram!");
}    