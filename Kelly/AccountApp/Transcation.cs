using AccountLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    public struct Transcation
    {
        public string AccountNumber { get; }
        public decimal Amount { get; }
        public Person Originator { get; }
        public DayTime Time { get; }
        public Transcation(string accountNumber, decimal amount, Person person)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            Originator = person;
            Time = Util.Now;
        }
        public override string ToString()
        {
            return $"Tmie: {Time}, Account number: {AccountNumber}, Amount: {Amount}, Person {Originator}";
        }
    }
}
