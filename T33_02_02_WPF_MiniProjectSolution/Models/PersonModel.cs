using System.Collections.Generic;

namespace T33_02_02_WPF_MiniProjectSolution.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public bool IsActive { get; set; }
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();
    }
}
