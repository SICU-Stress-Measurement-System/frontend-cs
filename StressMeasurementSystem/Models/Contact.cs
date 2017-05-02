using System;
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

        #region Methods

        /// <summary>
        /// Consolidates two contacts such that the first (master) contact retains its original information, plus any unique information presented by the second (tribute) contact. Ultimately, the master is returned, after the tribute is nullified.
        /// </summary>
        /// <param name="master">the primary contact that will live on</param>
        /// <param name="tribute">the secondary contact that will be destroyed after being linked</param>
        /// <returns>The master contact containing the additional information attained from tribute, or <tt>null</tt> if attempting to link null arguments.</returns>
        public static Contact Link(ref Contact master, ref Contact tribute)
        {
            foreach (var property in typeof(Contact).GetProperties())
            {
                var defaultValue = property.PropertyType.IsValueType
                    ? Activator.CreateInstance(property.PropertyType)
                    : null;

                if (property.GetValue(master) == defaultValue &&
                    property.GetValue(tribute) != defaultValue)
                {
                    property.SetValue(master, property.GetValue(tribute));
                }
            }
            tribute = null;
            return master;
        }

        #endregion
    }
}
