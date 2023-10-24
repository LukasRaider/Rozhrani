using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani2;
abstract class Animal
{
    public String name;
    public Animal(String name) { this.name = name; }
}
class Dog : Animal
{
    Boolean isPedigree;
    public Dog(String name)
      : base(name)
    {
    }
    public String sound() { return "haf"; }
}
class Cat : Animal
{
    Boolean isPedigree;
    public Cat(String name)
      : base(name)
    {
    }
    public String sound() { return "mňau"; }
}
class Turtle : Animal
{
    int speed;
    public Turtle(String name)
      : base(name)
    {
    }
}
class Rozhrani
{
    public static void Mainx(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        animals.Add(new Dog("Olik"));
        animals.Add(new Cat("Micka"));
        animals.Add(new Turtle("Jan"));
        animals.Add(new Dog("Jolka"));
        animals.Add(new Cat("Mazel"));

        foreach (var animal in animals)
        {
            Console.Write($"{animals.GetType().Name} se jmenuje ");
            Console.WriteLine(animals);
            Console.WriteLine(animals);//2. krok
            //Console.WriteLine(animals.name);
        }
    }
}
