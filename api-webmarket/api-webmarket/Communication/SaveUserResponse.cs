using api_webmarket.Domain.Models;
using api_webmarket.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Communication
{
    public class SaveUserResponse : BaseResponse
    {
        public User User { get; private set; }

        private SaveUserResponse(bool sucess, string message, User user) : base(sucess, message)
        {
            User = user;
        }

        /// <summary>
        /// Creates a sucess response.
        /// </sumary>
        /// <param name="user">Saved category.</param>
        /// <returns>Response.</returns>

        public SaveUserResponse(User user) : this(true, string.Empty, user)
        { }

        /// <summary>
        /// Creates an error response
        /// </summary>
        /// <param name ="message">Error message</param>
        /// <returns>Response.</returns>

        public SaveUserResponse(string message) : this(false, message, null)
        { }
    }
}
