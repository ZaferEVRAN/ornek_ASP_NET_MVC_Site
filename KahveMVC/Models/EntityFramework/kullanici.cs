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

    public partial class kullanici
    {
        public int id { get; set; }

        [Display(Name = "Kullan�c� Ad�")]
        [Required(ErrorMessage = "L�tfen kullan�c� ad�n�z� giriniz!")]
        public string ad { get; set; }

        [Display(Name = "Parola")]
        [Required(ErrorMessage = "L�tfen parolan�z� giriniz!")]
        public string sifre { get; set; }

        public virtual bool BeniHatirla { get; set; }
    }
}
