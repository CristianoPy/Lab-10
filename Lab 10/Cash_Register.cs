using Lab_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Cash_Register
    {
        public void PayCard(Card card)
        {
            card.Insert();
            card.Paid();
            card.Remove();
        }

        public void PayContactless(Contactless contactless)
        {
            contactless.Starting();
            contactless.Processing();
            contactless.Finishing();
        }

        public void PayMoney(Money money)
        {
            money.Opening();
            money.TakingMoney();
            money.Closing();
            money.Receipt();
        }
    }
}

interface IMoney : IPayment
{
    void Openin();
    void Closing();
    void Receipt();
}
class Money 
{
    public void Opening()
    {
        Console.WriteLine("Opening the drawer;");
    }
    public void TakingMoney()
    {
        Console.WriteLine("Colecting the money;");
    }

    public void Closing()
    {
        Console.WriteLine("Closing the drawer;");
    }

    public void Receipt()
    {
        Console.WriteLine("Giving the receipt;");
    }
}

interface IPayment
{
    void Paying();
}

interface ICard : IPayment
{
    void Insert();
    void Remove();
}
class Card 
{
    public void Insert()
    {
        Console.WriteLine("Insert the card;");
    }

    public void Paid()
    {
        Console.WriteLine("Transaction completed;");
    }

    public void Remove()
    {
        Console.WriteLine("Remove the card;");
    }  
}

interface IContactless : IPayment
{
   void Starting();
}

class Contactless : Card
{
    public void Starting()
    {
        Console.WriteLine("hold your card or phone close;");
    }
    public void Processing()
    {
        Console.WriteLine("Processing;");
    }

    public void Finishing()
    {
        Console.WriteLine("transaction completed;");
    }
}

