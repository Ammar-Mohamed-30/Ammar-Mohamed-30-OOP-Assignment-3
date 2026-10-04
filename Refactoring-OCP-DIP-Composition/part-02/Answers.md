# Part 02 — answers

---

## Reports

* What was the problem?
  The three report exporters repeated the same export workflow: loading the data, validating it, formatting it, and saving it. Only the formatting logic was different.

* What did you change?
  I created an abstract `ReportExporter` base class containing the common export workflow. `CsvReportExporter`, `JsonReportExporter`, and `TextReportExporter` now inherit from it and only implement their own `Format` method.

* Why did you choose that approach?
  I used the Template Method pattern because the steps and their order are the same for all three exporters, while the formatting step is different. An abstract class is a better fit than an interface here because the base class can provide the shared workflow and common implementation, while requiring each exporter to implement the different formatting step.

---

## Enrollment

* What was the problem?
  The caller created and coordinated `PaymentGateway`, `SeatInventory`, `InvoiceGenerator`, and `EmailService` directly and had to know the correct order of the enrollment steps.

* What did you change?
  I introduced an `EnrollmentFacade` that hides the four services behind a single `Enroll` method. `Program.cs` now only creates the facade and calls `Enroll`.

* Why did you choose that approach?
  I used the Facade pattern because it provides a simple entry point to a multi-step workflow and hides the internal services and their execution order from the caller.
