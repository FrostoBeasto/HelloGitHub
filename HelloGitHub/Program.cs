string[] zajmy = { "Ahoj, jsem Tomáš(TomBEAST!) , chodím na SŠ Educhem a rád hraju videohry speciálně souls hry",
        "Taky mám rád volejbal a seriály hlavně Anime." };

Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.Green;

foreach(var item in zajmy)
{
    Console.WriteLine(item);
}