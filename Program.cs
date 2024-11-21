using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo danh sách học sinh
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Huy", Age = 15 },
            new Student { Id = 2, Name = "Linh", Age = 16 },
            new Student { Id = 3, Name = "Bao", Age = 17 },
            new Student { Id = 4, Name = "Dang", Age = 18 },
            new Student { Id = 5, Name = "Hien", Age = 18 }
        };

        // a. In danh sach toan bo hoc sinh
        Console.WriteLine("Danh sach Hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // b. Tim va in ra danh sach cac hoc sinh co tuoi tu 15 đen 18
        var age15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
        Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
        foreach (var student in age15to18)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // c. Tim và in ra hoc sinh co ten bat đau bang chu "A"
        var nameStartsWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
        Console.WriteLine("\nHoc sinh có ten bat đau bang chu 'A':");
        foreach (var student in nameStartsWithA)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // d. Tinh tong tuoi cua tat ca hoc sinh
        var totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

        // e. Yim va in ra hoc sinh co tuoi lon nhat
        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        Console.WriteLine($"\nHoc sinh co tuoi lon nhat: Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        // f. Sap xep danh sach theo tuoi tang dan va in ra
        var sortedByAge = students.OrderBy(s => s.Age).ToList();
        Console.WriteLine("\nDanh sach hoc sinh sap xep theo tuoi tang dan:");
        foreach (var student in sortedByAge)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}
