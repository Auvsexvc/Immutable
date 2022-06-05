namespace Immutable
{
    public partial class Human
    {
        private readonly int height;
        private readonly int weigth;
        private readonly int money;
        public int Height => height;
        public int Weigth => weigth;
        public int Money => money;

        private Human(int height, int weigth, int money)
        {
            this.height = height;
            this.weigth = weigth;
            this.money = money;
        }
    }
}