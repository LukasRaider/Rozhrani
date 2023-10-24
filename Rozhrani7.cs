using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani7;
interface ISoundable
{
    String sound();
}
abstract class Animal
{
    public String name;
    public Animal(String name) { this.name = name; }
}
class Dog : Animal, ISoundable
{
    Boolean isPedigree;
    public Dog(String name)
      : base(name)
    {
    }
    public String sound() { return "haf"; }
}
class Cat : Animal, ISoundable
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
class Car : ISoundable
{
    private String name;
    private int speed;
    public Car(string name)
    {
        this.name = name;

    }

    public string Name
    {
        get { return name; }
        set { name = value; }

    }
    public string GetName() { return name; }


    public String sound() { return "Tu tu"; }
    public string toString() { return name; }

}

class Rozhrani
{
    public static void Mainx()
    {
        ISoundable[] zv = new ISoundable[10];
        zv[0] = new Dog("Azor"); zv[1] = new Dog("Rex");
        zv[2] = new Cat("Mici"); zv[3] = new Cat("Mourek");
        zv[4] = new Car("Bramborak");
        for (int i = 0; i <= 3; i++)
        {
            Console.Write($"{zv[i].GetType().Name} se jmenuje ");
            //Animal z=new Animal();      //nelze tvořit instanci abstraktní třídy
            Animal z = (Animal)zv[i];       //
            Console.Write(z.name);     //
            Console.WriteLine(((Animal)zv[i]).name);  //elegantnější náhrada předchozích dvou řádků, pozor na závorky
            Console.WriteLine($" a vydává sound {zv[i].sound()}");
        }
        Console.WriteLine($"{zv[4].GetType().Name} se jmenu {zv[4].GetName()}");
    }
}
