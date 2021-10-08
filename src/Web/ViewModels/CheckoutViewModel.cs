using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels
{
    public class CheckoutViewModel
    {
        public BasketViewModel Basket { get; set; }

        [Required, MaxLength(180)]
        public string Street { get; set; }

        [Required, MaxLength(100)]
        public string City { get; set; }

        [Required, MaxLength(60)]
        public string State { get; set; }

        [Required, MaxLength(18)]
        public string ZipCode { get; set; }

        [Required, MaxLength(90)]
        public string Country { get; set; }

        [Required, MaxLength(50)]
        public string CCOwner { get; set; }

        [Required, MaxLength(16), RegularExpression("^[0-9]{16}$", ErrorMessage = "Invalid card number.")]
        public string CCNumber { get; set; }

        [Required, MaxLength(5), RegularExpression(@"^(0[1-9]|1[0-2])\/[0-9]{2}$", ErrorMessage = "Invalid expiration date.")]
        public string CCExpiration { get; set; }

        [Required, MaxLength(3), RegularExpression("^[0-9]{3}$", ErrorMessage = "Invalid CVV number.")]
        public string CCCvv { get; set; }
    }
}
