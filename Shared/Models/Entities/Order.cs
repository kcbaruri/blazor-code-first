using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorCodeFirst.Shared.Models.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string StateCode { get; set; }
        public string Details { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
