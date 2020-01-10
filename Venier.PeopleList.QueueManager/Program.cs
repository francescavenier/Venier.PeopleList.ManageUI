using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Venier.PeopleList.Data;

namespace Venier.PeopleList.QueueManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int wait = 3000;
            People user = new People();

            // Connection to Azure
            Auth auth = new Auth();
            var storageAccount = CloudStorageAccount.Parse(auth.connectionString);
            var queueClient = storageAccount.CreateCloudQueueClient();

            CloudQueue queue = queueClient.GetQueueReference("myqueue");

            while (true)
            {
                var queueMessage = queue.PeekMessage();
                if (queueMessage != null)
                {
                    // Deserialize message
                    user = JsonConvert.DeserializeObject<People>(queueMessage.AsString);
                    if(user.appId == "Venier")
                    {
                        Console.WriteLine("Message:\nName: {0}\nSurname: {1}\nBirth date: {2}\nAddress: {3}",
                                            user.name, user.surname, user.birthDate.ToShortDateString(), user.address);
                        queue.DeleteMessage(queueMessage);
                    }
                    else 
                    {
                        Console.WriteLine("One message founded but it is not yours.");
                    }
                }
                else
                {
                    Console.WriteLine("No message available.");
                    wait = wait + 2000;
                }
                Thread.Sleep(wait);
            }
        }
    }
}
