using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files");
            string pathFile = Path.Combine(path, "francesca.venier.txt");
            
            // Connection to Azure
            Auth auth = new Auth();
            var storageAccount = CloudStorageAccount.Parse(auth.connectionString);
            var queueClient = storageAccount.CreateCloudQueueClient();

            CloudQueue queue = queueClient.GetQueueReference("myqueue");

            while (true)
            {
                var queueMessage = queue.GetMessage();
                if (queueMessage != null)
                {
                    // Deserialize message
                    user = JsonConvert.DeserializeObject<People>(queueMessage.AsString);
                    if(user.appId == "Venier")
                    {
                        Console.WriteLine("Message:\nName: {0}\nSurname: {1}\nBirth date: {2}\nAddress: {3}",
                                            user.name, user.surname, user.birthDate.ToShortDateString(), user.address);
                        queue.DeleteMessage(queueMessage);

                        // Verify directory
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }

                        // Insert in francesca.venier.txt
                        if (!File.Exists(pathFile))
                        {
                            // Create a file to write to.
                            using (StreamWriter sw = File.AppendText(pathFile))
                            {
                                sw.WriteLine("{0}: Name: {1}, Surname: {2}, Birth date: {3}, Address: {4};", DateTime.Now,
                                            user.name, user.surname, user.birthDate.ToShortDateString(), user.address);
                            }
                        }
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
