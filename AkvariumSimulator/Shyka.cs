using System;

namespace AkvariumSimulator
{
    public class Shyka: Akvarium, IIsPredator

    {
        public string _foodtype;
        public string _name;
        private IIsPredator _isPredatorImplementation;

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

        public string Name { get; set; }
        public string Foodtype { get; set; }
        public void PrintInfo()
        {
            string Name = "Boobby";
            string Foodtype = "Fish and chips";
            Console.WriteLine(Name, Foodtype);
        }
    }
}