using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Common.Enums
{
    public enum TransactionStatus
    {
        Initiated,
        Authorized,
        Captured,
        Settled,
        Failed
    }
}
