using Collections;

Console.WriteLine("=== Egyptian Phone Validation ===");

var phoneTests = new[]
{
    "01012345678",
    "+201512345678",
    "01312345678",
    "0101234567",
    "0101234567a"
};

foreach (var phone in phoneTests)
{
    Console.WriteLine(
        $"\"{phone}\" -> {phone.IsValidEgyptianPhone()}");
}

Console.WriteLine();

Console.WriteLine("=== Egyptian National ID Validation ===");

var nationalIdTests = new[]
{
    "29901011234567",
    "19901011234567",
    "2990101123456"
};

foreach (var nationalId in nationalIdTests)
{
    Console.WriteLine(
        $"\"{nationalId}\" -> {nationalId.IsValidEgyptianNationalId()}");
}