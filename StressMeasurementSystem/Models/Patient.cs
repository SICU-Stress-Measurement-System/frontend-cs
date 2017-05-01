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

        public SocialSecurityNumber SSN { get; set; }
        public DateTime DOB { get; set; }

        public Patient()
        {

        }
    }
}
