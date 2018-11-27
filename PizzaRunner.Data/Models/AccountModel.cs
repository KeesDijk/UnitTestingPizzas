using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaRunner.Data.Models
{
    public class AccountModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Owner { get; set; }

        public decimal Balance { get; set; }

        public string LegacyMarker { get; set; }
    }
}