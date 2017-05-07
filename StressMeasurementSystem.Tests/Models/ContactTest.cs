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

        #region SetUp

        [SetUp]
        public void SetUp()
        {
            InitName();
            InitOrganization();
            InitPhoneNumbers();
            InitEmailAddresses();

            _contact = new Contact(_name, _organization, _phoneNumbers, _emailAddresses);
        }

        private void InitName()
        {
            _name = new Contact.NameInfo
            {
                First = "John",
                Last = "Smith"
            };
        }

        private void InitOrganization()
        {
            _organization = new Contact.OrganizationInfo
            {
                Company = "Smith Co.",
                JobTitle = "CEO"
            };
        }

        private void InitPhoneNumbers()
        {
            _phoneNumbers = new List<Contact.PhoneInfo>();

            var phoneNumberWork = new Contact.PhoneInfo
            {
                Number = "(800) 123-4567",
                T = Contact.PhoneInfo.Type.Work
            };
            _phoneNumbers.Add(phoneNumberWork);

            var phoneNumberMobile = new Contact.PhoneInfo
            {
                Number = "(123) 456-7890",
                T = Contact.PhoneInfo.Type.Mobile
            };
            _phoneNumbers.Add(phoneNumberMobile);
        }

        private void InitEmailAddresses()
        {
            _emailAddresses = new List<Contact.EmailInfo>();

            var emailAddressWork = new Contact.EmailInfo
            {
                Address = new System.Net.Mail.MailAddress("jsmith@smith.com"),
                T = Contact.EmailInfo.Type.Work
            };
            _emailAddresses.Add(emailAddressWork);

        }

        #endregion

        #region Tests

        [Test]
        public void Test1()
        {
            Assert.True(true);
        }

        #endregion


        [TearDown]
        public void TearDown()
        {
            //TODO: Implement
        }
    }
}
