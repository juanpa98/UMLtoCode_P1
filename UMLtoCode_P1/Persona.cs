using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace UMLtoCode_P1
{
    public class Persona
    {
        List<Address> Adresses;
        public int ID;
        public string Name;
        protected string Phone;
        public string Email;
    }
    public struct Address
    {
        public string Street;
        public string City;
        public string State;
        public int PostalCode;
        public string Country;
        public bool Validate;
    }
    public class Employee : Persona
    {
        public Departament Departament;
        private float Salary;
    }

    public enum Departament
    {
        finance,
        sales

    }

    public class Customer : Persona
    {
        public List<Account> Acounts;
        public DateTime Registartion;
        private int CreditScore;

    }
}
