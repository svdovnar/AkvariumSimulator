using System;

namespace AkvariumSimulator
{
    public class Losos: Akvarium
    {
        public int _foodtime;
        public string _name;
        
        public Losos(int foodtime, string name)
        {
            _foodtime = foodtime;
            _name = name;
        }
        public void ImHerbivore()
        {
            Console.WriteLine("Меня зовут: " + _name);
            Console.WriteLine("Я ем:" + _foodtime + " раз в день");
        }
        public void FishSwim()
        {
            Console.WriteLine("Я плаваю только в право");
        }
        public override void GetTypeOfFood()
        {
            Console.WriteLine("Tomatos");
        }
        public override void GetTypeOfFish()
        {
            Console.WriteLine("Травоядное");
        }
    }
}