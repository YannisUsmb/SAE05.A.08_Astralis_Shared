using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CommandCheckoutDto
    {
        [Required(ErrorMessage = "The delivery address is required.")]
        public int DeliveryAddressId { get; set; }

        [Required(ErrorMessage = "The invoicing address is required.")]
        public int InvoicingAddressId { get; set; }

        [Required(ErrorMessage = "The payment token is required.")]
        [StringLength(500, ErrorMessage = "The payment token seems too long.")]
        public string? PaymentToken { get; set; }
    }
}
