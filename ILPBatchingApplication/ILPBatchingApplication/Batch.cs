using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILPBatchingApplication
{
    class Batch:IBatch
    {
        List<ILearningGroup> iLearningGroupList = new List<ILearningGroup>();
        List<IAssociate> iAssociateList = new List<IAssociate>();

       public int  AddLG(ILearningGroup lg)
        {
            iLearningGroupList.Add(lg);
            return lg.LGId;
        }

        public int AddAssociate(IAssociate associate)
        {
            int learnerGroupId = associate.LgId;
            int numberOfAssociates = iAssociateList.Where(assoc => assoc.LgId == learnerGroupId).Count();
            if (iLearningGroupList.Any(x => x.LGId == learnerGroupId))
            {
                if (numberOfAssociates > 40)
                {
                    throw new Exception("This Learning Group if Full!");
                }
                else
                {
                    iAssociateList.Add(associate);
                    return associate.AssociateId;
                }
            }
            else throw new Exception("Learner Group Doesnot Exist");
            
        }

        public List<IAssociate> ViewAllAssociates()
        {
            return iAssociateList;
        }

        public IAssociate EditAssociate(int associateId, bool isGR)
        {
            IAssociate assoc = iAssociateList.Find(x => x.AssociateId == associateId);
            int associateLG = assoc.LgId;
            if(iAssociateList.Any(x => x.IsGR == true  && x.LgId == associateLG)){
                throw new Exception("There is Already A GR for this Learners Group");
            }
            else
            {
                assoc.IsGR = true;
                return assoc;
            }
        }

        public int DeleteLG(int lgId)
        {
            if(iAssociateList.Where(x=> x.LgId == lgId).Count() > 0)
            {
                throw new Exception("This Learners Group Cannot be Deleted Since it's Not Empty");
            }
            else
            {
                ILearningGroup lg = iLearningGroupList.Find(x => x.LGId == lgId);
                iLearningGroupList.Remove(lg);
                return 1;
            }
        }

    }
}
