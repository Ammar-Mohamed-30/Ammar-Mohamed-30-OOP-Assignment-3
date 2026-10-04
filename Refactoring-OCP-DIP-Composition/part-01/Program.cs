using RefactoringLab;
var carriers = new List<IShippingCarrier>
{
    new AramexShippingCarrier(),
    new FedExShippingCarrier(),
    new DhlShippingCarrier(),
    new BostaShippingCarrier()
};

var shipping = new ShippingCostCalculator(carriers);
Console.WriteLine($"Aramex 2kg → {shipping.Calculate("Aramex", 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate("FedEx", 2)}");
Console.WriteLine($"Bosta 2kg  → {shipping.Calculate("Bosta", 2)}");
Console.WriteLine();

var processor = new OrderProcessor(
    new SqlOrderRepository(),
    new SmtpEmailSender()); processor.Process(1001, "customer@example.com");
Console.WriteLine();
var email = new EmailNotificationChannel();

var urgentScheduledEmail = new ScheduledNotificationChannel(
    new UrgentNotificationChannel(email),
    DateTime.Today.AddHours(18));

urgentScheduledEmail.Send(
    "customer@example.com",
    "Your order ships tomorrow",
    null);

var sms = new SmsNotificationChannel();

var urgentSms = new UrgentNotificationChannel(sms);

urgentSms.Send(
    "+201000000000",
    "OTP 4821",
    null);
var push = new PushNotificationChannel();

var urgentScheduledPush = new ScheduledNotificationChannel(
    new UrgentNotificationChannel(push),
    DateTime.Today.AddHours(20));

urgentScheduledPush.Send(
    "user123",
    "Your package is on the way",
    null);
