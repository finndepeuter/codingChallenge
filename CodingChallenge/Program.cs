using CodingChallengeLibrary;

string basePath = Directory.GetCurrentDirectory();
string directory = Path.Combine(basePath, "..", "..", "..");
string filePath = Path.Combine(directory, "input.txt");
string[] wordparts = File.ReadAllLines(filePath);
List<string> words = new List<string>();
List<string> components = new List<string>();
Combination combination = new Combination();

foreach (string part in wordparts)
{
    if (part.Length == 6)
    {
        words.Add(part);

    }else
    {
        components.Add(part);
    }
    
}

string[] wordsArr = words.ToArray();
string[] componentArr = components.ToArray();

Console.WriteLine("How many parts should the words be made up of?");
int amountOfParts;

while (true)
{
    string input = Console.ReadLine();
    if (int.TryParse(input, out amountOfParts))
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number:");
    }
}
combination.FindCombinationMultipleParts(wordsArr, componentArr, amountOfParts);





