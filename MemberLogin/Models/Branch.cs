using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MemberLogin.Models
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public string City { get; set; }
        public string Head { get; set; }
        public string Address { get; set; }
    }
}
