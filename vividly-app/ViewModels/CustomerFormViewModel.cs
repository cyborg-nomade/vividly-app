using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vividly_app.Models;

namespace vividly_app.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}