using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Coin : Collectable
    {
        public int Score { get; private set; }
        public int Value { get; private set; }

        public Coin(string description, int score, int value) : base(description)
        {
            Score = score;
            Value = value;
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection); // Call to the base class's AddMe
            Board?.UpdateTotalScore(Score); // Assuming these methods exist
            Board?.UpdateTotalValue(Value);
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }


}

