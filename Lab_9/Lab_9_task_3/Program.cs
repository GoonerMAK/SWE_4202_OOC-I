using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_task_3
{
        // Animal Class
        class Animal
        {
            // private members
            private string nameOfAnimal;
            private string habitat_area;
            private string sound;
            int weight;
            int height;
            int birthYear;

            // default constructor
            public Animal()
            {
                setNameOfAnimal(default(string));
                setHabitatArea(default(string));
                setSound(default(string));
                setWeight(default(int));
                setHeight(default(int));
                setBirthYear(default(int));
            }

            // constructor with parameters
            public Animal(string nameOfAnimal, string habitat_area, string sound, int weight, int height, int birthYear)
            {
                setNameOfAnimal(nameOfAnimal);
                setHabitatArea(habitat_area);
                setSound(sound);
                setWeight(weight);
                setHeight(height);
                setBirthYear(birthYear);
            }

            // getters
            public string getNameOfAnimal() { return nameOfAnimal; }
            public string getHabitatArea() { return habitat_area; }
            public string getSound() { return sound; }
            public int getBirthYear() { return birthYear; }
            public int getWeight() { return weight; }
            public int getHeight() { return height; }
            public void getAge(int currentYear = 2021) { Console.Write("Age: "); Console.Write(currentYear - birthYear); }
            public void getInformation()
            {
                Console.WriteLine("Name of The Animal: {0}", nameOfAnimal);
                Console.WriteLine("Habitat Area: {0}", habitat_area);
                Console.WriteLine("Sound: {0}", sound);
                Console.WriteLine("Weight: {0}", weight);
                Console.WriteLine("Height: {0}", height);
                Console.WriteLine("Birth Year {0}", birthYear);
            }

            // setters
            public void setNameOfAnimal(string nameOfAnimal) { this.nameOfAnimal = nameOfAnimal; }
            public void setHabitatArea(string habitat_area) { this.habitat_area = habitat_area; }
            public void setSound(string sound) { this.sound = sound; }
            public void setBirthYear(int birthYear)
            {
                if (birthYear > 2021)
                    this.birthYear = 2021;
                else
                    this.birthYear = birthYear;
            }

            public void setWeight(int weight) { this.weight = weight; }
            public void setHeight(int height) { this.height = height; }

            // function change weight
            public void changeWeight(int pounds) { this.weight = pounds; }

            // function vocalise to print the sound without newline
            public void vocalize() { Console.Write(sound); }
        }

        // class cow, inherited from animal
        class Cow : Animal
        {
            // default constructor, call base class constructor
            public Cow() : base()
            {
                // set sound of cow
                this.setSound("moo");
            }

            // parameterized constructor, calls base class parameterized constructor
            public Cow(string nameOfAnimal, string habitat_area, string sound, int weight, int height, int birthYear) : base(nameOfAnimal, habitat_area, sound, weight, height, birthYear)
            {
                // set sound of cow
                this.setSound("moo");
            }
        }

        // class chicken, inherited from animal
        class Chicken : Animal
        {
            // default constructor, call base class constructor
            public Chicken() : base()
            {
                // set sound of chicken
                this.setSound("buck buck");
            }

            // parameterized constructor, calls base class parameterized constructor
            public Chicken(string nameOfAnimal, string habitat_area, string sound, int weight, int height, int birthYear) : base(nameOfAnimal, habitat_area, sound, weight, height, birthYear)
            {
                // set sound of chicken
                this.setSound("buck buck");
            }
        }

        // class cat, inherited from animal
        class Cat : Animal
        {
            // default constructor, call base class constructor
            public Cat() : base()
            {
                // set sound of cat
                this.setSound("meow");
            }

            // parameterized constructor, calls base class parameterized constructor
            public Cat(string nameOfAnimal, string habitat_area, string sound, int weight, int height, int birthYear) : base(nameOfAnimal, habitat_area, sound, weight, height, birthYear)
            {
                // set sound of cat
                this.setSound("meow");
            }
        }

        // driver code
        class Program
        {
            static void Main(string[] args)
            {
                // Test Data
                Animal aAnimal = new Animal("Animal", "", "", 0, 0, 0);
                Animal aCow = new Cow("Cow", "", "", 90, 70, 2020);
                Animal aChicken = new Chicken("Chicken", "", "", 6, 15, 2020);
                Animal aCat = new Cat("Cat", "", "", 5, 25, 2015);

                Console.WriteLine("Animal Data:\n");
                Console.WriteLine("A Default Animal: \n");
                aAnimal.getInformation();
                Console.WriteLine("\nA Cow:\n");
                aCow.getInformation();
                Console.WriteLine("\nA Chicken:\n");
                aChicken.getInformation();
                Console.WriteLine("\nA Cat:\n");
                aCat.getInformation();

                Console.WriteLine("\nCow's Age:");
                aCow.getAge();

                Console.WriteLine("\nCat's Age:");
                aCat.getAge();

                Console.WriteLine("\nChicken's Age:");
                aChicken.getAge();

            Console.WriteLine("\n");

                Console.WriteLine("\nSound of Cow, Cat and Chicken respectfully :\n");
                aCow.vocalize();
                Console.WriteLine("\n");
                aCat.vocalize();
                Console.WriteLine("\n");
                aChicken.vocalize();

                Console.ReadKey();
            }
        }
    
}
