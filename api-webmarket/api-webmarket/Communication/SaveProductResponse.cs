using api_webmarket.Domain.Models;
using api_webmarket.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Communication
{
    public class SaveProductResponse : BaseResponse
    {
        public Product Product { get; private set; }

        private SaveProductResponse(bool sucess, string message, Product product) : base(sucess, message)
        {
            Product = product;
        }

        /// <summary>
        /// Creates a sucess response.
        /// </sumary>
        /// <param name="product">Saved category.</param>
        /// <returns>Response.</returns>

        public SaveProductResponse(Product Product) : this(true, string.Empty, Product)
        { }

        /// <summary>
        /// Creates an error response
        /// </summary>
        /// <param name ="message">Error message</param>
        /// <returns>Response.</returns>

        public SaveProductResponse(string message) : this(false, message, null)
        { }
    }
}
