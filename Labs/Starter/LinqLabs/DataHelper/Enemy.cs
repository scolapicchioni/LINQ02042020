using System;
using System.Collections.Generic;
using System.Text;

namespace DataHelper {
    public struct Enemy {
        public Enemy(int healthPoints=100) {
            HealthPoints = healthPoints;
        }
        public void Fight(int attackPower) {
            HealthPoints -= attackPower;
            Console.WriteLine($"Boom! Enemy has now {HealthPoints} points left!");
        }

        public int HealthPoints { get; set; }

    }
}
