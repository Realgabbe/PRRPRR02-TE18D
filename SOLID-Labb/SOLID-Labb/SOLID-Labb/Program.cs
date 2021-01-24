using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal[] animals = AnimalColour();
            PrintAnimalBehavior(animals);


        }

        static Animal[] AnimalColour() {
            
            Animal[] animals = {new Dog("Black"),
            new Hedgehog("Pink"),
            new Bird("Yellow")};

            Console.WriteLine("###############");
            Console.WriteLine();

            return animals;
        }  

        static void PrintAnimalBehavior(Animal[] animals) {
    
        foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    dog.TransferOwnership("Niklas");
                }

                AnimalBehavior(animal);

                Console.WriteLine("###############");
                Console.WriteLine();
    
            }
        }

        static void AnimalBehavior(Animal animal) {

            animal.Eat();
            animal.Sleep();
            animal.Speak();
            AnimalColour();
            Console.WriteLine(animal.GetType().Name + " is " + animal._color);
            Console.WriteLine();

        }
    }
}
