using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Helpers
{
    public enum Epayment : byte
    {
        [Description("BO")]
        Boleto = 0,

        [Description("CC")]
        CreditCard = 1,

        [Description("PX")]
        Pix = 2,

    }
}
