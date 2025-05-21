using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Box.NVVM.Model
{
    public class MessageModel
    {
        public string Username { get; set; }
        public string Username_Color { get; set; }
        public string Image_Source { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeOrigin { get; set; } // true = left, false = right
        public bool? FirstMessage { get; set; }
    }
}
