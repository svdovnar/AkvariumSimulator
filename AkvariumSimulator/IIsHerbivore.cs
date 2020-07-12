namespace AkvariumSimulator
{
    public interface IIsHerbivore
    {
        string Name { get; set; }
        int FoodTime { get; set; }
        void PrintInfo();
    }

}