
using ATM;
bool exitATM = false;
AtmMachine? atmMachine = new AtmMachine();
while (true)
{
    Console.Clear();
    Console.WriteLine();
    //Welcome
    Console.WriteLine("Velkommen til millionær ATM maskinen");
    Console.WriteLine();
    //Please login with your pin code (4 digits)
    Console.WriteLine("Indtast venligst din fire cifrede pinkode. (mere eller mindre vil være spildt arbejde)");


    //check pin
    // PinValidator.ValidatePin(Console.ReadLine());
    string? input = Console.ReadLine();
    if (atmMachine.Login(input))
    {
        Console.Clear();
        Console.WriteLine();
        Console.Write("Du er nu logget ind som: ");
        Console.WriteLine(atmMachine.GetAccount(atmMachine.AccountNumberLoggedIn).Owner);
        Console.Write("Konto navn: ");
        Console.WriteLine(atmMachine.GetAccount(atmMachine.AccountNumberLoggedIn).AccountName);
        Console.Write("Konto nummer: ");
        Console.WriteLine(atmMachine.GetAccount(atmMachine.AccountNumberLoggedIn).AccountNumber);
        Console.Write("Saldo: ");
        Console.WriteLine(atmMachine.GetAccount(atmMachine.AccountNumberLoggedIn).Saldo);
        Console.WriteLine();

        Console.WriteLine("Hvor meget ønsker du at hæve (Tallet skal være deleligt med 100)");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Forkert pinkode!");
        Thread.Sleep(1000);
    }

    //Select withdrawal amount

    //withdraw money (New class)




    //
}
