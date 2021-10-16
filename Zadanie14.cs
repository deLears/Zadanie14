using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Zadanie14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите вид животного \"1\" - собака, \"2\" - кошка ");
            try
            {
            int animalcode = Convert.ToInt32(Console.ReadLine());
                if (animalcode == 1)
                {
                   Dog mine = new Dog();
                   mine.ShowInfo;
                }

                if (animalcode == 2)
                {
                    Cat mine = new Cat();
                    mine.Say;
                }

            }

            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;
            }

            
            {

            }

        }
    }
    public abstract class Animal
    {
        public abstract string AnimalName { get; set; }

        public Animal()
        {
            return;

        }

        public virtual string Say(string noise)
        {
            if (AnimalName == "Cat")
            {
                noise = "Мяу";
            }

            Console.WriteLine(noise);
            return noise;

        }
        public virtual string ShowInfo(string noise)
        {
            Say(noise);
            Console.WriteLine(AnimalName);
            return AnimalName;

        }
    }
    class Cat : Animal
    {
        string Name;
        public override string AnimalName
        {
            get
            {
                return Name;
            }
            set
            { Name = value; }
        }
        public override string Say(string noise)
        {
            noise = "Мяу";
            return base.Say(noise);
        }
    }
    class Dog : Animal
    {
        string Name;
        public override string AnimalName
        {
            get
            {
                return Name;
            }
            set
            { Name = value; }
        }
        public override string Say(string noise)
        {
            noise = "Гав";
            return base.Say(noise);
        }


    }
}
