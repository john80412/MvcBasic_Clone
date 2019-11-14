using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Info
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name必須輸入")]
        [StringLength(20,MinimumLength = 3,ErrorMessage ="最少需要三個字元")]
        public string Name { get; set; }
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "需為09xx-xxx-xxx格式")]
        [Required(ErrorMessage = "Phone必須輸入")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email必須輸入")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Gender必須輸入")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Address必須輸入")]
        public string Address { get; set; }
    }
}