using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ZavrsniRad.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        public List<OrderDetail>? OrderDetails { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First name")]
        [StringLength(50, ErrorMessage = "First name cannot contain more than 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last name")]
        [StringLength(50, ErrorMessage = "Last name cannot contain more than 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [StringLength(100, ErrorMessage = "Address cannot contain more than 100 characters")]
        [Display(Name = "Address Line 1")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your zip code")]
        [Display(Name = "Zip code")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Zip code must contain between 4 and 10 characters")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        [StringLength(50, ErrorMessage = "Name of the city cannot contain more than 50 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your country")]
        [StringLength(50, ErrorMessage = "Name of the country cannot contain more than 50 characters")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [StringLength(25, ErrorMessage = "Phone number cannot contain more than 25 characters")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}
