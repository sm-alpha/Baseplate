using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectModel;

namespace Designer
{
    public class Class1
    {
        public static DesignResults Designerstuff(BPDesign bpdesign)
        {
            Column col = bpdesign.column;
            

            DesignResults desresult = new DesignResults();
            desresult.MaximumBendingCapacity = 10;
            desresult.MaximumShearCapacity = 5;

            //gravity baseplate design here

            return desresult;
        }
    }
}
