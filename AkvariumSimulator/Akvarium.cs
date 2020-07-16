using System;
namespace AkvariumSimulator
{
    public abstract class Akvarium: IIsHerbivore, IIsPredator

    {
    public abstract void GetTypeOfFish();
    public abstract void GetTypeOfFood();

    }
}