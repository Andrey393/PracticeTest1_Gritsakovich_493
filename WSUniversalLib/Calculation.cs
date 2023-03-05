using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public double coefficientProductType = 0;
        public double coefficientMaterialType = 0;

        public double ploshad = 0;
        public int qualityRaw = 0;
        public int quality = 0;

        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            

            if (count <= 0 || width <= 0 || length <= 0)
            {
                
                return -1;
            }
            else
            {
                switch (productType)
                {
                    case 1: coefficientProductType = 1.1; break;
                    case 2: coefficientProductType = 2.5; break;
                    case 3: coefficientProductType = 8.43; break;
                    default: return -1;
                }
                switch (materialType)
                {
                    case 1: coefficientMaterialType = 0.3; break;
                    case 2: coefficientMaterialType = 0.12; break;
                    default: return -1;
                }
                ploshad = width * length;
                qualityRaw = Convert.ToInt32(ploshad * coefficientProductType * count);
                quality = Convert.ToInt32((qualityRaw * coefficientMaterialType) / 100 + qualityRaw);           
                return quality;
            }
        }
    }
}
