using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace BinarySerializationImplement
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
                Salary = 41000.00
            };
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream fs = new FileStream("D:\\Mphasis\\.net\\Day21\\Assignment24\\employee.bin",FileMode.Create))
            {
                formatter.Serialize(fs, employee);
                Console.WriteLine("Created and Serialized");
                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Salary);

            }
            using (FileStream fs = new FileStream("D:\\Mphasis\\.net\\Day21\\Assignment24\\employee.bin", FileMode.Open))
            {
                employee = (Employee)formatter.Deserialize(fs);
                Console.WriteLine("De-Serialized");
                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Salary);

            }
            Console.ReadKey();
        }
    }
}
