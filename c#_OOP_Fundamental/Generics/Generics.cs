using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;
namespace Generics
{
    class Program {

        static void Main(string[] args) {

            Print("bbeboo");
            Print(1);
            Print("c");

            static void Print <T> (T t)
            {

                Console.WriteLine($"data type {typeof(T)}");
                Console.WriteLine($"value : {t}");
                Console.WriteLine("================");
            }
            var number = new Any<int>();
            number.Add(1);
            number.Add(2);  
            number.Add(3);
            number.DisplayList();
            Console.WriteLine($"Length : {number.Count} items");
            Console.WriteLine($"\nEmpty : {number.IsEmpty} ");
            number.RemoveAt(1);
            number.DisplayList();
            Console.WriteLine($"Length : {number.Count} items");
            Console.WriteLine($"\nEmpty : {number.IsEmpty} ");

            var people = new Any<Person>();
            people.Add(new Person { Fname = "ali", Lname = "N" });
            people.Add(new Person { Fname = "Beboo", Lname = "Magdy" });
            people.DisplayList();
        }
    }
    public class Person { 
    public string Fname { get; set; }
    public string Lname { get; set; }

        public override string ToString()
        {
            return $"{Fname},{Lname}";
        }

    }
    class Any<T>
    {
        private T[] _items;

        public void Add(T item)
        {
            if (_items is null)
            {
                _items = new T[] { item };  // intilize array with item variable b 

            }
            else
            {
                var length = _items.Length; // to store the size of current array
                var dest = new T[length + 1];

                for (int i = 0; i < length; i++)
                {
                    dest[i] = _items[i];
                }
                dest[dest.Length - 1] = item;
                _items = dest;
            }
        }
        public void RemoveAt(int position) {
            if (position < 0 || position > _items.Length - 1)
            {
                return;
            }
            var index = 0;
            var dest = new T[_items.Length - 1];
            for (int i = 0; i < _items.Length; i++)
            {
                if (position == i)
                    continue;
                dest[index++] = _items[i];
            }
            _items = dest;
            
            }

     public bool IsEmpty => _items is null || _items.Length == 0;
     public int Count  => _items is null ? 0 : _items.Length;

        public void DisplayList() {
            Console.Write("[");
            for (int i = 0; i < _items.Length; i++) {
                Console.Write(_items[i]);
                if (i < _items.Length - 1) { 
                  Console.Write(',');
                
                }
            
            }
            Console.Write("]");
        }
    } 
}
