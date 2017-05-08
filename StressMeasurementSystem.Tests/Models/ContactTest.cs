using NUnit.Framework;
using StressMeasurementSystem.Models;
using System.Collections.Generic;
using static StressMeasurementSystem.Models.Contact;

namespace StressMeasurementSystem.Tests.Models
{
    [TestFixture]
    public class ContactTest
    {
        #region Fields

        private Contact _contact;
        private NameInfo _name;
        private OrganizationInfo _organization;
        private List<PhoneInfo> _phoneNumbers;
        private List<EmailInfo> _emailAddresses;

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
            _name = new NameInfo
            {
                First = "John",
                Last = "Smith"
            };
        }

        private void InitOrganization()
        {
            _organization = new OrganizationInfo
            {
                Company = "Smith Co.",
                JobTitle = "CEO"
            };
        }

        private void InitPhoneNumbers()
        {
            _phoneNumbers = new List<PhoneInfo>();

            var phoneNumberWork = new PhoneInfo
            {
                Number = "(800) 123-4567",
                T = PhoneInfo.Type.Work
            };
            _phoneNumbers.Add(phoneNumberWork);

            var phoneNumberMobile = new PhoneInfo
            {
                Number = "(123) 456-7890",
                T = PhoneInfo.Type.Mobile
            };
            _phoneNumbers.Add(phoneNumberMobile);
        }

        private void InitEmailAddresses()
        {
            _emailAddresses = new List<EmailInfo>();

            var emailAddressWork = new EmailInfo
            {
                Address = new System.Net.Mail.MailAddress("jsmith@smith.com"),
                T = EmailInfo.Type.Work
            };
            _emailAddresses.Add(emailAddressWork);

        }

        #endregion

        #region Tests

        [Test]
        public void TestName()
        {
            var name = _contact.Name;
            Assert.IsNull(name.Prefix);
            Assert.AreEqual(name.First, "John");
            Assert.IsNull(name.Middle);
            Assert.AreEqual(name.Last, "Smith");
            Assert.IsNull(name.Suffix);
        }

        [Test]
        public void TestOrganization()
        {
            var org = _contact.Organization;
            Assert.AreEqual(org.Company, "Smith Co.");
            Assert.AreEqual(org.JobTitle, "CEO");
        }

        [Test]
        public void TestPhoneNumbers()
        {
            Assert.AreEqual(_contact.PhoneNumbers.Count, 2);

            var pnWork = _contact.PhoneNumbers[0];
            Assert.AreEqual(pnWork.Number, "(800) 123-4567");
            Assert.AreEqual(pnWork.T, PhoneInfo.Type.Work);

            var pnMobile = _contact.PhoneNumbers[1];
            Assert.AreEqual(pnMobile.Number, "(123) 456-7890");
            Assert.AreEqual(pnMobile.T, PhoneInfo.Type.Mobile);
        }

        [Test]
        public void TestEmailAddresses()
        {
            Assert.AreEqual(_contact.EmailAddresses.Count, 1);

            var eaWork = _contact.EmailAddresses[0];
            Assert.AreEqual(eaWork.Address, "jsmith@smith.com");
            Assert.AreEqual(eaWork.T, EmailInfo.Type.Work);
        }

        #endregion


        [TearDown]
        public void TearDown()
        {
            _contact = null;
            _name = new NameInfo();
            _organization = new OrganizationInfo();
            _phoneNumbers.ForEach(pn =>
            {
                pn = new PhoneInfo();
            });
            _phoneNumbers = null;
            _emailAddresses.ForEach(ea =>
            {
                ea = new EmailInfo();
            });
            _emailAddresses = null;
        }
    }
}
