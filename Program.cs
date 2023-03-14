using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
            Queue();
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
            Priority();
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
            Stack();
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
            Linked();
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
            Dictionary();
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
            Sorted();
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
            Hash();
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
            List();
        }

        static void Queue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("barbarian");
            queue.Enqueue("bard");
            queue.Enqueue("paladin");
            queue.Enqueue("ranger");
            queue.Enqueue("wizard");

            var response = "";

            while (true)
            {
                Console.WriteLine("Would you like to search the queue?");
                Console.WriteLine("1 = yes  2 = no");
                response = Console.ReadLine();
                if (response == "1")
                {
                    Console.WriteLine("\nWhat would you like to search?");

                    if (queue.Contains(Console.ReadLine().ToLower()))
                    {
                        Console.WriteLine("TRUE");
                    } else {
                        Console.WriteLine("FALSE");
                    }
                } else if (response == "2") {
                    break;
                } else {
                    Console.WriteLine("\nPlease give a valid response");
                }
            }

            queue.Dequeue();
            var count = queue.Count();
            Console.WriteLine($"\nThe queue contains {count} values.");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        static void Priority()
        {
            PriorityQueue<string, int> classes = new PriorityQueue<string, int>();
            classes.Enqueue("barbarian", 1);
            classes.Enqueue("bard", 2);
            classes.Enqueue("paladin", 1);
            classes.Enqueue("ranger", 2);
            classes.Enqueue("wizard", 3);

            while (classes.TryDequeue(out string item, out int priority))
            {
                Console.WriteLine($"Dequeued Item : {item} Priority Was : {priority}");
            }
        }

        static void Stack()
        {
            Stack<string> classes = new Stack<string>();
            classes.Push("barbarian");
            classes.Push("bard");
            classes.Push("paladin");
            classes.Push("ranger");
            classes.Push("wizard");

            var response = "";

            while (true)
            {
                Console.WriteLine("Would you like to search the queue?");
                Console.WriteLine("1 = yes  2 = no");
                response = Console.ReadLine();
                if (response == "1")
                {
                    Console.WriteLine("\nWhat would you like to search?");

                    if (classes.Contains(Console.ReadLine().ToLower()))
                    {
                        Console.WriteLine("TRUE");
                    }
                    else
                    {
                        Console.WriteLine("FALSE");
                    }
                }
                else if (response == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease give a valid response");
                }
            }

            classes.Pop();
            var count = classes.Count();
            Console.WriteLine($"\nThe queue contains {count} values.");
            foreach (var item in classes)
            {
                Console.WriteLine(item);
            }
        }

        static void Linked()
        {
            LinkedList<string> classes = new LinkedList<string>();
            classes.AddLast("barbarian");
            classes.AddLast("bard");
            classes.AddLast("paladin");
            classes.AddLast("ranger");
            classes.AddLast("wizard");

            Console.WriteLine($"First Node: {classes.First()}");
            Console.WriteLine($"Last Node: {classes.Last()}");

            classes.AddAfter(classes.Find("bard"), "Artificer");
            classes.RemoveFirst();

            var count = classes.Count();
            Console.WriteLine($"\nThe queue contains {count} values.");

            foreach (var item in classes)
            {
                Console.WriteLine(item);
            }
        }

        static void Dictionary()
        {
            Dictionary<string, string> classes = new Dictionary<string, string>();
            classes.Add("barbarian", "None");
            classes.Add("bard", "Full");
            classes.Add("paladin", "Half");
            classes.Add("ranger", "Half");
            classes.Add("wizard", "Full");

            foreach (KeyValuePair <string, string> item in classes)
            {
                Console.WriteLine($"Key: {item.Key}");
            }
            foreach (KeyValuePair<string, string> item in classes)
            {
                Console.WriteLine($"Value: {item.Value}");
            }
            foreach (KeyValuePair<string, string> item in classes)
            {
                Console.WriteLine($"Key: {item.Key}    Value: {item.Value}");
            }

            classes.Remove("barbarian");

            var count = classes.Count();
            Console.WriteLine($"\nThe queue contains {count} values.");
        }

        static void Sorted()
        {
            SortedList<string, string> classes = new SortedList<string, string>();
            classes.Add("barbarian", "None");
            classes.Add("bard", "Full");
            classes.Add("paladin", "Half");
            classes.Add("ranger", "Half");
            classes.Add("wizard", "Full");

            var response = "";
            
            while (true)
            {
                {
                    foreach (KeyValuePair<string, string> item in classes)
                    {
                        Console.WriteLine($"Key: {item.Key}    Value: {item.Value}");
                    }
                    Console.WriteLine("Would you like to change the list?");
                    Console.WriteLine("1 = add  2 = remove  3 = no");
                    response = Console.ReadLine();
                    if (response == "1")
                    {
                        Console.Write("\nPlease enter a key: ");
                        string k = Console.ReadLine();

                        Console.Write("\n Please enter a value: ");
                        string v = Console.ReadLine();

                        classes.Add(k, v);
                    }
                    else if (response == "2")
                    {
                        Console.Write($"\nPlease enter an index to remove (1 = first item and so on): ");
                        int i = int.Parse(Console.ReadLine());

                        classes.RemoveAt(i - 1);
                    }
                    else if (response == "3")
                    {
                        break;
                    }
                }
            }

            foreach (KeyValuePair<string, string> item in classes)
            {
                Console.WriteLine($"Key: {item.Key}    Value: {item.Value}");
            }
        }

        static void Hash()
        {
            HashSet<string> classes = new HashSet<string>();
            classes.Add("barbarian");
            classes.Add("bard");
            classes.Add("paladin");
            classes.Add("ranger");
            classes.Add("wizard");

            HashSet<string> classes2 = new HashSet<string>();
            classes2.Add("artificer");
            classes2.Add("sorcerer");
            classes2.Add("druid");
            classes2.Add("cleric");
            classes2.Add("rogue");

            HashSet<string> classes3 = new HashSet<string>();
            classes3.Add("ranger");
            classes3.Add("paladin");
            classes3.Add("wildheart");
            classes3.Add("warlord");
            classes3.Add("occultist");

            
            classes.UnionWith(classes2);

            foreach(var item in classes)
            {
                Console.WriteLine(item);
            }
            
            HashSet<string> classes4 = new HashSet<string>();
            classes4 = classes;

            classes4.IntersectWith(classes3);

            foreach (var item in classes4)
            {
                Console.WriteLine(item);
            }
        }

        static void List()
        {
            List<string> classes = new List<string> {};
            classes.Add("barbarian");
            classes.Add("bard");
            classes.Add("paladin");
            classes.Add("ranger");
            classes.Add("wizard");

            string[] moreClasses = new string[] { "warlord", "occultist", "psionic", "druid" };
            classes.AddRange(moreClasses);
            classes.Sort();
            foreach (var item in classes)
            {
                Console.WriteLine(item);
            }

            classes.Remove("druid");
            classes.Reverse();
            foreach(var item in classes)
            {
                Console.WriteLine(item);
            }
        }
    }
}