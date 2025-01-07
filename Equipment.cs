using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystemC_
{
    public class Equipment
    {
        public int Id { get; set; }
        public string EquipName { get; set; }
        public string EquipDescrip { get; set; }
        public string MusclesUsed { get; set; }
        public DateTime DDate { get; set; }

        public decimal Cost { get; set; }

    }

   
}
