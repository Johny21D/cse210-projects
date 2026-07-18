using System;
using System.Linq;

namespace PickleballTracker
{
    public class Program
    {
        private static Player PromptForPlayer(League league, string prompt)
        {
            Console.Write(prompt);
            string name = Console.ReadLine();
            Player p = league.FindPlayer(name);
            if (p == null)
            {
                Console.WriteLine("  No player named \"" + name + "\" found.");
            }
            return p;
        }

        private static Score PromptForScore()
        {
            int s1 = PromptForInt("Score for side 1: ");
            int s2 = PromptForInt("Score for side 2: ");
            return new Score(s1, s2);
        }

        private static int PromptForInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                int value;
                if (int.TryParse(Console.ReadLine(), out value)) return value;
                Console.WriteLine("Please enter a number.");
            }
        }

        private static string PromptForDate()
        {
            Console.Write("Date (e.g. 2026-07-06): ");
            return Console.ReadLine();
        }

        public static void Main()
        {
            League league = new League();
            StatTracker stats = new StatTracker(league);

            Console.WriteLine("=== Pickleball Match Tracker ===");

            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("1. Add player");
                Console.WriteLine("2. Record singles match");
                Console.WriteLine("3. Record doubles match");
                Console.WriteLine("4. Show all matches");
                Console.WriteLine("5. Show player stats");
                Console.WriteLine("6. Head-to-head");
                Console.WriteLine("7. Quit");

                int choice = PromptForInt("Choice: ");

                if (choice == 1)
                {
                    Console.Write("Player name: ");
                    string name = Console.ReadLine();
                    if (league.AddPlayer(name) != null)
                    {
                        Console.WriteLine("Added " + name + ".");
                    }
                    else
                    {
                        Console.WriteLine("A player with that name already exists.");
                    }
                }
                else if (choice == 2)
                {
                    Player p1 = PromptForPlayer(league, "Side 1 player: ");
                    Player p2 = PromptForPlayer(league, "Side 2 player: ");
                    if (p1 == null || p2 == null || p1 == p2)
                    {
                        Console.WriteLine("Need two different existing players.");
                        continue;
                    }
                    string date = PromptForDate();
                    Score score = PromptForScore();
                    league.RecordMatch(new SinglesMatch(date, score, p1, p2));
                    Console.WriteLine("Singles match recorded.");
                }
                else if (choice == 3)
                {
                    Player a = PromptForPlayer(league, "Team 1, player 1: ");
                    Player b = PromptForPlayer(league, "Team 1, player 2: ");
                    Player c = PromptForPlayer(league, "Team 2, player 1: ");
                    Player d = PromptForPlayer(league, "Team 2, player 2: ");

                    Player[] four = { a, b, c, d };
                    bool anyMissing = four.Contains(null);
                    bool anyDuplicate = four.Distinct().Count() != 4;
                    if (anyMissing || anyDuplicate)
                    {
                        Console.WriteLine("Need four different existing players.");
                        continue;
                    }
                    string date = PromptForDate();
                    Score score = PromptForScore();
                    league.RecordMatch(new DoublesMatch(date, score,
                                                        new Team(a, b),
                                                        new Team(c, d)));
                    Console.WriteLine("Doubles match recorded.");
                }
                else if (choice == 4)
                {
                    if (league.GetMatches().Count == 0)
                    {
                        Console.WriteLine("No matches recorded yet.");
                    }
                    foreach (Match m in league.GetMatches())
                    {
                        Console.WriteLine(m.GetSummary());
                    }
                }
                else if (choice == 5)
                {
                    if (league.GetPlayers().Count == 0)
                    {
                        Console.WriteLine("No players yet.");
                    }
                    foreach (Player p in league.GetPlayers())
                    {
                        stats.PrintPlayerReport(p);
                    }
                }
                else if (choice == 6)
                {
                    Player a = PromptForPlayer(league, "First player: ");
                    Player b = PromptForPlayer(league, "Second player: ");
                    if (a == null || b == null || a == b)
                    {
                        Console.WriteLine("Need two different existing players.");
                        continue;
                    }
                    Console.WriteLine(stats.GetHeadToHead(a, b));
                }
                else if (choice == 7)
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Unknown option.");
                }
            }

            Console.WriteLine("Goodbye!");
        }
    }
}