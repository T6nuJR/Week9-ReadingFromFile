
string fileDirectoryPath = @"C:\data";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDirectoryPath, fileName);

ReadFromFile(fullFilePath);

static void DisplayDataFromArry(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

static void ReadFromFile(string filePath)
{
    if (File.Exists(filePath))
    {
        string[] tempArray = File.ReadAllLines(filePath);
        Console.WriteLine($"There are {tempArray.Length} lines in the file.");
        Console.WriteLine("Do ylu want to sea all lines or pick a random one? all/random");
        string userChoise = Console.ReadLine();

        if (userChoise == "all")
        {
            DisplayDataFromArry(tempArray);
        }
        else if (userChoise == "random")
        {
            DisplayRandomElement(tempArray);
        }
        else
        {
            Console.WriteLine("Try again.");
        }

    }
    else
    {
        Console.WriteLine($"File was not found.");
    }
}

static void DisplayRandomElement(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    Console.WriteLine(someArray[randomIndex]);
}