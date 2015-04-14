using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    [Serializable]
    public class CarIsDeadException : ApplicationException
    {
        public CarIsDeadException()
        {
        }

        public CarIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        private DateTime errorTimeStamp;
        private string causeOfError;

        protected DateTime ErrorTimeStamp
        {
            get { return errorTimeStamp; }
            set { errorTimeStamp = value; }
        }
        public string CauseOfError
        {
            get { return causeOfError; }
            set { causeOfError = value; }
        }

        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
