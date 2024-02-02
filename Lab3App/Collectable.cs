
using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Collectable : IDisplayable
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set; }

        public Collectable(string description)
        {
            Description = description;
        }

        public virtual void AddMe(List<Collectable> collection)
        {
            collection.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }

        // This is the implementation of the Display method from IDisplayable
        public virtual void Display()
        {
            Console.WriteLine(Description);
        }
    }
}
