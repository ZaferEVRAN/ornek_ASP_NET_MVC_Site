//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KahveMVC.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class magazasaat
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "G�n")]
        public string gun { get; set; }

        [Required]
        [Display(Name = "Saat")]
        public string saat { get; set; }
    }
}
