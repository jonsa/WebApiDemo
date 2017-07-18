using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    public class ValueModel
    {
        [Required]
        public string Value { get; set; }
    }
}
