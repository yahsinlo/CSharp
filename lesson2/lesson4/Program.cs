﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            Console.WriteLine(person.getage());
            Console.WriteLine(Person.getsix());
            Console.WriteLine(person.Age);
            person.Age = 12;
            Console.WriteLine(person.getage()); //10-10
            Console.WriteLine(person.Gername());
        }
    }
    class Person : man, Isuper
    {
        int age=15;

        public int Age
        {
            get
            {
                return age + 10;  //15+10
            }
            set
            {
                age = value - 10;  //10-10
            }
        }

        /*public Person(int myage)
        {
            age = myage;
        }*/
        public int getage()
        {
            return age;
        }
        public static int getsix()
        {
            return 6;
        }
        public int Getsuper()
        {
            return age * 80;
        }

        public override int GetAbstract()
        {
            throw new NotImplementedException();
        }
    }

    abstract class man
    {
        public string name;

        public string Gername()
        {
            return name;
        }
        public abstract int GetAbstract();
    }
    interface Isuper
    {
        //int name;
        int Getsuper();
    }
}
