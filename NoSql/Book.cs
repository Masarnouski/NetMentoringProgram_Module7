using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql
{
    internal class Book
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Count { get; set; }
        public List<string> Genre { get; set; }
        public DateTime Year { get; set; }
    }
}
