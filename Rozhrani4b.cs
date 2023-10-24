using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rozhrani4b;

interface ISoundable
{           //
    String sound();
}
abstract class Animal
{
    public String name;
    public Animal(String name) { this.name = name; }
}
class Dog : Animal, ISoundable
{  //
    Boolean isPedigree;
    public Dog(String name)
      : base(name)
    {
    }
    public String sound() { return "haf"; }
}
class Cat : Animal, ISoundable
{  //    
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
        ISoundable[] zv = new ISoundable[10];                     //
        zv[0] = new Dog("Azor"); zv[1] = new Dog("Rex");
        zv[2] = new Cat("Mici"); zv[3] = new Cat("Mourek");
        //zv[4] = new Turtle("Julinka");
        for (int i = 0; i <= 3; i++)
        {                            //i jen do 3
            Console.Write($"{zv[i].GetType().Name} se jmenuje ");
            //Console.WriteLine(zv[i].name);                       //nelze kompilovat
            Console.WriteLine($" a vydává zvuk {zv[i].sound()}");    //
        }
    }
}
