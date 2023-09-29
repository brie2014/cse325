using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Sambrano
{
    public class DeskQuote
    {
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public int ProductionDays { get; set; }

        public int calculateQuote()
        {
            // set basePrice
            int basePrice = 200;

            // surface area charge from desk method
            int surfaceArea = Desk.getSurfaceArea();
            int surfaceAreaCharge = 0;
            if (surfaceArea > 1000)
                surfaceAreaCharge = surfaceArea - 1000;

            // drawers charge
            int drawerCharge = 50 * Desk.NumOfDrawers;

            // material charge based on material
            int materialCharge = 0;
            string material = Desk.Material.ToString();

            switch (material) {
                case "oak":
                    materialCharge = 200;
                    break;
                case "laminate":
                    materialCharge = 100;
                    break;
                case "pine":
                    materialCharge = 50;
                    break;
                case "rosewood":
                    materialCharge = 300;
                    break;
                case "veneer":
                    materialCharge = 125;
                    break;
                default:
                    break;
            }



             // calculate rush charge based on days and surface area
             int rushCharge = 0;
            if (ProductionDays == 3)
                if (surfaceArea > 2000)
                    rushCharge = 80;

                else if (surfaceArea > 1000)
                    rushCharge = 70;

                else rushCharge = 60;

            if (ProductionDays == 5)
                if (surfaceArea > 2000)
                    rushCharge = 60;

                else if (surfaceArea > 1000)
                    rushCharge = 50;

                else rushCharge = 40;

            if (ProductionDays == 7)
                if (surfaceArea > 2000)
                    rushCharge = 40;

                else if (surfaceArea > 1000)
                    rushCharge = 35;

                else rushCharge = 30;

            // add the charges to the base price
            int total = basePrice + surfaceAreaCharge + drawerCharge + materialCharge + rushCharge;

            return total;
        }

    }

}
