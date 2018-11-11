using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.Infrastructure
{
    public class OperationResult
    {
        private OperationResult() { }
        public static OperationResult Success() =>
            new OperationResult
            {
                IsSuccess = true
            };

        public static OperationResult Error(string errorMessage)
        {
            return new OperationResult
            {
                IsSuccess = false,
                ErrorMessage = errorMessage
            };
        }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class OperationResult<T>
    {
        private OperationResult() { }
        
        public static OperationResult<T> Success(T result)
        {
            return new OperationResult<T>
            {
                IsSuccess = true,
                Result = result
            };
        }

        public static OperationResult<T> Error(string errorMessage)
        {
            return new OperationResult<T>
            {
                IsSuccess = false,
                ErrorMessage = errorMessage
            };
        }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public T Result { get; set; }
    }
}


