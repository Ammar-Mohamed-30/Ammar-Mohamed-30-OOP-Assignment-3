# Part 01 — answers

---

## ShippingCostCalculator

* What was the problem?
  `ShippingCostCalculator` used a `switch` statement and contained the pricing rules for every shipping carrier. Adding a new carrier required modifying the calculator.

* What did you change?
  I created the `IShippingCarrier` abstraction and separate carrier classes. `ShippingCostCalculator` now depends on a collection of `IShippingCarrier` objects instead of knowing the details of each carrier. This allows new carriers to be added without modifying `ShippingCostCalculator`.

---

## OrderProcessor

* What was the problem?
  `OrderProcessor` directly created `SqlOrderRepository` and `SmtpEmailSender` using `new`, so it was tightly coupled to concrete implementations.

* What did you change?
  I introduced `IOrderRepository` and `IEmailSender` abstractions and used constructor dependency injection. `OrderProcessor` now depends on the abstractions instead of creating the concrete dependencies itself.

---

## Notifications

* What was the problem?
  The notification design used inheritance for different combinations such as urgent email, urgent SMS, and urgent scheduled email. This caused the number of classes to grow for every new combination.

* What did you change?
  I replaced the notification inheritance combinations with composition. `EmailNotificationChannel`, `SmsNotificationChannel`, and `PushNotificationChannel` implement `INotificationChannel`. `UrgentNotificationChannel` and `ScheduledNotificationChannel` wrap a notification channel, so behaviors can be combined without creating a separate class for every combination.

---

## Proof

* New carrier file(s): `BostaShippingCarrier.cs`
* New notification channel file(s): `PushNotificationChannel` in `Notifications.cs`
* Existing classes left unchanged? (yes/no): yes
