using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILPBatchingApplication
{
    interface IAssociate
    {
        int AssociateId { get; }
        string Name { get; set; }
        bool IsGR { get; set; }
        int LgId { get; set; }
    }
}
