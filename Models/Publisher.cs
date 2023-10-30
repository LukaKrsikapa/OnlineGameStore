using System.ComponentModel.DataAnnotations;

namespace ZavrsniRad.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
        public IEnumerable<Game> Games { get; set; }
    }
}
