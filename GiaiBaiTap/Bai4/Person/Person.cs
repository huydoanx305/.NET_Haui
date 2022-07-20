﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        public int id { get; set; }
        public String name { get; set; }
        public int age { get; set; }
        public String email { get; set; }
        public String address { get; set; }

        public static int Id = 100;
        
        public Person() { }
        public Person (String name, int age, String email, String address)
        {
            id = Id++;
            this.name = name;
            this.age = age;
            this.email = email;
            this.address = address;
        }
        public void CheckAge()
        {
            if (age > 17)
                Console.WriteLine("Bạn đủ tuổi bầu cử");
            else
                Console.WriteLine("Bạn còn nhỏ");
        }

        public void input()
        {
            Console.Write("Nhập id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập name: ");
            name = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập emai: ");
            email = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập address: ");
            address = Convert.ToString(Console.ReadLine());

        }

        public void output()
        {
            Console.WriteLine($"{id,5} {name,10} {age,10} {email,10} {address,10}");
        }
    }
}