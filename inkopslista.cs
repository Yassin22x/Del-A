List<string> names = new List<string>(); // Två paralella listor för respektive namn och pris. (Endast heltal på int)
List<int> prices = new List<int>(); 

names.Add("Ost");   // Lägger till Ost på plats 0
prices.Add(15);   // Lägger till priset 15 kr på plats 0

names.Add("Smör"); // Lägger till Smör på plats 1
prices.Add(20);   // Lägger till priset 20 kr på plats 1

names.Add("Salami");   // Lägger till Salami på plats 2
prices.Add(25);   // Lägger till priset 25 kr på plats 2

while (true) // En oändlig loop som körs hela tiden. 
{ 
 
Console.Clear(); // Suddar bort all gammal text från skärmen 
Console.WriteLine("=== Inköpslistan ==="); //Rubriien för inköpslistan 
 
 
int total = 0; // Håller koll på totalsumman  
 
for (int i = 0; i < names.Count; i++) // Loopen som går igenom alla varor en efter en 
{ 
Console.WriteLine((i+1) + ". " + names[i] + " - " + prices[i] + " kr"); // Skriver ut nummer, namn och pris 
total += prices[i]; // Lägger till priset i totalsumman 
} 
 
Console.WriteLine("Totalt: " + total + " kr"); // Skriver ut totalsumman. 
 
 
Console.Write("Skriv varunamn (lägga till) eller nummer (ta bort): "); // Läser in vad som skrivs på tangentbordet 
string input = Console.ReadLine(); 
 
if (string.IsNullOrWhiteSpace(input)) 
{ 
continue; // Om man bara trycker enter, börjar loopen om igen. 
} 
 
// --- Ta bort vara om du skrev ett nummmer) --- 
if (int.TryParse(input, out int removeIndex)) // Kollar om det som skrevs in är ett nummer)) 
{ 
int actualIndex = removeIndex - 1; // Listor börjar på 0, så därför kör vi minus 1 
 
if (actualIndex >= 0 && actualIndex < names.Count) // Kollar om indexet är giltigt// om numret finns i listan 
 
 
 
{ 
names.RemoveAt(actualIndex); // Tar bort varan från namnlistan 
prices.RemoveAt(actualIndex); // Tar bort priset från prislistan 
} 
else 
{ 
Console.WriteLine("Ogiltigt nummer! Tryck på enter för att fortsätta..."); 
Console.ReadLine(); 
} 
} 
// --- Lägg till vara om du skrev text) --- --- 
else 
{ 
Console.Write("Ange pris för " + input + ": "); // Frågar efter priset 
string priceInput = Console.ReadLine(); // Läser in priset 
 
if (int.TryParse(priceInput, out int price) && price >= 0) // Kollar om priset är ett giltigt heltalsnummer 
{ 
names.Add(input); // Lägger till varan i namnlistan 
prices.Add(price); // Lägger till priset i prislistan 
} 
else 
{ 
Console.WriteLine("Ogiltigt pris! Tryck på enter för att fortsätta..."); 
Console.ReadLine(); 
} 
} 
 
}
