using System;

namespace AkvariumSimulator
{
    public class Piranya : Akvarium, IIsPredator
    {
        public string _foodtype;
        public string _name;
        private IIsPredator _isPredatorImplementation;

        public Piranya(string foodtype, string name)
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

        public string Name { get; set; }
        public string Foodtype { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine();
            
        }

    }

    
}