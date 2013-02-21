using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var connectionString = "mongodb://mongousr:reznor@ds045047.mongolab.com:45047";
                var client = new MongoClient(connectionString);
                var server = client.GetServer();
                var database = server.GetDatabase("taskfu"); // "taskfu" is the name of the database
                var collection = database.GetCollection<Task>("tasks"); // "class" is the name of the collection

                //Task errand = new Task();
                //errand.UserId = "akhilp";
                //errand.Name = "Drop off dry cleaning";
                //errand.Complete = false;
                //errand.Date = DateTime.Parse("2013-02-28");
                //collection.Insert(errand);

                Task chore = new Task();
                chore.UserId = "akhilp";
                chore.Name = "Clean room";
                chore.Complete = false;
                chore.Date = DateTime.Parse("2013-02-22");

                Task subchore = new Task();
                subchore.UserId = "akhilp";
                subchore.Name = "Sweep floor";
                subchore.Complete = false;
                chore.Date = DateTime.Parse("2013-02-21");

                Task subchore2 = new Task();
                subchore2.UserId = "akhilp";
                subchore2.Name = "Pick up toys";
                subchore2.Complete = false;
                subchore2.Date = DateTime.Parse("2013-02-20");

                List<Task> subtasks = new List<Task>();
                subtasks.Add(subchore);
                subtasks.Add(subchore2);

                chore.Tasks = subtasks;
                collection.Insert(chore);

                //var query = Query.GT("age", 27);
                //var cursor = collection.Find(query);
                //foreach (Task t in cursor)
                //{
                //    Console.WriteLine(t.Name);
                //}
            }
            catch (MongoException mex)
            {
                Console.WriteLine(mex.Message);
            }
        }
    }
}
