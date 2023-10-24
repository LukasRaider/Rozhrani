﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani5;
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

class Rozhrani
{
    public static void Mainx(string[] args)
    {
        ISoundable[] zv = new ISoundable[10];
        zv[0] = new Dog("Azor"); zv[1] = new Dog("Rex");
        zv[2] = new Cat("Mici"); zv[3] = new Cat("Mourek");
        for (int i = 0; i <= 3; i++)
        {
            Console.Write($"{zv[i].GetType().Name} se jmenuje ");
            //Animal z=new Animal();      //nelze tvořit instanci abstraktní třídy
            Animal z = (Animal)zv[i];       //
            Console.Write(z.name);     //
            Console.WriteLine(((Animal)zv[i]).name);  //elegantnější náhrada předchozích dvou řádků, pozor na závorky
            Console.WriteLine($" a vydává sound {zv[i].sound()}");
        }
    }
}
