using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILPBatchingApplication
{
    interface IBatch
    {
        int AddLG(ILearningGroup lg);
        int AddAssociate(IAssociate associate);
        List<IAssociate> ViewAllAssociates();
        IAssociate EditAssociate(int associateId, bool isGR);
        int DeleteLG(int lgId);
    }
}
