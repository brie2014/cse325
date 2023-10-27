using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public string? Book { get; set; }
        public string? Reference { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string? Note { get; set; }
    }
}
