using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectModel;

namespace Designer
{
    public static class Class1
    {
        public static DesignResults Designerstuff(BPDesign bpdesign)
        {
            Column col = bpdesign.column;
            

            DesignResults desresult = new DesignResults();
            desresult.MaximumBendingCapacity = 10;

            //gravity baseplate design here

            return desresult;
        }
    }
}
