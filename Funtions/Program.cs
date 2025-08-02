// See https://aka.ms/new-console-template for more information

public class Funtions {
    private static int GetTheMaximumInAnArray(int[] number) {
        int maximum = number[0];
        for (int variable= 0; variable < number.Length; variable++) {
            if (number[variable] > maximum) maximum = number[variable];
        }

        return maximum;
    }

    private static int[] ReverseAList(int[] number)
    {
        int[] newList = new int[number.Length];
        int counter = 0;
        for (int count = number.Length; count >0; count --)
        {
            for (int anotherCount = 0; anotherCount < newList.Length; anotherCount++)
            {
                newList[counter] = number[count];
            }
            counter++;
            
        }

        return newList;

    }
    
    static void Main(string[] args) {
        int[] number = { 12, 34, 67, 43, 90, 23, 900, 6 };
        Console.WriteLine(GetTheMaximumInAnArray(number));
        Console.WriteLine(ReverseAList(number));
        
        

    }
    
}

