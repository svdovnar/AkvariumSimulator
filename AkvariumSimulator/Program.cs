
using System;

namespace AkvariumSimulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Piranya piranya = new Piranya("человечинку", "Polly");
            piranya.ImPredator();
            piranya.FishSwim();
            piranya.GetTypeOfFish();
            piranya.GetTypeOfFood();
            Console.WriteLine();

            Shyka shyka = new Shyka("рыбу", "Molly");
            shyka.ImPredator();
            shyka.FishSwim();
            shyka.GetTypeOfFish();
            shyka.GetTypeOfFood();
            Console.WriteLine();

            Tuna tuna = new Tuna(foodtime: 3, "Willy");
            tuna.ImHerbivore();
            tuna.FishSwim();
            tuna.GetTypeOfFish();
            tuna.GetTypeOfFood();
            Console.WriteLine();

            Losos losos = new Losos(4, "Dilly");
            losos.ImHerbivore();
            losos.FishSwim();
            losos.GetTypeOfFish();
            losos.GetTypeOfFood();
            Console.WriteLine();

            Karas karas = new Karas(5, "Killy");
            karas.ImHerbivore();
            karas.FishSwim();
            karas.GetTypeOfFish();
            karas.GetTypeOfFood();
        }
    }
}