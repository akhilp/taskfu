using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using System.Collections;

namespace MongoTest
{
    public class Task
    {
        public ObjectId Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public bool Complete { get; set; }
        public DateTime Date { get; set; }
        public List<Task> Tasks { get; set; }
 
        public Task()
        { 
        }
    }
}
