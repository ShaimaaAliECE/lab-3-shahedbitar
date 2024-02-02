using System;
namespace Lab3App
{
    public class CollectionBoard
    {
        public int TotalScore { get; private set; }
        public int TotalValue { get; private set; }

        public void UpdateTotalScore(int score)
        {
   
            TotalScore += score; // Increment the cumulative score
            Console.WriteLine($"Total score is updated to: {TotalScore}");
        }
        public void UpdateTotalValue(int value)
        {
            TotalValue += value; ; // Increment the cumulative score
            Console.WriteLine($"Total score is updated to: {TotalValue}");
        }
    }
}
