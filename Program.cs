using System.Runtime.InteropServices;

namespace AnimalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of different animal types.
            Dog myDog = new Dog();
            Cat myCat = new Cat();
            Bear myBear = new Bear();
            GoldenRetriever myGolden = new GoldenRetriever();
            Husky myHusky = new Husky();

            // Output the sounds each animal makes.
            Console.Write("Min hund säger: ");
            myDog.makeSound();
            Console.Write("Min katt säger: ");
            myCat.makeSound();
            Console.Write("Min björn säger: ");
            myBear.makeSound();
            Console.Write("Min Golden Retriever säger: ");
            myGolden.makeSound();
            Console.Write("Min Husky säger: ");
            myHusky.makeSound();
        }
    }
    public class Animal
    {
        // Base class for all animals
        public int _numberOfEyes;
        public int _numberOfLegs;
        public bool _haveFur;
        public bool _haveClaws;
        public bool _canClimb;
        public bool _canHunt;
        public string _color;

        public Animal()
        {
            // Default attributes for an animal.
            _numberOfEyes = 2;
            _numberOfLegs = 4;
            _haveFur = true;
            _haveClaws = true;
            _canClimb = false;
            _canHunt = false;
            _color = "Okänd"; // Default color is "Okänd" (unknown).
        }
        public virtual void makeSound()
        {
            // This method should be overridden by derived classes.
        }
        public void Jump()
        {
            // Some common action for jumping.
        }
        public void Eat()
        {
            // Some common action for eating.
        }
    }
    // Define a Cat class that inherits from the Animal class.
    public class Cat : Animal
    {
        public bool _hatesWater;
        // Constructor for the Cat class.
        public Cat()
        {
            _hatesWater = true;
            _canClimb = true;
            _canHunt = true;
        }
        // Override the makeSound method to define the cat's sound.
        public override void makeSound()
        {
            Console.WriteLine("Mjau!");
        }
    }
    // Define a Bear class that inherits from the Animal class.
    public class Bear : Animal
    {
        public bool _likesBerries;
        // Constructor for the Bear class.
        public Bear()
        {
            _likesBerries = true;
            _canClimb = true;
            _canHunt = true;
        }
        // Override the makeSound method to define the bear's sound.
        public override void makeSound()
        {
            Console.WriteLine("Vrål!");
        }
    }
    // Define a Dog class that inherits from the Animal class.
    public class Dog : Animal
    {
        public bool _canFetch;
        // Constructor for the Dog class.
        public Dog()
        {
            _canFetch = true;
            _canClimb = false;
        }
        // Override the makeSound method to define the dog's sound.
        public override void makeSound()
        {
            Console.WriteLine("Voff!");
        }
    }
    // Define a GoldenRetriever class that inherits from the Dog class.
    public class GoldenRetriever : Dog 
    {
        // Constructor for the GoldenRetriever class.
        public GoldenRetriever()
        {
            _color = "Guldig";
        }
        // Define a Play method specific to Golden Retrievers.
        public void Play()
        {
        }
    }
    // Define a Husky class that inherits from the Dog class.
    public class Husky : Dog
    {
        // Constructor for the Husky class.
        public Husky()
        {
            _color = "Svart-vit";
        }
        // Define a Howl method specific to Huskies.
        public void Howl()
        {
        }
    }
}