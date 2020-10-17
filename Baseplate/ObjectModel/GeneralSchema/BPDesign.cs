using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    /// <summary>
    /// This is the serializable object that is sent to Revit and to the designer
    /// </summary>
    public class BPDesign
    {
        public readonly Column _column;
        public readonly Baseplate _bp;
        public readonly Foundation _fndn;
        public readonly ExportedResults _exres;
        public BPDesign(Column column, Baseplate bp, Foundation fndn, ExportedResults exres)
        {
            _column = column;
            _bp = bp;
            _fndn = fndn;
            _exres = exres;
        }
    }
}
