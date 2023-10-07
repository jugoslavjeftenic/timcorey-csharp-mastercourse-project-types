using System.Collections.Generic;

namespace T32_02_01_HomeworkMiniProject_WinForm.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<AddressModel> Addresses { get; set; }

        public PersonModel()
        {
            FirstName = "";
            LastName = "";
            Addresses = new List<AddressModel>();
        }
    }
}
