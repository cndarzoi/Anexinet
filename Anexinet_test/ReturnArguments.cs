using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anexinet_test
{
    public struct returnArguments
    {
        public returnArguments(string messageParam, string valueParam)
        {
            Message = messageParam;
            Value = valueParam;
        }

        /// <summary>
        /// Message arguments
        /// </summary>
        public string Message { get; set; }
        

        /// <summary>
        /// Value arguments
        /// </summary>
        public object Value { get; set; }
    }
}
