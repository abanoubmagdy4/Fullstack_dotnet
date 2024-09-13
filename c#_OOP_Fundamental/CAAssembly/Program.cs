using System;
using System.Reflection;
namespace CAAssembly
{
    class Program 
    {
        static void Main(string[] args)
        {


            var type = typeof(Program);
            var assembly = type.Assembly;

            var stream = assembly.GetManifestResourceStream(type ,"data.tsconfig1.json");
            var data = new BinaryReader(stream).ReadBytes((int)stream.Length);

            for (int i = 0; i < data.Length; i++) { 
             Console.Write((char)data[i]);
                System.Threading.Thread.Sleep(200);
  
            }   
            stream.Close();
            Console.ReadKey();
             
        }

    }
}
