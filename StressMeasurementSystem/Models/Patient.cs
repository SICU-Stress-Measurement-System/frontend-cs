using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace StressMeasurementSystem.Models
{
    public class Patient
    {
        #region Structs

        public struct Name
        {
            public string Prefix { get; set; }
            public string First { get; set; }
            public string Middle { get; set; }
            public string Last { get; set; }
            public string Suffix { get; set; }

            public override string ToString()
            {
                return Prefix + " " + First + " " + Middle + " " + Last + ", " + Suffix;
            }
        }

        public struct Organization
        {
            public string Company { get; set; }
            public string JobTitle { get; set; }
        }

        public struct PhoneNumber
        {
            public enum Type { Mobile, Home, Work, Main, WorkFax, HomeFax, Pager, Other }

            public string Number { get; set; }
            public Type T { get; set; }
        }

        public struct EmailAddress
        {
            public enum Type { Home, Work, Other }

            public MailAddress Address { get; set; }
            public Type T { get; set; }
        }

        #endregion

        #region Properties

        public Name? NameOf { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Organization? OrganizationOf { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public List<EmailAddress> EmailAddresses { get; set; }

        #endregion

        #region Constructors

        public Patient()
        {
            NameOf = null;
            DateOfBirth = null;
            OrganizationOf = null;
            PhoneNumbers = null;
            EmailAddresses = null;
        }

        public Patient(Name? name, DateTime? dateOfBirth, Organization? organization,
            List<PhoneNumber> phoneNumbers, List<EmailAddress> emailAddresses)
        {
            NameOf = name;
            DateOfBirth = dateOfBirth;
            OrganizationOf = organization;
            PhoneNumbers = phoneNumbers;
            EmailAddresses = emailAddresses;
        }

        #endregion
    }
}
