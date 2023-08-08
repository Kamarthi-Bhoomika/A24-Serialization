using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EmployeeLib;

namespace XMLSerializationImplement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 11,
                FirstName = "Kamarthi",
                LastName = "Bhoomika",
                Salary = 50000.00
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter("D:\\Company\\.net\\Day21\\Assignment24\\employee.xml"))
            {
                serializer.Serialize(writer, employee);
                Console.WriteLine("De-Serialization");
                Console.WriteLine($"Id: {employee.Id}");
                Console.WriteLine($"First Name: {employee.FirstName}, Last Name: {employee.LastName}");
                Console.WriteLine($"Salary: {employee.Salary}");
            }
            using (TextReader reader = new StreamReader("D:\\Company\\.net\\Day21\\Assignment24\\employee.xml"))
            {
                Employee deserialize = (Employee)serializer.Deserialize(reader);
                Console.WriteLine("De-Serialization");
                Console.WriteLine($"Id: {deserialize.Id}");
                Console.WriteLine($"First Name: {deserialize.FirstName}, Last Name: {deserialize.LastName}");
                Console.WriteLine($"Salary: {deserialize.Salary}");
            }
            Console.ReadKey();
        }
    }
}
