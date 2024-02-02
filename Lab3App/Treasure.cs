using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Treasure : Collectable
    {
        public int Score { get; set; }

        public Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            Board?.UpdateTotalScore(Score); // Update the cumulative total score
        }
    }
}


