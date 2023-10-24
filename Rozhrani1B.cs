using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani1b;
abstract class Animal
{
    public String name;
    public static int countOfAnimals = 0;                                //
    public Animal(String name)
    {
        this.name = name;
        countOfAnimals++; //
    } //
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
        Dog p1 = new Dog("Azor"); Dog p2 = new Dog("Rex");
        Cat k1 = new Cat("Mici"); Cat k2 = new Cat("Mourek");
        Turtle z1 = new Turtle("Julinka");
        Animal[] animals = new Animal[Animal.countOfAnimals];                  //
        animals[0] = p1; animals[1] = p2; animals[2] = k1; animals[3] = k2; animals[4] = z1;
        Animal[] animals2 = { p1, p2, k1, k2, z1 };                       //2
        Animal[] animals3 = { new Dog("Haryk"), new Dog("Rex"), new Cat("Mici"), new Cat("Mourek"), new Turtle("Julinka") }; //3
        foreach (Animal ani in animals3)
        {                                 //
            Console.Write($"{ani.GetType().Name} se jmenuje ");            //
            Console.WriteLine(ani.name);                                  //                                                                     //
        }
    }
}
