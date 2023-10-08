namespace T32_02_02_SolutionMiniProject_WinForm.Models
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
