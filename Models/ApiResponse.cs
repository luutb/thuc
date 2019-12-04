using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.Models
{
    public class ApiResponse<T>
    {
        public int error;
        public string message;
        public T data;
    }
}