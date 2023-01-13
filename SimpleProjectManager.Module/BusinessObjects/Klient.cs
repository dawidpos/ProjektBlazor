using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections;

namespace SimpleProjectManager.Module.BusinessObjects.Klient
{

    [NavigationItem("Klient")]
    public class Klient : BaseObject
    {
        public Klient(Session session) : base(session) { }

        

        // edycja pól
        string symbol;
        public string Symbol
        {
            get { return symbol; }
            set { SetPropertyValue(nameof(Symbol), ref symbol, value); }
        }
        string vatNumber;
        public string VatNumber
        {
            get { return vatNumber; }
            set { SetPropertyValue(nameof(VatNumber), ref vatNumber, value); }
        }
        string klientName;
        public string KlientName
        {
            get { return klientName; }
            set { SetPropertyValue(nameof(KlientName), ref klientName, value); }
        }
        string street;
        public string Street
        {
            get { return street; }
            set { SetPropertyValue(nameof(Street), ref street, value); }
        }


        string city;
        public string City
        {
            get { return city; }
            set { SetPropertyValue(nameof(City), ref city, value); }
        }


        string postalCode;
        public string PostalCode
        {
            get { return postalCode; }
            set { SetPropertyValue(nameof(PostalCode), ref postalCode, value); }
        }

        string email;
        public string Email
        {
            get { return email; }
            set { SetPropertyValue(nameof(Email), ref email, value); }
        }
        string regon;
        public string Regon
        {
            get { return regon; }
            set { SetPropertyValue(nameof(Regon), ref regon, value); }

        }

        DateOnly dateOfCreation;
        public DateOnly DateOfCreation
        {
            get { return dateOfCreation; }
            set { SetPropertyValue(nameof(DateOfCreation), ref dateOfCreation, value); }

        }
        DateOnly dateOfCommencement;
        public DateOnly DateOfCommencement
        {
            get { return dateOfCommencement; }
            set { SetPropertyValue(nameof(DateOfCommencement), ref dateOfCommencement, value); }
        }
        DateOnly dateOfEntry;
        public DateOnly DateOfEntry 
        {
            get { return dateOfEntry; }
            set { SetPropertyValue(nameof(DateOfEntry), ref dateOfEntry, value); }
        }

        DateOnly dateOfChangeOccur;
        public DateOnly DateOfChangeOccur 
        {
            get { return dateOfChangeOccur; }
            set { SetPropertyValue(nameof(DateOfChangeOccur), ref dateOfChangeOccur, value); }
        }
        
     

    }
}