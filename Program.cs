// LINQ (Daten filtern und auslesen)


// data souce (Datenquelle)
List<int> numbers = new List<int>() { 3, 6, 1, 5, 4, 2, 7, 12};

// create query (für Quelle Abfrage) (Liste Abfragen)
// von num in numbers - für jede Nummer in numbers die Nummern raussuchen
var nums = from num in numbers
           select num;

numbers.Add(9);

//access nums (Zugriff auf Liste - Ausgabe)
foreach (var n in nums)
{
    Console.WriteLine("Die Zahl ist {0}", n);
}

Console.WriteLine();
Console.WriteLine();

// Filter: nur gerade Zahlen (where)
var numsGerade = from num in numbers
                 where num % 2 == 0
                 select num;

foreach (var n in numsGerade)
{
    Console.WriteLine("Die Zahl ist {0}", n);
}

Console.WriteLine();
Console.WriteLine();

// Filter: Gerade und größer als 4
var numsGerade4 = from num in numbers
                 where num % 2 == 0
                 where num > 4
                 select num;

foreach (var n in numsGerade4)
{
    Console.WriteLine("Die Zahl ist {0}", n);
}

Console.WriteLine();
Console.WriteLine();


// sortieren - orderby
var numsSort = from num in numbers
               orderby num
               select num;

// mit dieser Methode kann man auch sortieren
// numbers.Sort();


foreach (var n in numsSort)
{
    Console.WriteLine("Die Zahl ist {0}", n);
}

Console.WriteLine();
Console.WriteLine();

List<string> firstnames = new List<string>()
{
    "Max", "Jusefa", "Fritz", "Daniela", "Emil"
};

// Namen mit e oder E 
// || weil e oder E, ansonsten wäre e und E 

var nameE = from name in firstnames
            where name.Contains("e")
            || name.Contains("E")
            select name;

foreach (var n in nameE)
{
    Console.WriteLine("Der Name {0} beinhaltet ein kleines oder großes e", n);
}
