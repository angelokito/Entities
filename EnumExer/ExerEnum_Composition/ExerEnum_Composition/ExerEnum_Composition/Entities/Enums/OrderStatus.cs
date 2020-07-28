using System;
using System.Collections.Generic;
using System.Text;

namespace ExerEnum_Composition.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2, // Shipped = enviado
        Delivered = 3


    }
}
