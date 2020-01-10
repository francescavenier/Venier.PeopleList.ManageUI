using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venier.PeopleList.Data;

namespace Venier.PeopleList.ManageUI
{
    public partial class Form1 : Form
    {
        public CloudQueue Queue { get; set; }
        public Form1()
        {
            InitializeComponent();
            // Connection to Azure
            Auth auth = new Auth();
            var storageAccount = CloudStorageAccount.Parse(auth.connectionString);
            var queueClient = storageAccount.CreateCloudQueueClient();

            Queue = queueClient.GetQueueReference("myqueue");
            Queue.CreateIfNotExists();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            People user = new People();
            user.name = txtName.Text;
            user.surname = txtSurname.Text;
            user.birthDate = DateTime.Parse(txtBirthDate.Text);
            user.address = txtAddress.Text;

             //Serialize message
            var JsonMessage = JsonConvert.SerializeObject(user);

            //Insert message in queue
            CloudQueueMessage queueMessage = new CloudQueueMessage(JsonMessage);
            Queue.AddMessage(queueMessage);
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtBirthDate.Text = string.Empty;
            txtAddress.Text = string.Empty;

        }
    }
}
