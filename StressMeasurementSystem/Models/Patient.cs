using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace StressMeasurementSystem.Models
{
    public class Patient
    {
        #region Structs

        public struct NameInfo
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

        public struct OrganizationInfo
        {
            public string Company { get; set; }
            public string JobTitle { get; set; }
        }

        public struct PhoneInfo
        {
            public enum Type { Mobile, Home, Work, Main, WorkFax, HomeFax, Pager, Other }

            public string Number { get; set; }
            public Type T { get; set; }
        }

        public struct EmailInfo
        {
            public enum Type { Home, Work, Other }

            public MailAddress Address { get; set; }
            public Type T { get; set; }
        }

        #endregion

        #region Properties

        public NameInfo? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public OrganizationInfo? Organization { get; set; }
        public List<PhoneInfo> PhoneNumbers { get; set; }
        public List<EmailInfo> EmailAddresses { get; set; }

        #endregion

        #region Constructors

        public Patient()
        {
            Name = null;
            DateOfBirth = null;
            Organization = null;
            PhoneNumbers = null;
            EmailAddresses = null;
        }

        public Patient(NameInfo? nameInfo, DateTime? dateOfBirth, OrganizationInfo? organizationInfo,
            List<PhoneInfo> phoneNumbers, List<EmailInfo> emailAddresses)
        {
            Name = nameInfo;
            DateOfBirth = dateOfBirth;
            Organization = organizationInfo;
            PhoneNumbers = phoneNumbers;
            EmailAddresses = emailAddresses;
        }

        #endregion
    }
}
