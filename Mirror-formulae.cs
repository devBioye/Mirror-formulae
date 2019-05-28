using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mirror_formulae
{
    class Mirror_formulaeCLI
    {
        public int ObjectDist { get; set; }
        public int FocalDist { get; set; }
        public int ImageDist { get; set; }
        public int ImageDistance(string MirrorType, double ObjectDistance, double FocalLength)
        {
           //Using Real is Positive.....
            if (MirrorType.ToLower() == "concave")
            {
                ObjectDist = (1 / ObjectDistance);
                FocalDist = (1 / FocalLength);
                ImageDist = 1/( FocalDist - ObjectDist);
                
            }
            //Using Real is Positive
            else if (MirrorType.ToLower() == "convex")
            {
                ObjectDist = (1 / ObjectDistance);
                FocalDist = (1 / FocalLength);
                ImageDist = 1 / (-FocalDist - ObjectDist);

            }
            else {
                throw new Exception("This is not a MirrorType.Check it and try again");
            
            }
            return ImageDist;
        }
        
    }
}
