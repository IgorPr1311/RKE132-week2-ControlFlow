// See https://aka.ms/new-console-template for more information

//rakendus palub kasutajat valida tema sugu (m/f)
//rakendus küsib kasutaja perekonnanime
//lähtudes valitud soost, rakendus tervitab kasutajat järgmiselt
//"Welcome, Mr.[kasutaja perekonnanimi]" või "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());//loeb konsoolis maha andmed string e. sõne formaadis
Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();
if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName} !");
}
else
{
     Console.WriteLine($"Welcome, {userLastName}!");
}
