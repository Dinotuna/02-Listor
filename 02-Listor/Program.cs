
// string[] toys = {"Rubiks-kub", "Lego", "Play-Doh", "Nalle", "Transformer"};


// string[] names = {"Majkel", "Isak", "Albin", "Axel" ,"Sverre"};
// int[] ints = {1, 3, 6, 7, 9};



// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"{names[i]} ger {toys[i]} betyget {ints[i]}");
// }


List<string> cities = new List<string>();

Console.WriteLine("Skriv namn på städer, Skriv exit för att avsluta");
string svar = "";

while(svar != "exit")
{
    svar = Console.ReadLine();
    cities.Add(svar);
}

Console.WriteLine("Städerna du skrev var:");

foreach (var city in cities)
{
    Console.WriteLine(city);
}

Console.ReadLine();