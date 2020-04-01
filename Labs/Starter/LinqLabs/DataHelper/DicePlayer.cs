using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataHelper {
    public class DicePlayer {
        public string Name { get; set; }
        public List<(int,int)> DiceRolls { get; set; }

        public override string ToString() {
            return $"{Name} - {string.Concat(DiceRolls.Select(r=>$"({r.Item1}, {r.Item2}) "))}";
        }
    }
}
