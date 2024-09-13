using System;
using System.Collections.Generic;
using System.Reflection;
namespace CALinkedList {
    class Program
    {
        static void Main(string[] aegs)
        {
            var lesson1 = new YouyubeVideos { ID = "ytv1", Title = "variables", Duration = new TimeSpan(00,30,00)};
            var lesson2 = new YouyubeVideos { ID = "ytv2", Title = "dataType" , Duration = new TimeSpan(00,30,00)};
            var lesson3 = new YouyubeVideos { ID = "ytv3", Title = "array",     Duration = new TimeSpan(00,30,00)};
            var lesson4 = new YouyubeVideos { ID = "ytv4", Title = "stack",     Duration = new TimeSpan(00,30,00)};
            var lesson5 = new YouyubeVideos { ID = "ytv5", Title = "queue",     Duration = new TimeSpan(00,30,00)};
            var lesson6 = new YouyubeVideos { ID = "ytv6", Title = "LinkedList",Duration = new TimeSpan(00,30,00)};
            var lesson7 = new YouyubeVideos { ID = "ytv7", Title = "Trees", Duration = new TimeSpan(00, 30, 00) };

          LinkedList<YouyubeVideos> YTVs1= new LinkedList<YouyubeVideos>(
               new YouyubeVideos[]
              {
                    lesson1 ,  lesson2 , lesson3 , lesson4 , lesson5 , lesson6 , lesson7 
                }
              );

             Print("Learning C# ", YTVs1);

            LinkedList < YouyubeVideos> YTVs2 = new LinkedList<YouyubeVideos>();

            YTVs2.AddFirst(lesson1);
            YTVs2.AddAfter(YTVs2.First, lesson2);
            var node3 = new LinkedListNode<YouyubeVideos>(lesson3);  // add item using constructor of LinkedListNode 
            YTVs2.AddAfter(YTVs2.First.Next, node3);
            var node4 = new LinkedListNode<YouyubeVideos>(lesson4);
            YTVs2.AddAfter(YTVs2.First.Next.Next, node4);
            var node5 = new LinkedListNode<YouyubeVideos>(lesson5);
            YTVs2.AddAfter(YTVs2.First.Next.Next.Next, node5);
            YTVs2.AddLast(lesson7);
            YTVs2.AddBefore(YTVs2.Last, lesson6);

            Print("Learning C# from Zero To Hero", YTVs2);


        }// End Of Main

        static void Print(string title, LinkedList<YouyubeVideos> playlist)
        {
            Console.WriteLine($"Title : ┌{title}");
            foreach (var item in playlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"└");
            Console.WriteLine($"Total : {playlist.Count} items");
              
            }
        
        

    }// End of Class 
        class YouyubeVideos { 
          
           public string ID { get; set; }
           public string Title { get; set; }
           public TimeSpan Duration { get; set; }
        public override string ToString()
        {
            return $"├─{Title} ({Duration})\n│\t https:\\www.youtube.com/watch?v={ID}";
        }

    }
        

}
