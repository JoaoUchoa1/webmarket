using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Services
{
    public abstract class BaseResponse
    {
        public bool Sucess { get; protected set; }
        public string Message { get; protected set; }

        public BaseResponse(bool sucess, string message) 
        {
            Sucess = sucess;
            Message = message;
        }
    }
}
