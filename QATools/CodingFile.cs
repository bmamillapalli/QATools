using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace QATools
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return string.Format("Name:{0} \nAge:{1}", name, age);
        }
    }

    class Program
    {
        public static void JsonEx()
        {
            String JSONString = File.ReadAllText("a.json");

            /* ONe way*/
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Person p1 = ser.Deserialize<Person>(JSONString);
            Console.WriteLine(p1);

            /*Second Way*/
            Person p2 = JsonConvert.DeserializeObject<Person>(JSONString);
            Console.WriteLine(p2);

            /*To JSON One Way*/
            Person p3 = new Person() { name = "Kowsik", age = 18 };
            JavaScriptSerializer ser1 = new JavaScriptSerializer();
            string JSONOut = ser1.Serialize(p3);
            File.WriteAllText("b.json", JSONOut);

            /*To JSON Second Way*/
            Person p4 = new Person { name = "Ganesh", age = 50 };
            string JsonOutput = JsonConvert.SerializeObject(p4);
            File.WriteAllText("c.json", JsonOutput);



            Console.Read(); 
        }
    }
}
