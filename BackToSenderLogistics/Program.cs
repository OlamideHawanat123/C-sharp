// See https://aka.ms/new-console-template for more information

namespace BackToSenderLogistics;
public class BackToSenderLogistics
{
     int[] _amountPerPercel = { 160, 200, 250, 500 };
     int _basePay = 5000;
     int _wage;

    public  int CalculateWageOfTheDay(int collectionRate) {
        
        if (collectionRate < 50) _wage = collectionRate * _amountPerPercel[0] + _basePay;
        if (collectionRate >= 50) _wage = collectionRate * _amountPerPercel[1] + _basePay;
        if (collectionRate >= 60) _wage = collectionRate * _amountPerPercel[2] + _basePay;
        if (collectionRate >=  70 && collectionRate < 100) _wage = collectionRate * _amountPerPercel[3] + _basePay;

        return _wage;
    }
    
    public static void Main(string[] args) {
        Console.WriteLine("Enter your collection rate:");
      

    }
    
}