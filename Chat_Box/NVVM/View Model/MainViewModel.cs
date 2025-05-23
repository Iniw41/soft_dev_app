using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat_Box.Core;
using Chat_Box.NVVM.Model;
using Chat_Box.NVVM.Net;
using Microsoft.Data.SqlClient;

namespace Chat_Box.NVVM.View_Model
{
    public class MainViewModel : ObservableObject
    {
        private string _username = string.Empty;
        public string username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        private string _email = string.Empty;
        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }

        private int _age;
        public int Age
        {
            get => _age;
            set { _age = value; OnPropertyChanged(); }
        }

        private string _password = string.Empty;
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        private string _message = string.Empty;
        public string Message
        {
            get => _message;
            set { _message = value; OnPropertyChanged(); }
        }

        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        private ContactModel _selectedContact;
        public ContactModel SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                if (_selectedContact != null)
                {
                    _selectedContact.Messages = LoadChatHistory(username, _selectedContact.Username);
                }
                OnPropertyChanged();
            }
        }

        public RelayCommand ConnectToServerCommand { get; set; }
        public RelayCommand SendCommand { get; set; }

        private Server _server;

        public MainViewModel()
        {
            _server = new Server();
            _server.connectedEvent += UserConnected;
            _server.msgReciveEvent += MessageRecive;
            _server.UserDisconnectEvent += RemoveUser;
            ConnectToServerCommand = new RelayCommand(o => _server.ConnectToServer(username));
   

            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            LoadContactsFromDatabase();

            SendCommand = new RelayCommand(o =>
            {
                if (SelectedContact == null || string.IsNullOrWhiteSpace(Message))
                    return;

                string connectionString = "Server=INIW;Database=Iniw_Chat_DB;Trusted_Connection=True;TrustServerCertificate=True;";
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                            INSERT INTO Chats (SenderUsername, ReceiverUsername, MessageText, SentTime)
                            VALUES (@sender, @receiver, @message, @time)";
                    cmd.Parameters.AddWithValue("@sender", username);
                    cmd.Parameters.AddWithValue("@receiver", SelectedContact.Username);
                    cmd.Parameters.AddWithValue("@message", Message);
                    cmd.Parameters.AddWithValue("@time", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                SelectedContact.Messages.Add(new MessageModel
                {
                    Username = username,
                    Username_Color = "#409AFF",
                    Message = Message,
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                    FirstMessage = true,
                    Image_Source = "https://i.redd.it/9ydxs78g66e61.png"
                });
                Message = "";
            });
        }

        private void RemoveUser()
        {
            var User = _server.PacketReader.ReadMessage();

            var user = Contacts.Where(x => x.Username == User).FirstOrDefault();

            System.Windows.Application.Current.Dispatcher.Invoke(() =>Contacts.Remove(user));
        }

        private void MessageRecive()
        {
            var msg  = _server.PacketReader.ReadMessage();
            System.Windows.Application.Current.Dispatcher.Invoke(() => Message);
        }

        private void UserConnected()
        {
            // Handle user connected event
            var user = new ContactModel();
            {
                username = _server.PacketReader.ReadMessage();
            };

            if (!Contacts.Any(x => x.Id == user.Id))
            {
                System.Windows.Application.Current.Dispatcher.Invoke(() =>
                {
                    Contacts.Add(user);
                });
            }
        }

        private ObservableCollection<MessageModel> LoadChatHistory(string user1, string user2)
        {
            var messages = new ObservableCollection<MessageModel>();
            string connectionString = "Server=INIW;Database=Iniw_Chat_DB;Trusted_Connection=True;TrustServerCertificate=True;";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                        SELECT SenderUsername, MessageText, SentTime
                        FROM Chats
                        WHERE (SenderUsername = @user1 AND ReceiverUsername = @user2)
                           OR (SenderUsername = @user2 AND ReceiverUsername = @user1)
                        ORDER BY SentTime";
                cmd.Parameters.AddWithValue("@user1", user1);
                cmd.Parameters.AddWithValue("@user2", user2);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        messages.Add(new MessageModel
                        {
                            Username = reader.GetString(0),
                            Username_Color = "#409AFF",
                            Message = reader.GetString(1),
                            Time = reader.GetDateTime(2),
                            Image_Source = "https://i.redd.it/9ydxs78g66e61.png",
                            IsNativeOrigin = reader.GetString(0) == username
                        });
                    }
                }
            }
            return messages;
        }

        public void LoadContactsFromDatabase()
        {
            string connectionString = "Server=INIW;Database=Iniw_Chat_DB;Trusted_Connection=True;TrustServerCertificate=True;";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT id, username FROM Users WHERE username <> @currentUser";
                cmd.Parameters.AddWithValue("@currentUser", username ?? "");

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Contacts.Add(new ContactModel
                        {
                            Username = reader.GetString(1),
                            Image_Source = "https://i.redd.it/9ydxs78g66e61.png",
                            Messages = new ObservableCollection<MessageModel>()
                        });
                    }
                }
            }
        }
    }
}


/***Username = username,
                    Username_Color = "#409AFF",
                    Image_Source = "https://i.redd.it/9ydxs78g66e61.png",
                    Message = Message,
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = true,
***/