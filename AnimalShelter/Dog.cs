using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public enum DogBreed { Mixed, Bulldog, Jindo, Yorkshire }
    
    public class Dog
    {

        public string Name;
        public string Color;
        public string Gender;
        public string Description;
        public DogBreed bread;

        public Dog(string name, string color, string gender, DogBreed bread)
        {
            Name = name;
            Color = color;
            Gender = gender;
            bread = bread;
        }

        public string MakeSound()
        {
            return "멍멍";
        }

        public string Bite()
        {
            return "물어뜯기";
        }
    }
}
