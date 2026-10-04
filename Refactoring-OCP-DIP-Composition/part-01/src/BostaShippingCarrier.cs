namespace RefactoringLab;

public class BostaShippingCarrier : IShippingCarrier
{
    public string Name => "Bosta";

    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * 10m;
    }
}