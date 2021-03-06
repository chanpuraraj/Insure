//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace checkintegration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class GarrageMaster
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Garrage Name:")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Address:")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Phone Number:")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        public string PhoneNo { get; set; }

        [Required]
        [Display(Name = "Owner Name:")]
        public string OwnerName { get; set; }

        [Display(Name = "Description:")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Authorise Garrage:")]
        public int IsAuth { get; set; }

        [Required]
        [Display(Name = "Created By:")]
        public int CreatedBy { get; set; }
    }
}
