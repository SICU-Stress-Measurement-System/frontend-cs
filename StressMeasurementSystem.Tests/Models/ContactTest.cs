using NUnit.Framework;
using StressMeasurementSystem.Models;
using System.Collections.Generic;

namespace StressMeasurementSystem.Tests.Models
{
    [TestFixture]
    public class ContactTest
    {
        #region Fields

        private Contact _contact;
        private Contact.NameInfo _name;
        private Contact.OrganizationInfo _organization;
        private List<Contact.PhoneInfo> _phoneNumbers;
        private List<Contact.EmailInfo> _emailAddresses;

        #endregion

        [SetUp]
        public void SetUp()
        {
            _name = new Contact.NameInfo();
            _name.First = "John";
            _name.Last = "Smith";

            _organization = new Contact.OrganizationInfo();
            _organization.Company = "Smith Co.";
            _organization.JobTitle = "CEO";

            _phoneNumbers = new List<Contact.PhoneInfo>();

            Contact.PhoneInfo phoneNumberWork = new Contact.PhoneInfo();
            phoneNumberWork.Number = "(800) 123-4567";
            phoneNumberWork.T = Contact.PhoneInfo.Type.Work;
            _phoneNumbers.Add(phoneNumberWork);

            Contact.PhoneInfo phoneNumberMobile = new Contact.PhoneInfo();
            phoneNumberMobile.Number = "(123) 456-7890";
            phoneNumberMobile.T = Contact.PhoneInfo.Type.Mobile;
            _phoneNumbers.Add(phoneNumberMobile);

            _emailAddresses = new List<Contact.EmailInfo>();

            Contact.EmailInfo emailAddressWork = new Contact.EmailInfo();
            emailAddressWork.Address = new System.Net.Mail.MailAddress("jsmith@smith.com");
            emailAddressWork.T = Contact.EmailInfo.Type.Work;
            _emailAddresses.Add(emailAddressWork);

            _contact = new Contact(_name, _organization, _phoneNumbers, _emailAddresses);
        }

        [Test]
        public void Test1()
        {
            Assert.True(true);
        }

        [TearDown]
        public void TearDown()
        {
            //TODO: Implement
        }
    }
}
