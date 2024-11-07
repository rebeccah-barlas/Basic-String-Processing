bool playAgain = false;
do
{
    Console.WriteLine("Please enter a sentence and I will split the sentence into individual words and display each word on its own line");
    string userInput1 = Console.ReadLine();
    string[] words = userInput1.Split(' ');
    foreach (string word in words)
    {
        Console.WriteLine(word);
    }
    Console.WriteLine("Would you like to continue? (y/n)");
    string userAgree1 = Console.ReadLine().ToLower();
    if (userAgree1 == "y")
    {
        playAgain = true;
    }
    else
    {
        break;
    }
} while (playAgain == true);
Console.WriteLine("Goodbye!");

List<string> userInputs = new List<string>();
string wordStorage = "";
bool continuePrompt = true;
while (continuePrompt == true)
{
    Console.WriteLine("Please enter some text");
    string userInput2 = Console.ReadLine().ToLower();
    wordStorage += " " + userInput2;
    Console.WriteLine($"You have entered:{wordStorage}");
    Console.WriteLine("Would you like to continue? (y/n)");
    string userAgree2 = Console.ReadLine().ToLower();
    if (userAgree2 == "n")
    {
        continuePrompt = false;
    }
    else
    {
        userInputs.Add(wordStorage);
    }
}
string displayMessage = string.Join(" ", wordStorage);
Console.WriteLine($"You have entered: {displayMessage}");
Console.WriteLine("Goodbye!");

// After doing the lab, can you think of any other uses of the string processing methods you used? If statements could help a lot. 

// I used an array for the first exercise and a list for the second exercise. I used an array for the first exercise due to the ability to split the string into sections. This 
// would also be useful for splitting a comma-seperated list of items, removing unwanted characters like spaces, etc. I used a list for the second exercise due to the ability to
// store user input within the list using the add method. Thus, lists can be used as a "container" and are not a fixed size. They can be used to store names, places, etc.




