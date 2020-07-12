namespace AkvariumSimulator
{
    public interface IIsPredator
    {
        string Name { get; set; }
        string Foodtype { get; set; }
        void PrintInfo();
    }
}