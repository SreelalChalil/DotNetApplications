using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILPBatchingApplication
{
    class Associate : IAssociate
    {
        static int incrementId = 1000;
        int associateId;
        string name;
        bool isGR=false;
        int lgId;

        public Associate(string name, bool isGR, int lgId)
        {
            associateId = incrementId++;
            Name = name;
            IsGR = isGR;
            LgId = lgId;
        }

        public int AssociateId
        {
            get
            {
                return associateId;
            }

        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public bool IsGR
        {
            get
            {
                return isGR;
            }

            set
            {
                isGR = value;
            }
        }

        public int LgId
        {
            get
            {
                return lgId;
            }

            set
            {
                lgId = value;
            }
        }
    }
        
}
