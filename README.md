# Showcase-Exact-Change
# a code exercise with C#
# by Kurt Sodak
# 11.15.2024
------------------------------------------------------------------------------------
Project overview
------------------------------------------------------------------------------------
This project is a console application inside JetBrains rider.

It calculates exact change needed of each US currency (100, 50, 20, 10, 5, and 1 dollar bills. for cents we have .25 quarters .10 dimes .05 nickels .01 pennies)

program will calculate the best ways to give change back,
the e.x. provided: 
user gets prompted to enter a value.

if user inputs: $19.99

the user will then be displayed the following:

1 - $10 bill
1 - $5 bill
4 - $1 bill
3 - quarters
2 - dimes
4 - pennies
---------------------------------------------------------------------------------------

Breakdown of what is happening class by class:
--------------------------------------------------
ExactChangeExercise.cs
--------------------------------------------------
This class has 2 methods: GetFriendlyName and CalcChange

-The GetFriendlyName is used with the enum USACurrency class. This method provides representation for each UsaCurrency via string
-I use a switch statement that talks to the UsaCurrency enum class to return the right string.
-in the event the user enters in a wrong value it will trigger an 'out of range' exception

calcChange method:
-this is the logic that calcs the exact change needed for the users input. See code line explanations below:
-"// Convert dollars to cents because enum is stored as cents
int remainingCents = (int)(amount * 100);"

-"// ordered the enum in descending order for the correct change breakdown
            foreach (UsaCurrency usaCurrency in Enum.GetValues(typeof(UsaCurrency)).Cast<UsaCurrency>().OrderByDescending(x => (int)x))
            {
                int valueInCents = (int)usaCurrency;
                // calculates how many of this US currency
                int count = remainingCents / valueInCents;"
                
-'order by descending' solved a problem I was having when I would enter 19.99 I would get 1999 pennies which I knew I was on the right track. the math was mathing, but I wasn't getting the correct display. This allowed for the highest currency to be processed first in the example provided it would be 10 dollar bill.

----------------------------------------------------------------
UsaCurrency.cs
---------------------------------------------------------------
This is my enum class and for simplicity I stored Usa Currency in cents to avoid potential float issues. This enum class is used in calcChange method mentioned above.

------------------------------------------------
program.cs
-----------------------------------------------
This is a console app it prompts the user to enter a value, confirms the value is in range, if valid it calls the calcChange method, it will then display that value with exact change.

----------------------------------------------
UsaCurrencyTest.cs
----------------------------------------------
I wrote 2 tests here but am struggling with the second one. I'll explain the first test and maybe in the panel interview we can trouble shoot my second test together? Maybe help me with why I am not getting it to pass I’m sure it’s something simple I’m overlooking : ). 

I use a [setup] to help prevent reusing code, but as you see in this example it’s not as useful because we only 2 test both required a different amount for testing, but odds are I won't be only writing 2 tests so [setup] will be nice to get use to using it now. I tested 0 in this case because Susan taught me to test boundaries in code
