using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtoCode_P1
{
    public class Account
    {
        List<Transaction> Transactions;
        private string IBAN;
        protected float Amount;
        public bool Transaction(string transaction)
        {
            return true;
        }
    }
    public struct Transaction
    {
        public string From;
        public string To;
        public float Amount;
        public DateTime Request;


    }
    public class Investing : Account
    {
        public float Interest;
        public void Applyinterest()
        {

        }

    }
    public class Saving : Account
    {
        private float ProtectedAmount;
        public void LiberateSaving()
        {

        }

    }
}
