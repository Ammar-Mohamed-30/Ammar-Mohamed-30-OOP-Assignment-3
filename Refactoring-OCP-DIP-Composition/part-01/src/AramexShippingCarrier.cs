namespace RefactoringLab;

public class AramexShippingCarrier : IShippingCarrier
{
    public string Name => "Aramex";

    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * 12m;
    }
}