using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vividly_app.DTOs
{
    public class MembershipTypeDto
    {
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}