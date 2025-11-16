using System.ComponentModel;

namespace Isip_Beniamin_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [DisplayName("Publisher")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
