﻿using Lab3App;
using System;

public class Axe : Tool
{
    public Axe(string description) : base(description) { }

    public override void DoAction()
    {
        Console.WriteLine("Axe is used.");
    }

    public override void Display()
    {
        Console.WriteLine($"Tool {Description} is displayed");

    }

}