using System;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;


namespace CASerializationWithJson
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var e1 = new Employee
            {
                Id = 1001,
                Fname = "Issam",
                Lname = "A",
                Benefites = { "pension", "Health Insurance" }
            };
            var xmlContent = SerializeToXmlString(e1);
            Console.WriteLine(xmlContent);
            File.WriteAllText("xmlDocument.xml", xmlContent);

            Employee e2 = DeserializeFromXmlString(xmlContent);
            Console.WriteLine(e2);
            Console.ReadKey();

        }

        private static string SerializeToXmlString(Employee e1)
        {
            var result = "";
            result = JsonSerializer.Serialize(e1 , new JsonSerializerOptions { WriteIndented = true});
            return result;
        }
        private static Employee DeserializeFromXmlString(string xmlContent)
        {
            Employee employee = null;
            employee = JsonSerializer.Deserialize(xmlContent ) ;
            return employee;
        }



    }

    public class Employee
    {

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public List<String> Benefites { get; set; } = new List<String>();

        public override string ToString()
        {
            return $"{Id} \n {Fname} {Lname} Benefits {Benefites} ";
        }
    }
}
