namespace Tracker.Models
{
    public class Category
    {
        public int CategoryId { get; set; } 
        public string CategoryName { get; set; } 
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
