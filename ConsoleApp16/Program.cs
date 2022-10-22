using ConsoleApp16;
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Group g = new Group();
        //g.AddStudent("Vasya");
        //g.AddStudent("Petya");
        //Console.WriteLine(g[0]);
        Student[] people =
        {
               new Student() { Name = "Артур", Surname = "Кукурузов", Birthday = new MyDate() },
               new Student() { Name = "Гена", Surname = "Кукурузов", Birthday = new MyDate() },
               new Student() { Name = "Стас", Surname = "Кукурузов", Birthday = new MyDate() },
               new Student() { Name = "Влад", Surname = "Кукурузов", Birthday = new MyDate() },
               new Student() { Name = "Миша", Surname = "Кукурузов", Birthday = new MyDate() },
               new Student() { Name = "Гриша", Surname = "Кукурузов", Birthday = new MyDate() },
               new Student() { Name = "Даня", Surname = "Кукурузов", Birthday = new MyDate() },
               new Student() { Name = "Степа ", Surname = "Кукурузов", Birthday = new MyDate() }
        };

        Array.Sort(people);
        foreach (var person in people)
        {
            Console.WriteLine(person.Name + " " + person.Surname + " " + person.Birthday);
        }
        string myString = string.Empty;
        while (myString != "0")
        {
            char[] arr = (myString = Console.ReadLine()).ToCharArray();
            //Array.Sort(arr, new Student());
            Console.WriteLine(arr);
        }
        Console.ReadKey(true);
    }

}
