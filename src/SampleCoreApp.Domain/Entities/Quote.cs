using System.ComponentModel.DataAnnotations.Schema;

namespace SampleCoreApp.Domain.Entities
{
    [Table("Quote", Schema = "samurai")]
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Samurai Samurai { get; set; }
        public int SamuraiId { get; set; }
    }
}