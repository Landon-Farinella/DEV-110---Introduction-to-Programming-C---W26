/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Landon Farinella
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

namespace MadLibs;

public class Program
{
    public class Programmer
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Mad Libs ===");
            Console.WriteLine();

            bool playAgain;

            do
            {
                StoryTemplate template = ChooseTemplate();
                Console.WriteLine();

                string[] words = CollectWords(template);
                string story = template.GenerateStory(words);

                Console.WriteLine();
                Console.WriteLine(story);
                Console.WriteLine();

                playAgain = ReadYesNo("Play again? (y/n): ");
                Console.WriteLine();
            }
            while (playAgain);
        }

        private static StoryTemplate ChooseTemplate()
        {
            Console.WriteLine("Choose a template:");
            Console.WriteLine("1) Debugging at the Zoo");
            Console.WriteLine("2) The Standup Meeting");
            Console.WriteLine();

            int choice = ReadIntInRange("Enter choice (1-2): ", 1, 2);

            if (choice == 1)
            {
                return new StoryTemplate(
                    "Debugging at the Zoo",
                    new string[]
                    {
                        "Adjective",
                        "Animal",
                        "Verb (past tense)",
                        "Noun",
                        "Adverb"
                    },
                    "Today I saw a {0} {1} that {2} into a {3} {4}."
                );
            }
            else
            {
                return new StoryTemplate(
                    "The Standup Meeting",
                    new string[]
                    {
                        "Job title",
                        "Adjective",
                        "Verb",
                        "Noun",
                        "Emotion"
                    },
                    "At the standup meeting, the {0} felt {4} after trying to {2} the {3} in a very {1} way."
                );
            }
        }

        private static string[] CollectWords(StoryTemplate template)
        {
            string[] words = new string[template.Prompts.Length];

            for (int i = 0; i < template.Prompts.Length; i++)
            {
                words[i] = ReadNonEmptyString(template.Prompts[i] + ": ");
            }

            return words;
        }

        private static bool ReadYesNo(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = (Console.ReadLine() ?? "").Trim().ToLower();

                if (input == "y") return true;
                if (input == "n") return false;

                Console.WriteLine("Please enter 'y' or 'n'.");
            }
        }

        private static int ReadIntInRange(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? "";

                if (int.TryParse(input, out int number) && number >= min && number <= max)
                    return number;

                Console.WriteLine($"Please enter a number between {min} and {max}.");
            }
        }

        private static string ReadNonEmptyString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = (Console.ReadLine() ?? "").Trim();

                if (!string.IsNullOrWhiteSpace(input))
                    return input;

                Console.WriteLine("Input cannot be empty.");
            }
        }
    }
}
