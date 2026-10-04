namespace RefactoringLab.Part02.Enrollment;

public class EnrollmentFacade
{
    private readonly PaymentGateway _paymentGateway;
    private readonly SeatInventory _seatInventory;
    private readonly InvoiceGenerator _invoiceGenerator;
    private readonly EmailService _emailService;

    public EnrollmentFacade()
    {
        _paymentGateway = new PaymentGateway();
        _seatInventory = new SeatInventory();
        _invoiceGenerator = new InvoiceGenerator();
        _emailService = new EmailService();
    }

    public void Enroll(string studentId, string courseId, decimal amount)
    {
        _paymentGateway.Charge(studentId, amount);

        _seatInventory.Reserve(courseId, studentId);

        var invoiceId = _invoiceGenerator.Create(
            studentId,
            amount);

        _emailService.Send(
            studentId,
            "Enrollment confirmed",
            $"Invoice {invoiceId} for {courseId}");
    }
}