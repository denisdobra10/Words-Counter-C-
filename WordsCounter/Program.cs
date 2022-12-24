using WordsCounter;

internal class Program
{
    private static void Main(string[] args)
    {
        int counter = 0;

        while(true)
        {
            counter++;
            RunProgram();

            Console.Write("Do you wish to continue? (y/n): ->");
            if (Console.ReadLine().ToLower().Contains('n'))
                break;
            else
                Console.WriteLine();
        }

        Console.Write("\nThanks for using the program.\nYou have used the alogirthm " + counter + " times!");

    }


    private static void RunProgram()
    {
        Console.Write("Enter sentence: ");
        Counter wordCounter = new Counter(Console.ReadLine());

        Console.WriteLine("The user given sentence is: " + wordCounter.GetSentence());
        Console.WriteLine("The sentence has: " + wordCounter.GetSentenceLength() + " characters including whitespaces" +
            " and " + wordCounter.GetSentenceLengthWithoutWhiteSpaces() + " characters not including the white spaces!");
        Console.WriteLine("");

        Console.WriteLine("Sentence has " + wordCounter.GetWordsCount() + " words");
        Console.WriteLine("");

        Console.WriteLine("List of words and number of times the specific words appeared in the sentence: ");
        foreach (string word in wordCounter.GetWordsDictionary().Keys)
        {
            Console.WriteLine("Word '" + word + "' appeared " + wordCounter.GetWordsDictionary()[word] + " times!");
        }
    }


}