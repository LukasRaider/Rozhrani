using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani1;
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
        Animal[] animals = new Animal[10];
        Dog p1 = new Dog("Azor"); Dog p2 = new Dog("Rex");
        Cat k1 = new Cat("Mici"); Cat k2 = new Cat("Mourek");
        Turtle z1 = new Turtle("Julinka");

        animals[0] = p1; animals[1] = p2; animals[2] = k1; animals[3] = k2; animals[4] = z1;
        for (int i = 0; i <= 4; i++)
        {
            Console.Write($"{animals[i].GetType().Name} se jmenuje ");       //2. krok
            Console.WriteLine(animals[i].name);
        }
    }
}
