using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Tool : Collectable
    {
        public Tool(string description) : base(description) { }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            DoAction();
        }

        public virtual void DoAction()
        {
            Console.WriteLine("Tool action is performed.");
        }
        
    }

}



