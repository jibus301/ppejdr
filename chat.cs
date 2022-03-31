using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SocketIOClient;


namespace formjdrppe
{
    public partial class chat : Form
    {
        public static string message;
        private static SocketIO socket;

        
        public delegate void Connect() ;
        public delegate void AddMessage(String message);
        public AddMessage addMessage;

        public chat()
        {
            Uri uri = new Uri("http://localhost:11004/");

            socket = new SocketIO(uri, new SocketIOOptions
            {
                Query = new Dictionary<string, string>
                            {
                                {"token", "V4" }
                            },
            });

            socket.On("hi", response =>
            {
                // Console.WriteLine(response.ToString());
                //Console.WriteLine(response.GetValue<string>());
                message = response.ToString();
               
                if (message != "" && message != null)
                {
                    Invoke(this.addMessage, new object[] { message });
                }
            });

            addMessage = new AddMessage(AddMessageMethod);
            socket.OnConnected += Socket_OnConnected;
            socket.OnConnected += async (sender, e) =>
            {
                string username = global.charaName;
                if (username == "" || username == null)
                {
                    username = global.user;
                }

                // Emit a string
                await socket.EmitAsync("hi", username + " vient de se connecter");

                // Emit a string and an object
                var dto = new FileDTO { Id = 123, Name = "bob" };
                await socket.EmitAsync("register", "source", dto);
            };

            


            InitializeComponent();
            ConnectMethod();
        }

        private async void  Socket_OnConnected(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public static async void ConnectMethod()
        {
            await socket.ConnectAsync();
        }

        public void AddMessageMethod(String message)
        {
            listBoxMessage.Items.Add(message.Replace("[","").Replace("]","").Replace("\"",""));
        }

        public static async void SendMsg(string message)
        {
            string username = global.charaName;
            if (username == "" || username == null) 
            {
                username = global.user;
            }
            //await socket.ConnectAsync();
            object[] data = new object[] {username + ": " +message};
            await socket.EmitAsync("hi", data);
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            string msg = textBoxSending.Text;
            SendMsg(msg);
        }

        private void textBoxSending_TextChanged(object sender, EventArgs e)
        {

        }

        private void chat_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }

}
