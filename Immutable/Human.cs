namespace Immutable
{
    public class Human
    {
        private readonly int _height;
        private readonly int _weigth;
        private readonly int _money;
        public int Height { get => _height; }
        public int Weigth { get => _weigth; }
        public int Money { get => _money; }

        private Human(int height, int weigth, int money)
        {
            _height = height;
            _weigth = weigth;
            _money = money;
        }

        public class Builder
        {
            private int _height;
            private int _weigth;
            private int _money;

            public Builder Height(int height)
            {
                _height = height;
                return this;
            }

            public Builder Weigth(int weigth)
            {
                _weigth = weigth;
                return this;
            }

            public Builder Money(int money)
            {
                _money = money;
                return this;
            }

            public Human Build() => new Human(_height, _weigth, _money);
        }
    }
}