using System;
using System.Collections.Generic;
using System.Text;

namespace ex0tutorial5.Entities.Enums
{
    internal enum OrderStatus:int 
    {
        PENDING_PAYMENT=0,
        PROCESSING=1,
        SHIPPING=2,
        DELIVERED=3
    }
}
