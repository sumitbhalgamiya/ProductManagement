using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ProductManagement.Models
{
    public class Products
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
    }
}
