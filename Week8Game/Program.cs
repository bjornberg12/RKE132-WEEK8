string filePath = "/Users/hugoliivaleht/projects/data/villains.txt";
string[] dataFromFile = File.ReadAllLines(filePath);
foreach (string element in dataFromFile)
{
    Console.WriteLine(element);
}

string folderPath = "/Users/hugoliivaleht/projects/data/heroes.txt";
string[] dataFromFiles = File.ReadAllLines(folderPath);
foreach (string element in dataFromFiles)
{
    Console.WriteLine(element);
}




//string[] heroes = { "Harry Potter", "Lara Croft", "Patrick", "Luke Skywalker" };
//string[] villains = { "Doofenzmirts", "Darth Vader", "Dexter"};

string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "Lego" };
string hero = GetRandomValueFromArray(filePath);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");



string villain = GetRandomValueFromArray(folderPath);
string villainWeapon = GetRandomValueFromArray(weapon);

Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}
