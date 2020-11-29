using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Data.Transports
{
    public class TransportBase
    {
        public event Action<string> StatusUpdated;

        public void OnStatusUpdated(string update)
        {
            StatusUpdated?.Invoke(update);
        }
    }
}
