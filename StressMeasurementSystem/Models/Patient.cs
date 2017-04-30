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
        }

        public struct Organization
        {
            public string Company { get; set; }
            public string JobTitle { get; set; }
        }

        public struct PhoneNumber
        {
            public enum Type {Mobile, Home, Work, Main, WorkFax, HomeFax, Pager, Other}

            public string Number { get; set; }
            public Type T { get; set; }
        }

        public struct Email
        {
            public enum Type {Home, Work, Other}

            public MailAddress Address { get; set; }
            public Type T { get; set; }
        }

        #endregion

        #region Fields

        private Name _name;
        private uint _age;
        private Organization _organization;
        private PhoneNumber _phoneNumber;
        private Email _email;

        #endregion

        #region Constructors



        #endregion
    }
}