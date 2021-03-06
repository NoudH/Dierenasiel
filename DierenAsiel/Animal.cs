﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel
{
    public class Animal
    {
        public enum Genders
        {
            Male = 0,
            Female = 1
        }
        
        public enum Species
        {
            Dog = 0,
            Cat = 1
        }

        public string name;
        public int age;
        public int weight;
        public Genders gender;
        public Species species;
        public string breed;
        public string image;
        public int cage;
        public bool reserved = false;
        public float price;
        public List<string> characteristics = new List<string>();
        public string about;

        public override string ToString()
        {
            return name;
        }
    }
}
