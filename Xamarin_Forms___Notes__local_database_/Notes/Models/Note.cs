using System;
using SQLite;

namespace Notes.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
        public DateTime Date { get; set; }
    }
}
