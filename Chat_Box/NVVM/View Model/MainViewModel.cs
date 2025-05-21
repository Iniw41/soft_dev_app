using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat_Box.Core;
using Chat_Box.NVVM.Model;
using Chat_Box.NVVM.Net;

namespace Chat_Box.NVVM.View_Model
{
    class MainViewModel : ObservableObject
    {

        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        /* Commands */
        public RelayCommand ConnectToServerCommand { get; set; }

        private Server _server;

        public  RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set 
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }


        private string _message;

        public string Message
        {
            get { return _message; }
            set { 
                _message = value; 
                OnPropertyChanged();

                if (_selectedContact != null)
                {
                    
                }
            }
        }



        public MainViewModel()
        {
            _server  = new Server();
            ConnectToServerCommand = new RelayCommand(o => _server.ConnectToServer());

            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Username = "Iniw",
                    Username_Color = "#409AFF",
                    Image_Source = "Icons/Biniw.png",
                    Message = Message,
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = true,
                });
                Message = "";
            });

            Messages.Add(new MessageModel()
            {
                Username = "John Doe",
                Username_Color = "#409AFF",
                Image_Source = "Icons/Biniw.png",
                Message = "Nigga",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel()
                {
                    Username = "Alo",
                    Username_Color = "#409AFF",
                    Image_Source = "Icons/Biniw.png",
                    Message = "Nigga",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }
            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel()
                {
                    Username = "John Doe",
                    Username_Color = "#409AFF",
                    Image_Source = "Icons/Biniw.png",
                    Message = "Nigga",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });
            }

            Messages.Add(new MessageModel()
            {
                Username = "John Doe",
                Username_Color = "#409AFF",
                Image_Source = "Icons/Biniw.png",
                Message = "Bitch Ass",
                Time = DateTime.Now,
                IsNativeOrigin = true
            });

           
            Contacts.Add(new ContactModel
            {
                Username = $"Biniw Group Chat",
                Image_Source = "https://dinopixel.com/preload/0523/SLIME-3.png",
                Messages = Messages
            });
 
        }
    }
}
