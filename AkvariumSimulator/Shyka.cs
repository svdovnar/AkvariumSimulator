using System;

namespace AkvariumSimulator
{
    public class Shyka: Akvarium

    {
        public string _foodtype;
        public string _name;
        
        public Shyka(string foodtype, string name)
        {
            _foodtype = foodtype;
            _name = name;
        }
        
        public void ImPredator()
        {
            Console.WriteLine("Меня зовут: " + _name);
            Console.WriteLine("Я ем:" + _foodtype);
        }
        public void FishSwim()
        {
            Console.WriteLine("Я плаваю только назад");
        }
        public override void GetTypeOfFood()
        {
            Console.WriteLine("Fish");
        }

        public override void GetTypeOfFish()
        {
            Console.WriteLine("Хищник");
        }
    }
}