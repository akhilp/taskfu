using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace MongoTest
{
    public class Student
    {
        public ObjectId Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public Student()
        {
        }

        public string getFullName()
        {
            return firstName + " " + lastName;
        }
    }
}
