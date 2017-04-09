using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleCoreApp.Domain.Entities
{
    [Table("Samurai", Schema = "samurai")]
    public class Samurai
    {
        public Samurai()
        {
            Quotes = new List<Quote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public int? BattleId { get; set; }
    }
}