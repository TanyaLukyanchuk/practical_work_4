using System;

class Package
{
    public string Description { get; set; }
    public double Weight { get; set; }

    public Package(string description, double weight)
    {
        Description = description;
        Weight = weight;
    }
}
