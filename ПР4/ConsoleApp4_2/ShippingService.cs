using System;
class ShippingService
{
    public double WeightLimit { get; set; }
private double totalWeight;

public ShippingService(double weightLimit)
{
    WeightLimit = weightLimit;
    totalWeight = 0;
}

public void SendPackage(Package package)
{
    if (totalWeight + package.Weight > WeightLimit)
    {
        Console.WriteLine($"Error: package weight limit exceeded ({WeightLimit} kg).");
        return;
    }

    totalWeight += package.Weight;
    Console.WriteLine($"Package sent: {package.Description} ({package.Weight} kg).");
}
}