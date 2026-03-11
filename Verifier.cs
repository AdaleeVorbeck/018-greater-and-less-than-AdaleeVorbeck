namespace knightmoves;
public class Verifier
{
    // Add your code here
    public string OldEnough(int age)
    {
        // age over 17 is considered "old enough"
        if (age > 17)
        {
            return "old enough";
        }
        return string.Empty;
    }

    public string UnderAge(int age)
    {
        // age under 18 is "under age"
        if (age < 18)
        {
            return "under age";
        }
        return string.Empty;
    }

    public string LegalSpeed(int speed)
    {
        // legal speed is 50 or less
        if (speed <= 50)
        {
            return "legal speed";
        }
        return string.Empty;
    }

    public string IsGoldenYears(int age)
    {
        // golden years starts at age 65
        if (age >= 65)
        {
            return "golden years";
        }
        return string.Empty;
    }
}

//should create a method named OldEnough that takes an age and returns the string "old enough" if the age is over 17
//should return an empty string ("") if an age of 17 is passed to OldEnough

//should create a method named UnderAge that takes an age and returns the string "under age" if the age is under 18
//should return an empty string ("") if an age of 18 is passed to UnderAge
//should create a method named LegalSpeed that takes a speed and returns the string "legal speed" if the speed is under 50
//should return the string "legal speed" if a speed of 50 is passed to LegalSpeed
//should return an empty string ("") if a speed of 51 is passed to LegalSpeed
//should create a method named IsGoldenYears that takes an age and returns the string "golden years" if the age is over 65
//should return the string "golden years" if an age of 65 is passed to IsGoldenYears
//should return an empty string ("") if an age of 64 is passed to IsGoldenYears