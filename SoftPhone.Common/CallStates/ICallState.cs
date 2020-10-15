using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.CallStates
{
    public interface ICallState
    {
        public ICallState Idle();
        public ICallState RingingIncomingCall();
        public ICallState ActiveIncomingCall();
        public ICallState RingingOutgoingCall();
        public ICallState ActiveOutgoingCall();
    }
}
