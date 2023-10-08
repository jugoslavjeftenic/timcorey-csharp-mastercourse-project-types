
using System.Collections.Generic;

namespace T32_02_02_SolutionMiniProject_WinForm.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public bool IsActive { get; set; }
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();
    }
}
