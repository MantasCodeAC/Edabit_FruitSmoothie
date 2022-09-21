using Edabit_FruitSmoothie;
/*Create a class Smoothie and do the following:
Create a property called Ingredients.
Create a GetCost method which calculates the total cost of the ingredients used to make the smoothie.
Create a GetPrice method which returns the number from GetCost plus the number from GetCost multiplied by 1.5. 
Round to two decimal places.
Create a GetName method which gets the ingredients and puts them in alphabetical order into a nice descriptive sentence. 
If there are multiple ingredients, add the word "Fusion" to the end but otherwise, add "Smoothie".
Ingredient	Price
Strawberries	£1.50
Banana	£0.50
Mango	£2.50
Blueberries	£1.00
Raspberries	£1.00
Apple	£1.75
Pineapple	£3.50
 */

List<string> sarasas1 = new List<string>() { "Strawberries", "Banana", "Blueberries", "Raspberries", "Apple", "Raspberries" };
Smoothie kokteilis1 = new Smoothie(sarasas1);
Console.WriteLine($"Kokteilių savikaina lygi {kokteilis1.GetCost()}eur.");
Console.WriteLine($"Kokteilių pardavimo kaina yra {kokteilis1.GetPrice(kokteilis1.GetCost())}eur");
kokteilis1.GetName(sarasas1);
