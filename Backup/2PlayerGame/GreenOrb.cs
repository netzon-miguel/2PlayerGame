using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2PlayerGame
{
    public class GreenOrb : IEquipment
    {
        IEquipment equip;

        public GreenOrb(IEquipment equip)
        {
            this.equip = equip;
        }

        public string EquipmentName
        {
            get
            {
                return equip.EquipmentName;
            }
            set { }
        }
        public int EquipmentValue
        {
            get
            {
                return equip.EquipmentValue + 15;
            }
            set { }
        }


    }
}
