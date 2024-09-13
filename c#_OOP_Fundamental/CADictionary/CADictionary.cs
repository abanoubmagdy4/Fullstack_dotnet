using System;
namespace CADictionary {
    class Program {
        static void Main(string[] args) {
            var article = "dot net is a free " +
                "for Building many Different Types" +
                "With Dot Net You Can Use Multiple Language" +
                "To Build for Web And IoT Zeko zeko";

            Dictionary<char, List<string>> lettersDictionary = new Dictionary<char, List<string>>();

            foreach (var world in article.Split())
            {
                foreach (var ch in world) {
                    char c = Char.ToLower(ch);
                    if (!lettersDictionary.ContainsKey(c))
                    {
                        lettersDictionary.Add(c, new List<string> { world.ToLower() }); // new list to add results
                    }
                    else
                    {
                        lettersDictionary[c].Add(world);
                    }
                }
            }
            foreach (var entry in lettersDictionary) {
                Console.WriteLine($"'{entry.Key}' ");
                foreach (var word in entry.Value) {
                Console.WriteLine($"\t \t \"{word}\" ");
                }
                
            }


           
            Console.ReadKey();
        }
    
    }
}
