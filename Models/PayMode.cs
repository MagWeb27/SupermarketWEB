using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWeb.Models
{
    public class PayMode
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Observation { get; set; }

        public ICollection<Invoice>? Invoices { get; set; } = default!;
    }
}
