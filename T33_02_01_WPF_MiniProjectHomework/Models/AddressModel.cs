namespace T33_02_01_WPF_MiniProjectHomework.Models
{
    public class AddressModel
    {
        public string StreetAddress { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string ZipCode { get; set; } = "";

        public string AddresDisplayValue => $"{StreetAddress}, {City}, {State}  {ZipCode}";
    }
}
