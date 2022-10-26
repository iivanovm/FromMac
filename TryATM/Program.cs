using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TryATM
{
    public class cardProperties
    {
        public string cNum { get; set; }
        public string cardType { get; set; }
        public string cardDesign { get; set; }

        public cardProperties(string cNum, string cardType, string cardDesign)
        {
            this.cNum = cNum;
            this.cardType = cardType;
            this.cardDesign = cardDesign;
        }

    }
    public class cardHolder
    {
        string CardNum;
        int pin;
        string FirstName;
        string LastName;
        double Balance;
        int cardCode;

        public cardHolder(string CardNum, int pin, string FirstName, string LastName, double Balance, int cardCode = 1)
        {
            this.CardNum = CardNum;
            this.pin = pin;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Balance = Balance;
            this.cardCode = cardCode;
        }
        public string GetNum()
        {
            return CardNum;
        }
        public int GetPin()
        {
            return pin;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public double GetBalance()
        {
            return Balance;
        }
        public int GetCardCode()
        {
            return cardCode;
        }

        public void SetNum(string newCardNum)
        {
            CardNum = newCardNum;
        }
        public void SetPin(int newPin)
        {
            pin = newPin;
        }
        public void SetFirstName(string NewFirstName)
        {
            FirstName = NewFirstName;
        }
        public void SetLastName(string NewLastName)
        {
            LastName = NewLastName;
        }
        public void SetBalance(double NewBlanace)
        {
            Balance = NewBlanace;
        }

        public void SetCardCode(int NewCardCode = 1)
        {
            if (NewCardCode.ToString().Length < 6)
            {
                Console.WriteLine("Wrong code input");
            }
            else
            {
                cardCode = GetCardCode() + NewCardCode;
            }
        }
        //Main and Init
        public static void Main(String[] args)
        {
            void printOption()
            {
                Console.WriteLine("Please select one from following option");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
                Console.WriteLine("5. Buy car");

            }
            void deposit(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to deposit? ");
                double deposit = double.Parse(Console.ReadLine());
                currentUser.SetBalance(deposit + currentUser.GetBalance());
                Console.WriteLine("Thank you fro yout deposit. Your balance after transaction is: " + currentUser.GetBalance());
            }
            void withDraw(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to withdraw? ");
                double withdraw = double.Parse(Console.ReadLine());
                if (currentUser.GetBalance() < withdraw)
                {
                    Console.WriteLine("Insufficient balance:(");
                }
                else
                {
                    currentUser.SetBalance(currentUser.GetBalance() - withdraw);
                    Console.WriteLine("Operation finish successful :)");
                }
            }
            void balance(cardHolder currentUser)
            {
                Console.WriteLine("Your balance " + currentUser.GetBalance());
            }
            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("4532772818527999", 1234, "Ivan", "Ivanov", 300.00, 12));
            cardHolders.Add(new cardHolder("4532772818527699", 1234, "Tsveta", "Nencheva", 3400.00));
            cardHolders.Add(new cardHolder("4532772818527889", 1234, "Stefan", "Ivanov", 4400.00));
            cardHolders.Add(new cardHolder("4532772818527669", 1234, "Marin", "Vrabchev", 5400.00));
            cardHolders.Add(new cardHolder("4532772818527449", 1234, "Petar", "Petrob", 34000.00));
            cardHolders.Add(new cardHolder("4532772818527339", 1234, "Georgi", "Georgiev", 3400.00));
            List<cardProperties> cardp = new List<cardProperties>();
            cardp.Add(new cardProperties("4532772818527999","Debit","newDesign"));
            cardp.Add(new cardProperties("4532772818527699", "Debit", "newDesign"));
            cardp.Add(new cardProperties("4532772818527889", "Credit", "newDesign"));
            cardp.Add(new cardProperties("4532772818527669", "Online", "Virtual"));
            cardp.Add(new cardProperties("4532772818527449", "Debit", "newDesign"));
            cardp.Add(new cardProperties("4532772818527339", "Online", "Virtual"));
             List<car> cars = new List<car>();
            cars.Add(new car(1, "BMW", "525", "red", "petrol", "manual", "BMW525", 200.00));
            cars.Add(new car(2, "BMW", "525", "red", "petrol", "auto", "", 250.00));
            cars.Add(new car(3, "BMW", "325", "green", "disel", "manual", "", 350.00));
            cars.Add(new car(4, "BMW", "530", "yellow", "disel", "auto", "", 450.00));
            cars.Add(new car(5, "Citroen", "C5", "red", "petrol", "manual", "", 55.20));
            cars.Add(new car(6, "BMW", "C5", "white", "petrol", "auto", "", 250.00));
            cars.Add(new car(7, "Volvo", "XC90", "red", "petrol", "auto", "", 550.00));
            car currentcar;
            currentcar = cars.FirstOrDefault(x => x.carid == 1);
            double currentCarPrice;
            currentCarPrice=currentcar.carPrice;
            Console.WriteLine("Simple ATM");
            Console.WriteLine("Please insert yout debit card:");
            string debitCardNum = "";
            cardHolder currentUser;
            cardProperties cUser;
            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum);
                    cUser=cardp.FirstOrDefault(x=>x.cNum == debitCardNum);
                    if (currentUser != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Card not recognized. Please try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Card not recognized. Please try again");
                }
               
            }
            Console.WriteLine("Please enter yout pin: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.GetPin() == userPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid pin. Please try again");
                    }

                }
                catch
                {
                    Console.WriteLine("Invalid pin. Please try again");
                }
            }

            Console.WriteLine("Welcome " + currentUser.GetFirstName() + currentUser.GetCardCode() + $"\n_CardInfo_cardtype_:|{cUser.cardType}|_cardDesign:|{cUser.cardDesign}|"+ ":)");
            int option = 0;
            double carPrice = car.Load(1);
            do
            {
                printOption();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) { deposit(currentUser); }
                else if (option == 2) { withDraw(currentUser); }
                else if (option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else if (option == 5) 
                { 
                    if (currentUser.GetBalance() > currentcar.carPrice)
                    { 
                        currentUser.SetBalance(currentUser.GetBalance() -currentcar.carPrice);
                        Console.WriteLine($"Your balance is:{currentUser.GetBalance()}");
                    } 
                    else if (currentUser.GetBalance() < currentcar.carPrice)
                    {
                        Console.WriteLine($"Don't enought money for this, you need {currentcar.carPrice-currentUser.Balance} more money");
                    }
                }
                else { option = 0; }
            }
            while (option != 4);

        }
    }
}
