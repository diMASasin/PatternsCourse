namespace Excercise_3.Scripts
{
    public interface ICoinPicker
    {
        public int Coins { get; }

        void Add(int value);
    }
}
