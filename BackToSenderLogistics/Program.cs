// See https://aka.ms/new-console-template for more information

public class PizzaStore
{
    private static int[] amountPerPercel = { 160, 200, 250, 500 };
    private static int basePay = 5000;
    static int wage;

    private static int CalculateWageOfTheDay(int collectionRate) {
        
        if (collectionRate < 50) wage = collectionRate * amountPerPercel[0] + basePay;
        if (collectionRate >= 50) wage = collectionRate * amountPerPercel[1] + basePay;
        if (collectionRate >= 60) wage = collectionRate * amountPerPercel[2] + basePay;
        if (collectionRate >=  70 && collectionRate < 100) wage = collectionRate * amountPerPercel[3] + basePay;

        return wage;
    }
    
    static void Main(string[] args) {
        Console.WriteLine("Enter your collection rate:");
        int collectionRate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your wage is" + " "+ CalculateWageOfTheDay(collectionRate));

    }
    
}