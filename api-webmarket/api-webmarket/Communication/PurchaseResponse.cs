using api_webmarket.Domain.Models;
using api_webmarket.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Communication
{
    public class PurchaseResponse : BaseResponse
    {
        public Purchase Purchase { get; private set; }

        private PurchaseResponse(bool sucess, string message, Purchase purchase) : base(sucess, message)
        {
            Purchase = purchase;
        }

        /// <summary>
        /// Creates a sucess response.
        /// </sumary>
        /// <param name="purchase">Saved category.</param>
        /// <returns>Response.</returns>

        public PurchaseResponse(Purchase Purchase) : this(true, string.Empty, Purchase)
        { }

        /// <summary>
        /// Creates an error response
        /// </summary>
        /// <param name ="message">Error message</param>
        /// <returns>Response.</returns>

        public PurchaseResponse(string message) : this(false, message, null)
        { }
    }
}
