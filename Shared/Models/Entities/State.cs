using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorCodeFirst.Shared.Models.Entities
{
   
    public  class State
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Code { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
