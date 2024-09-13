using System;
namespace CAReflection {
    class Program {
        static void Main(string[] args)
        {
            Type t1 = DateTime.Now.GetType(); // at run time 
            Console.WriteLine(t1);
            Type t2 = typeof(DateTime); // at compile time
            Console.WriteLine(t2);
            Console.WriteLine(t1.FullName);
            Console.WriteLine(t1.Name);
            Console.WriteLine(t2.Namespace);
            Console.WriteLine(t1.IsPublic); // check class is public or  not 

            Type t3 = typeof(int[,]);
            Console.WriteLine($"t3 Type : {t3.Name}");
            var nestedTypes = typeof(Employee).GetNestedTypes();
            try
            {
                for (int i = 0; i < nestedTypes.Length; i++)
                {
                    Console.WriteLine(nestedTypes[i]);
                }
            }
            catch {
                Console.WriteLine("error in for loop");
            }

            var t4 = typeof(int);
            var interfaces = t4.GetInterfaces();
            for (int i = 0; i < interfaces.Length; i++)
            {
                Console.WriteLine($"interface number {i + 1} ,{interfaces[i]}");
            }

            Console.Write("Enemy : ");
            do {
                var input = "CAReflection."+Console.ReadLine();
                object obj = null;

                try {
                    var aName = typeof(Program).Assembly.GetName().Name;
                    var enemy = Activator.CreateInstance("CAReflection", input);
                    obj = enemy.Unwrap();
                } catch { }
                switch (obj)
                {
                    case Goon g:
                        Console.WriteLine(g);
                        break;
                    case Shoo s:
                        Console.WriteLine(s);
                        break;
                    case Too t:
                        Console.WriteLine(t);
                        break;
                } while (true) ;

            }while (true);




            Console.ReadKey();
        }
    
    }
    public class Goon {
        public override string ToString()
        {
            return $"{{speed : {20} , HitPower: {15} , Strength{7}}}";
        }

    }
    public class Shoo
    {
        public override string ToString()
        {
            return $"{{speed : {15} , HitPower: {20} , Strength{12}}}";
        }

    }
    public class Too
    {
        public override string ToString()
        {
            return $"{{speed : {11} , HitPower: {14} , Strength{2}}}";
        }

    }


}
