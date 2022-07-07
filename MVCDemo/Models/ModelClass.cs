using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class ModelClass
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }
        
       
    }
}
