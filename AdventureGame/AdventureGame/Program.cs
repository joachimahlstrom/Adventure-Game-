
class AdventureGame
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Chronicles of the Lost Realm!");
        Console.WriteLine("In the mystical land of Eldoria, a tale of adventure and destiny unfolds.");

        // Backstory
        Console.WriteLine("\nBackstory:");
        Console.WriteLine("Eldoria was once a realm of prosperity, where magic and mystery intertwined. However, ages ago, a powerful artifact known as the 'Heart of Eternity' was lost, plunging Eldoria into chaos.");
        Console.WriteLine("Legends speak of the Lost Realm, a place where the Heart of Eternity lies hidden, waiting for a brave adventurer to claim it.");
        Console.WriteLine("\nYou, a young and daring adventurer named Alex, have discovered an ancient map pointing to the Lost Realm.");
        Console.WriteLine("Your quest begins now, as you journey through enchanted forests, treacherous swamps, ancient temples, and shadowy cities.");

        // Prompt to Continue
        Console.WriteLine("\nPress Enter to begin your adventure...");
        Console.ReadLine();
        Console.Clear(); // Clear the console before presenting Chapter 1

        // Chapter 1: The Enchanted Forest
        Console.WriteLine("Chapter 1: The Enchanted Forest");
        Console.WriteLine("Will you help the elves or sneak away? (Type 'help' or 'sneak')");
        string choiceChapter1 = Console.ReadLine().ToLower();

        if (choiceChapter1.Contains("help"))
        {
            Console.WriteLine("You helped the elves and gained their trust!");
        }
        else if (choiceChapter1.Contains("sneak"))
        {
            Console.WriteLine("You decided not to help the elves and formed an alliance with dark creatures!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please type 'help' or 'sneak'.");
            return;
        }

        // Chapter 2: The Crossroads
        Console.WriteLine("\nChapter 2: The Crossroads");
        Console.WriteLine("Will you brave the Swamp of Shadows or explore the Whispering Caves? (Type 'swamp' or 'whisper')");
        string choiceChapter2 = Console.ReadLine().ToLower();

        if (choiceChapter2.Contains("swamp"))
        {
            Console.WriteLine("You navigated the Swamp of Shadows, discovering hidden treasures or facing unexpected challenges!");
        }
        else if (choiceChapter2.Contains("whisper"))
        {
            Console.WriteLine("You explored the Whispering Caves, gaining valuable knowledge or encountering ghostly apparitions!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please type 'swamp' or 'whisper'.");
            return;
        }

        // Chapter 3: The Ancient Temple
        Console.WriteLine("\nChapter 3: The Ancient Temple");
        Console.WriteLine("Will you use the artifact for good or unleash a dark force? (Type 'good' or 'dark')");
        string choiceChapter3 = Console.ReadLine().ToLower();

        if (choiceChapter3.Contains("good"))
        {
            Console.WriteLine("You used the artifact positively, gaining immense power and trust from allies!");
        }
        else if (choiceChapter3.Contains("dark"))
        {
            Console.WriteLine("You used the artifact negatively, facing complications and potential distrust!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please type 'good' or 'dark'.");
            return;
        }

        // Chapter 4: The City of Shadows
        Console.WriteLine("\nChapter 4: The City of Shadows");
        Console.WriteLine("Will you confront the sorcerer or plan a rebellion? (Type 'confront' or 'rebellion')");
        string choiceChapter4 = Console.ReadLine().ToLower();

        if (choiceChapter4.Contains("confront"))
        {
            Console.WriteLine("You confronted the sorcerer, gaining respect or fear, with potential consequences!");
        }
        else if (choiceChapter4.Contains("rebellion"))
        {
            Console.WriteLine("You had a successful rebellion with unexpected alliances or challenges!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please type 'confront' or 'rebellion'.");
            return;
        }

        // Chapter 5: The Final Confrontation
        Console.WriteLine("\nChapter 5: The Final Confrontation");
        Console.WriteLine("Have your alliances and choices prepared you for the final battle? (Type 'yes' or 'no')");
        string choiceChapter5 = Console.ReadLine().ToLower();

        if (choiceChapter5.Contains("yes"))
        {
            Console.WriteLine("You achieved a more favorable outcome with potential rewards!");
        }
        else if (choiceChapter5.Contains("no"))
        {
            Console.WriteLine("You faced a more difficult battle with potential negative consequences!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please type 'yes' or 'no'.");
            return;
        }

        // Epilogue
        Console.WriteLine("\nEpilogue");
        Console.WriteLine("Did your choices shape Eldoria's fate, and how will its inhabitants remember you? (Type 'yes' or 'no')");
        string choiceEpilogue = Console.ReadLine().ToLower();

        if (choiceEpilogue.Contains("yes"))
        {
            Console.WriteLine("You had a positive influence, leaving a lasting legacy!");
        }
        else if (choiceEpilogue.Contains("no"))
        {
            Console.WriteLine("Eldoria coped with challenges, and you left a more mysterious legacy!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please type 'yes' or 'no'.");
            return;
        }

        Console.WriteLine("\nThanks for playing the Chronicles of the Lost Realm!");
    }
}
