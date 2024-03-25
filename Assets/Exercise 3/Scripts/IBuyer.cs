namespace Assets.Exercise_3.Scripts
{
    public interface IBuyer
    {
        void Buy(Item item);
        bool CanBuy(int price);
        int Reputation { get; }
    }
}