using System;
using System.Collections.Generic;
using System.Text;

namespace ServeMe.Core.Domain.Response
{
    public interface IResponse
    {
        bool Success { get; }
        ValidationMessage Message { get; }
    }
    public interface IResponse<T> : IResponse
    {
        T Content { get; set; }
    }

    public struct ValidationMessage
    {
        public int Code { get; private set; }
        public string Message { get; private set; }

        public ValidationMessage(int code, string message)
        {
            this.Code = code;
            this.Message = message;
        }
    }
}
