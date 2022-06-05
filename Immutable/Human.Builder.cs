namespace Immutable
{
    public partial class Human
    {
        public class Builder
        {
            private int height;
            private int weigth;
            private int money;

            public Builder Height(int height)
            {
                this.height = height;
                return this;
            }

            public Builder Weigth(int weigth)
            {
                this.weigth = weigth;
                return this;
            }

            public Builder Money(int money)
            {
                this.money = money;
                return this;
            }

            public Human Build() => new Human(height, weigth, money);
        }
    }
}