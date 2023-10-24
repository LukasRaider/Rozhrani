using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani3;
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
        Animal[] zv = new Animal[10];
        zv[0] = new Dog("Azor"); zv[1] = new Dog("Rex");
        zv[2] = new Cat("Mici"); zv[3] = new Cat("Mourek");
        zv[4] = new Turtle("Julinka");
        for (int i = 0; i <= 4; i++)
        {
            Console.Write($"{zv[i].GetType().Name} se jmenuje ");
            Console.WriteLine(zv[i].name);
            //Console.WriteLine(" a vydává sound " + zv[i].sound());//Animal does not contain a definition for “sound”        
        }
        Console.Write("Pomoci pretypovani:");
        Console.WriteLine(((Dog)zv[0]).sound()); //2
        Console.Write("Pomoci operatoru as:");
        Console.WriteLine((zv[3] as Cat).sound());  //2
        Console.WriteLine("Operator is a GetType():");
        for (int i = 0; i <= 4; i++)
        {                                                     //3
            if (zv[i] is Dog)
            {                                                              //3
                                                                           //if (zv[i].GetType() == typeof(Dog)) {
                                                                           //if (zv[i].GetType().Name == "Dog") {
                Console.Write($"{zv[i].GetType().Name} se jmenuje ");                          //3
                Console.Write($"{zv[i].name} a vydává zvuk: ");                                 //3
                Console.WriteLine(((Dog)zv[i]).sound());                       //3
                Type t = zv[i].GetType();
            }              //3
        }
        //!!! nove od C#7:
        Console.WriteLine("Nove lze i toto:");
        for (int i = 0; i < zv.Length; i++)
        {
            if (zv[i] is Dog doggie)
            {     //neni treba pretypovat, samo se udela psem                           //3
                Console.WriteLine($"V bunce cislo {i} je {doggie.name} a ten vydava zvuk {doggie.sound()}");
            }
        }                                                                          //3
        Console.WriteLine("Ternarni operator");
        for (int i = 0; i <= 4; i++)
        {                                                     //4
            Console.Write($"{zv[i].GetType().Name} se jmenuje ");                          //4
            Console.Write($"{zv[i].name} a vydává zvuk: ");                                 //4
            if (!(zv[i] is Turtle)) Console.WriteLine(zv[i] is Dog ? ((Dog)zv[i]).sound() : ((Cat)zv[i]).sound());  //4
        }
    }
}
