namespace StressMeasurementSystem.Models
{
    public class Patient
    {
        #region Structs

        struct Name
        {
            public string Prefix { get; set; }
            public string First { get; set; }
            public string Middle { get; set; }
            public string Last { get; set; }
            public string Suffix { get; set; }
        }

        struct Organization
        {
            public string Company { get; set; }
            public string JobTitle { get; set; }
        }

        struct PhoneNumber
        {
            internal enum Type {Mobile, Home, Work, Main, WorkFax, HomeFax, Pager, Other}

            public string Number { get; set; }
            public Type T { get; set; }
        }

        #endregion

        #region Fields

        private Name _name;
        private int _age;

        #endregion
    }
}