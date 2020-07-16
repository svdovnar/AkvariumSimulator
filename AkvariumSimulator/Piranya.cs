using System;

namespace AkvariumSimulator
{
    public class Piranya : Akvarium
    {
        public string _foodtype;
        public string _name;
        
        public Piranya(string foodtype, string name)
        {
            _foodtype = foodtype;
            _name = name;
        }

        public void ImPredator()
        {
            Console.WriteLine("Меня зовут: " + _name);
            Console.WriteLine("Я хищник и я ем: " + _foodtype);
        }
        public void FishSwim()
        {
            Console.WriteLine("Я плаваю только прямо");
        }
        public override void GetTypeOfFood()
        {
            Console.WriteLine("Humans");
        }

        public override void GetTypeOfFish()
        {
            Console.WriteLine("Хищник");
        }

        
    }

    
}