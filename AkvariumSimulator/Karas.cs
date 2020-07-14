using System;

namespace AkvariumSimulator
{
    public class Karas: Akvarium, IIsHerbivore
    {
        public int _foodtime;
        public string _name;
        
        public Karas(int foodtime, string name)
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
            Console.WriteLine("Я плаваю только вверх");
        }
        public override void GetTypeOfFood()
        {
            Console.WriteLine("Grass");
        }
        public override void GetTypeOfFish()
        {
            Console.WriteLine("Травоядное");
        }

        public string Name { get; set; }
        public int FoodTime { get; set; }
    }
}