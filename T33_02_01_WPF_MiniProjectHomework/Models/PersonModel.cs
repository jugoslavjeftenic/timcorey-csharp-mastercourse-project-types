using System.Collections.Generic;

namespace T33_02_01_WPF_MiniProjectHomework.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();
    }
}
