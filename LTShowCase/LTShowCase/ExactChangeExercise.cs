namespace LTShowCase
{
    public static class ExactChangeExercise
    {
        private static string GetFriendlyName(this UsaCurrency usaCurrency)
        {
            return usaCurrency switch
            {
                UsaCurrency.HundredDollar => "$100 bill",
                UsaCurrency.FiftyDollar => "$50 bill",
                UsaCurrency.TwentyDollar => "$20 bill",
                UsaCurrency.TenDollar => "$10 bill",
                UsaCurrency.FiveDollar => "$5 bill",
                UsaCurrency.OneDollar => "$1 bill",
                UsaCurrency.Quarter => "quarter",
                UsaCurrency.Dime => "dime",
                UsaCurrency.Nickel => "nickel",
                UsaCurrency.Penny => "penny",
                _ => throw new ArgumentOutOfRangeException(nameof(usaCurrency), usaCurrency, null)
            };
        }

        public static List<string> CalculateChange(decimal amount)
        {
            // convert dollars to cents because enum is stored as cents
            int remainingCents = (int)(amount * 100);
            var change = new List<string>();

            // ordered the enum in descending order for the correct change breakdown
            foreach (UsaCurrency usaCurrency in Enum.GetValues(typeof(UsaCurrency)).Cast<UsaCurrency>().OrderByDescending(x => (int)x))
            {
                int valueInCents = (int)usaCurrency;
                // calculates how many of this US currency
                int count = remainingCents / valueInCents;

                if (count > 0)
                {
                    // adds string representing US currency
                    change.Add($"{count} - {usaCurrency.GetFriendlyName()}");
                    // this reduces the remaining cents so example 19.99 at start the $10 is added to string then leaving us with 999 cents
                    // we go through the enum descending down again this time we will hit $5 bring us down to 499 cents
                    // process repeats till we hit 0 cents
                    remainingCents %= valueInCents;
                }
            }
            return change;
        }
    }
}