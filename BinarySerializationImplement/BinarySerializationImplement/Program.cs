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
                Salary = 50000.00
            }; 
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream fs = new FileStream("D:\\Company\\.net\\Day21\\Assignment24\\employee.bin",FileMode.Create))
            {
                formatter.Serialize(fs, employee);
                Console.WriteLine("Created and Serialized");
                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Salary);

            }
            using (FileStream fs = new FileStream("D:\\Company\\.net\\Day21\\Assignment24\\employee.bin", FileMode.Open))
            {
                Employee deserialize = (Employee)formatter.Deserialize(fs);
                Console.WriteLine("De-Serialized");
                Console.WriteLine(deserialize.Id);
                Console.WriteLine(deserialize.FirstName);
                Console.WriteLine(deserialize.LastName);
                Console.WriteLine(deserialize.Salary);

            }
            Console.ReadKey();
        }
    }
}
