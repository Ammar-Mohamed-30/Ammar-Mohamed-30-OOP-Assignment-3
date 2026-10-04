namespace RefactoringLab;

public class FedExShippingCarrier : IShippingCarrier
{
    public string Name => "FedEx";

    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * 15m;
    }
}