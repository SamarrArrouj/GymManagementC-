using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystemC_
{
    public class Member

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public string GymTime { get; set; }
        public string Address { get; set; }
        public string Membership { get; set; }
    }
}
