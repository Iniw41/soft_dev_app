using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.NVVM.Model
{
    internal class Contact_Model
    {
        public string Username { get; set; }
        public string Image_Source { get; set; }
        public ObservableCollection<Message_Model> Messages { get; set; }
        public string LastMessage => Messages.Last().Message;
    }
}
