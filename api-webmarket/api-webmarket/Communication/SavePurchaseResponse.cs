using api_webmarket.Domain.Models;
using api_webmarket.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Communication
{
    public class SavePurchaseResponse : BaseResponse
    {
        public Purchase Purchase { get; private set; }

        private SavePurchaseResponse(bool sucess, string message, Purchase purchase) : base(sucess, message)
        {
            Purchase = purchase;
        }

        /// <summary>
        /// Creates a sucess response.
        /// </sumary>
        /// <param name="purchase">Saved category.</param>
        /// <returns>Response.</returns>

        public SavePurchaseResponse(Purchase Purchase) : this(true, string.Empty, Purchase)
        { }

        /// <summary>
        /// Creates an error response
        /// </summary>
        /// <param name ="message">Error message</param>
        /// <returns>Response.</returns>

        public SavePurchaseResponse(string message) : this(false, message, null)
        { }
    }
}
