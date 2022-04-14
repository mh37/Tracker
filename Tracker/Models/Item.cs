using System.ComponentModel.DataAnnotations.Schema;

namespace Tracker.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string? Details  { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;


        public int? CategoryId { get; set; }//Foreign Key
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
    }
}
