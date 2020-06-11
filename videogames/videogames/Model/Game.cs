using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace videogames.Model
{
    [Table("games",Schema = "public")]
    public class Game
    {
        [Key,Column("id")]
        public long id { get; set; }

        [Column("title")]
        public string title { get; set; }
        
        [Column]
        public string phrase { get; set; }
        
    }
}