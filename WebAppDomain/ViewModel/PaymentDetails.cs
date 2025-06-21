using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppDomain.ViewModel
{
    public class PaymentDetails
    {
        public int PMId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string CardExpirationDate { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(3)")]
        public string CVV { get; set; }

    }
}
