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

        #endregion
    }
}