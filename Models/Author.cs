using System.ComponentModel.DataAnnotations;

namespace Isip_Beniamin_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        [Display(Name = "Author")]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

    }
}
