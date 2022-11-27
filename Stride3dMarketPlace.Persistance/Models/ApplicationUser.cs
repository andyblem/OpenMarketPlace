using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3dMarketplace.Persistance.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool? IsAgreeingToPublisherTermsOfService { get; set; }

        public string? ProfilePhoto { get; set; }

        public int? PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher? Publisher { get; set; }
    }
}
