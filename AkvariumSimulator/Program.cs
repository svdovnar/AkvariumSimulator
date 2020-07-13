
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
            Console.WriteLine();
            
            Shyka shyka = new Shyka("рыбу", "Molly");
            shyka.ImPredator();
            shyka.FishSwim();
            Console.WriteLine();
            
            Tuna tuna = new Tuna(foodtime:3,"Willy");
            tuna.ImHerbivore();
            tuna.FishSwim();
            Console.WriteLine();
            
            Losos losos= new Losos(4,"Dilly");
            losos.ImHerbivore();
            losos.FishSwim();
            Console.WriteLine();
            
            Karas karas= new Karas(5, "Killy");
            karas.ImHerbivore();
            karas.FishSwim();
            
            TypeOfFish typeOfFish = new TypeOfFish();
            typeOfFish.OutPutTypeOfFish(piranya);
            typeOfFish.OutPutTypeOfFish(shyka);
            typeOfFish.OutPutTypeOfFish(tuna);
            typeOfFish.OutPutTypeOfFish(losos);
            typeOfFish.OutPutTypeOfFish(karas);
            
            Console.WriteLine();
            TypeOfFoodForFish typeOfFoodForFish =new TypeOfFoodForFish();
            typeOfFoodForFish.OutPutTypeOfFood(piranya);
            typeOfFoodForFish.OutPutTypeOfFood(shyka);
            typeOfFoodForFish.OutPutTypeOfFood(tuna);
            typeOfFoodForFish.OutPutTypeOfFood(losos);
            typeOfFoodForFish.OutPutTypeOfFood(karas);
            
            
            shyka.PrintInfo();
            piranya.PrintInfo();
         }
    }
}