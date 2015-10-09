using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2PlayerGame
{
    public interface IEquipment
    {
        string EquipmentName { get; }
        int EquipmentValue { get; }
    }
}
