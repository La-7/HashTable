﻿using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            var superHashTable = new SuperHachTable<Person>(100);
            var person = new Person() { Name = "Вася", Age = 18, Gender = 0 };
            superHashTable.Add(new Person() { Name = "Петя", Age = 28, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Андрей", Age = 10, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Алиса", Age = 20, Gender = 1 });
            superHashTable.Add(person);
            
            Console.WriteLine(superHashTable.Search(new Person() { Name = "Вася", Age = 18, Gender = 0 }));
            Console.WriteLine(superHashTable.Search(person));

            Console.ReadLine();

            var hashTable = new HashTable<int, string>(100);
            hashTable.Add(5, "Привет");
            hashTable.Add(18, "Мир" );
            hashTable.Add(777, "Здравствуй");
            hashTable.Add(7, "Программист");

            Console.WriteLine(hashTable.Search(6, "Вася"));
            Console.WriteLine(hashTable.Search(18, "Мир"));

            Console.ReadLine();

            var badHashTable = new BadHashTable<int>(100);
            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(777);

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));

            Console.ReadLine();
        }
    }
}
