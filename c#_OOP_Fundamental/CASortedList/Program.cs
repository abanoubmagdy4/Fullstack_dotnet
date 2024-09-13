using System;
using System.Collections.Generic;

namespace CASortedList { 
    class Program {
    static void Main(string[] args)
    {

            var Hom = new List<Home>() {
           new Home{Id = 1 ,Address = "94 214 street Gaber bn haian east of mallawi" , Area=80m },
           new Home{Id = 2 ,Address = "abo nabil  mallawi" , Area=300m },
           new Home{Id = 3 ,Address = "215 street mallawi" , Area=200m },
           new Home{Id = 4 ,Address = "5 s of mallawi" , Area=60m },
           new Home{Id = 4 ,Address = "abdelmn3m zarzor mallawi" , Area=150m },
           new Home{Id = 6 ,Address = "mostafa kamel mallawi" , Area=45m },

    };
            Console.WriteLine("print before sorted set");
            foreach (var hom in Hom)
            {
                Console.WriteLine(hom);
            }
            Console.WriteLine("print after sorted set");
            var HomeSortedSet1 = new SortedSet<Home>(Hom);
            foreach (var hom in HomeSortedSet1)
            {
                Console.WriteLine(hom);
            }

            Console.WriteLine("===================");
            var HomeHashSet1 = new HashSet<Home>(Hom);
            HomeHashSet1.Add(new Home { Id = 4, Address = "5 s of mallawi", Area = 60m });
            foreach (var hom in HomeHashSet1)
            {
                Console.WriteLine(hom);
            }
            Console.WriteLine("===================\n\n\n");
            
            var HomeHashSet2 = new HashSet<Home>(HomeSortedSet1);
            HomeHashSet2.Add(new Home { Id = 4, Address = "5 s of mallawi", Area = 60m });
            foreach (var hom in HomeHashSet2)
            {
                Console.WriteLine(hom);
            }




        }//End Of Main

    }// End Of Class Program
    class Home : IComparable<Home> {
        public int Id { get; set; }
        public string Address { get; set; }
        public decimal Area { get; set; }

        //Home(int id  , string address , decimal area) {
        //    Id = id;
        //    Address = address;
        //    Area = area;
        //}
        public override string ToString()
        {
            return $"Home By id:{Id}  and there address {Address} >> Area ={Area} M";
        }
        public int CompareTo(Home other) {
            if (Object.ReferenceEquals(this, other)) { 
             return 0 ;
            }
            if (other is null) {
                return -1;
            }
            return  this.Area.CompareTo(other.Area);
        }

        public override bool Equals(object? obj)
        {
            var home = obj as Home;
            if (obj is null || obj != (obj as Home))
            {
                return false;
            }
            return this.Id.Equals(home.Id);
        }
        public override int GetHashCode()
        {
            var hash = 13;
            hash = (hash *7) + Id.GetHashCode();
            return hash;
        }
    }
}// End Of Namespace
