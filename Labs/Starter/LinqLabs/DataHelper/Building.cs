using System;
using System.Collections.Generic;
using System.Text;

namespace DataHelper {
    public class Building {
        public int BuildingID { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int SquareMeters { get; set; }
        public override string ToString() =>
            $"BuildingID={BuildingID} Address={Address} Category={Category} Price={Price:C0} m2={SquareMeters}";

    }

    

}
