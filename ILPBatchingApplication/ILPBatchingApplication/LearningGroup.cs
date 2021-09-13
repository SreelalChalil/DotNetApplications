using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILPBatchingApplication
{
    class LearningGroup : ILearningGroup
    {
        static int incrementId = 1000;
        private int lgID;
        private string stream;
        private DateTime joiningDate;

        public LearningGroup(string stream, DateTime joiningDate)
        {
            this.lgID = incrementId++;
            Stream = stream;
            JoiningDate = joiningDate;
        }

        public int LGId
        {
            get { return lgID; }
        }

        public string Stream
        {
            get { return stream; }
            set { stream = value; }
        }

        public DateTime JoiningDate
        {
            get { return joiningDate; }
            set {
                    if(((value > DateTime.Now) && (value < DateTime.Now.AddMonths(2))))
                        joiningDate = value;
                    else  throw new Exception("Date of Joining is Invalid");  
                }
        }

    }
}
