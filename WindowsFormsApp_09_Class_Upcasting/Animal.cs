using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_09_Class_Upcasting
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal() { }

        public void Speak()
        {
            Console.WriteLine($"{Name} crys");
        }

    }
    public class Dog : Animal
    {
        public string ani_Sound = "Bow wow";

        public void d_Speak()
        {
            Console.WriteLine($"Dog barks {ani_Sound}");
        }
    }
    
    public class Cat : Animal
    {
        public string ani_Sound = "Meow";
        public void c_Speak()
        {
            Console.WriteLine($"Cat goes {ani_Sound}");
        }
    }

    public class Bird : Animal
    {
        public string ani_Sound = "Chirp";
        public void b_Speak()
        {
            Console.WriteLine($"Bird says {ani_Sound}");
        }
    }
}
