using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServeMe.Core.Domain.Response;
using ServeMe.Infrastructure.CrossCutting.Response;

namespace ServeMe.Infrastructure.CrossCutting.Response
{
    public class Response : IResponse
    {
        public ValidationMessage Message { get; internal set; }

        public bool Success { get; internal set; } = true;

        public static Response CreateResponse(ValidationMessage? message = null)
        {
            return new Response
            {
                Message = message ?? CreateValidationMessage(ValidationMessages.SUCCESS),
                Success = true
            };
        }
        public static Response CreateResponse(string message)
        {
            return CreateResponse(CreateValidationMessage(message));
        }
        public static Response<T> CreateResponse<T>(T content, ValidationMessage validationMessage)
        {
            var response = new Response<T>
            {
                Content = content,
                Success = true,
                Message = validationMessage
            };

            return response;
        }
        public static Response<T> CreateResponse<T>(T content, string message = null)
        {
            message = message ?? ValidationMessages.SUCCESS;
            return CreateResponse(content, CreateValidationMessage(message));
        }

        public static Response CreateErrorResponse(ValidationMessage message)
        {
            return new Response
            {
                Message = message,
                Success = false
            };
        }
        public static Response CreateErrorResponse(string message)
        {
            return CreateErrorResponse(CreateValidationMessage(message));
        }
        public static Response<T> CreateErrorResponse<T>(ValidationMessage message, T content = default(T))
        {
            var response = new Response<T>
            {
                Content = content,
                Success = false,
                Message = message,
            };

            return response;
        }

        public static Response<T> CreateErrorResponse<T>(string message, T content = default(T))
        {
            return CreateErrorResponse(CreateValidationMessage(message), content);
        }

        public static ValidationMessage CreateValidationMessage(string messageWithId)
        {
            int id;
            string[] idAndMessage = messageWithId.Split('-');
            if (int.TryParse(idAndMessage.ElementAtOrDefault(0), out id))
            {
                return new ValidationMessage(id, idAndMessage.ElementAtOrDefault(1)?.Trim());
            }
            else
                throw new ApplicationException();
        }
    }
    
    public class Response<T> : Response, IResponse<T>
    {
        public T Content { get; set; }
    }
}
