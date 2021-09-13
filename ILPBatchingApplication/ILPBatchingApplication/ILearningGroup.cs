using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILPBatchingApplication
{
    interface ILearningGroup
    {
        int LGId { get;}
        string Stream { get; set; }
        DateTime JoiningDate { get; set; }
    }
}
