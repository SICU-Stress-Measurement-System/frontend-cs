using System.Collections.Generic;
using System.Net.Mail;

namespace StressMeasurementSystem.Models
{
    public class Contact
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

        public NameInfo Name { get; set; }
        public OrganizationInfo Organization { get; set; }
        public List<PhoneInfo> PhoneNumbers { get; set; }
        public List<EmailInfo> EmailAddresses { get; set; }

        #endregion

        #region Constructors

        public Contact()
        {
            Name = new NameInfo();
            Organization = new OrganizationInfo();
            PhoneNumbers = new List<PhoneInfo>();
            EmailAddresses = new List<EmailInfo>();
        }

        public Contact(NameInfo nameInfo, OrganizationInfo organizationInfo,
            List<PhoneInfo> phoneNumbers, List<EmailInfo> emailAddresses)
        {
            Name = nameInfo;
            Organization = organizationInfo;
            PhoneNumbers = phoneNumbers;
            EmailAddresses = emailAddresses;
        }

        #endregion
    }
}
