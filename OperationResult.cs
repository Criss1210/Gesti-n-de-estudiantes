using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiantesPorAsignatura
{
    public class OperationResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public dynamic Data { get; set; }

        public OperationResult(string message, bool success, dynamic data = null)
        {
            Message = message;
            Success = success;
            Data = data;
        }
    }
}
