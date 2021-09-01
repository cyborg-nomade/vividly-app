using System.Collections.Generic;

namespace vividly_app.DTOs
{
    public class RentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}