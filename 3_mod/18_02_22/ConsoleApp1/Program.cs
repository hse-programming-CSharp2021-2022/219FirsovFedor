using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Task_01
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student() { }
        public Student(string name, int year)
        {
            Name = name; Grade = year;
        }
    }

    [Serializable]
    public class Group
    {
        [JsonInclude]
        public List<Student> Data { get; set; }
        [JsonInclude]
        public string Name { get; set; }
        public Group() { }
        public Group(List<Student> data, string name)
        {
            Data = data; Name = name;
        }
        public override string ToString()
        {
            string ans = "";
            foreach (var elem in Data)
            {
               ans += $"{elem.Name} - {elem.Grade}\n";
            }
            return ans;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> classSample = new List<Student>();
            classSample.Add(new Student("Morty", 1));
            classSample.Add(new Student("Jessica", 2));

            Group sample = new Group(classSample, "sample");

            BinaryFormatter formatter = new BinaryFormatter();
            
            using (FileStream file = new FileStream("data1.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, sample);
            }
            using (FileStream file = new FileStream("data1.txt", FileMode.OpenOrCreate))
            {
                Group groupFile = (Group)formatter.Deserialize(file);
                Console.WriteLine(groupFile);
            }


            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Group));
            using (FileStream file =
                new FileStream("data3.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, sample);
            }
            using (FileStream file =
                new FileStream("data3.txt", FileMode.OpenOrCreate))
            {
                Group groupFile = (Group)xmlSerializer.Deserialize(file);
                Console.WriteLine(groupFile);
            }

            string json = JsonSerializer.Serialize<Group>(sample);
            Console.WriteLine(json);
            Group person1 = JsonSerializer.Deserialize<Group>(json);
            Console.WriteLine(person1.Name);
            using (FileStream file = new FileStream("people5.txt", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<Group>(file, person1);
            }
            using (FileStream file =
                new FileStream("people5.txt", FileMode.OpenOrCreate))
            {
                var personFile = JsonSerializer.DeserializeAsync<Group>(file);
                Console.WriteLine(personFile);
            }
        }
           
    }
}