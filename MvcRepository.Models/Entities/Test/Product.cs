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
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [StringLength(50)]
        [DisplayName("產品名稱")]
        public string ProductName { get; set; }

        [StringLength(200)]
        [DisplayName("產品描述")]
        public string ProductDescription { get; set; }

        [DisplayName("產品價格")]
        public int Price { get; set; }
        
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
