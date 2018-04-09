using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace JSONScriptSerializerExample
{
    class Person
    {
        public string name { get; set; }

        public int age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} \nAge: {1}", name, age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //deserializar JSON File
            String JSONstring = File.ReadAllText("JSON.json");

            JavaScriptSerializer ser = new JavaScriptSerializer();
            Person p1 = JsonConvert.DeserializeObject<Person>(JSONstring);
            Console.WriteLine(p1);
            Console.ReadLine();

            //output Json File

            Person p2 = new Person { name = "Ben", age = 8 };
            string outputJSON = JsonConvert.SerializeObject(p2);
            File.WriteAllText("Output.json", outputJSON);

        }
    }
}
