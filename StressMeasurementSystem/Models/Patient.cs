using System;

namespace StressMeasurementSystem.Models
{
    public class Patient : Contact
    {
        public struct SocialSecurityNumber
        {
            public uint AreaNumber { get; set; }
            public uint GroupNumber { get; set; }
            public uint SerialNumber { get; set; }

            public override string ToString()
            {
                return AreaNumber + "-" + GroupNumber + "-" + SerialNumber;
            }
        }

        public SocialSecurityNumber Ssn { get; set; }
        public DateTime Dob { get; set; }

        public Patient()
        {
            Ssn = new SocialSecurityNumber();
            Dob = new DateTime();
        }

        public Patient(SocialSecurityNumber ssn, DateTime dob)
        {
            Ssn = ssn;
            Dob = dob;
        }
    }
}
