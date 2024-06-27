public abstract class PaymentMethod
{
    public abstract void MakePayment(decimal amount);
    public abstract string GetPaymentDetails();
}

public class CreditCardPayment : PaymentMethod
{
    public override void MakePayment(decimal amount)
    {
        // Implement credit card payment logic
    }

    public override string GetPaymentDetails()
    {
        // Return credit card payment details
    }
}

public class PayPalPayment : PaymentMethod
{
    public override void MakePayment(decimal amount)
    {
        // Implement PayPal payment logic
    }

    public override string GetPaymentDetails()
    {
        // Return PayPal payment details
    }
}

