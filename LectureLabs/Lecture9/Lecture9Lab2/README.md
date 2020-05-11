# Lecture9Lab2
> Override methods to use inheritance for different payment types

## Screenshot
![screenshot](Lecture9Lab2.gif)

## Instructions
> Define a class named Payment that contains an instance variable of type  
> double that stores the amount of the payment and appropriate getter and  
> setter methods.  Also create a method names PaymentDetails that outputs an  
> English sentence to describe the amount of the payment.  
> 
> Next, define a named CashPayment that is derived from Payment.  This class  
> should redefine the PaymentDetails method to indicate that the payment is in  
> cash.  Include appropriate constructor(s).  
> 
> Define a class named CreditCardPayment that is derived from Payment.  
> This class should contain instance variables for the name on the card,  
> and credit card number.  Include appropriate constructor(s). Finally,  
> redefine the Payment Details method to include all credit card information  
> in the printout.  
> 
> Create a Main method that creates at least two CashPayment and two  
> CreditCardPayment objects with different values and calls PaymentDetails  
> for each.  