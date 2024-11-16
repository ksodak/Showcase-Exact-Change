namespace LTShowCase
{
    public enum UsaCurrency
    {
        // stored as cents, ordered from highest to lowest this is to help me avoid a float issue I was having.
        HundredDollar = 10000,
        FiftyDollar = 5000,
        TwentyDollar = 2000,
        TenDollar = 1000,
        FiveDollar = 500,
        OneDollar = 100,
        Quarter = 25,
        Dime = 10,
        Nickel = 5,
        Penny = 1
    }
}