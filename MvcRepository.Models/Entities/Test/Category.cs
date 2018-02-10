using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcRepository.Models.Entities.Test
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [StringLength(50)]
        [DisplayName("類別名稱")]
        public string CategoryName { get; set; }

        [StringLength(50)]
        [DisplayName("類別描述")]
        public string CategoryDescription { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
