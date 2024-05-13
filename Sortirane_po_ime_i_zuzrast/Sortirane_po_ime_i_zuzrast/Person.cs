﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortirane_po_ime_i_zuzrast
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public string FirstName
        {
            get { return this.firstName; }
        }
        public int Age
        { 
            get { return this.age; } 
        }
        public string LastName
        {
            get { return this.lastName; }
        }
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} is a {this.age} years old.";
        }
    }
}
