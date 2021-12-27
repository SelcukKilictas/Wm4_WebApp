using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItServiceApp.ViewModels
{
    public class PasswordUpdateViewModel
    {
        [Required(ErrorMessage = " Eski Şifre alanı gereklidir")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifreniz minumum 6 karakterli olmalıdır!")]
        [Display(Name = " Eski Şifre")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Eski Şifre alanı gereklidir")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifreniz minumum 6 karakterli olmalıdır!")]
        [Display(Name = "Yeni Şifre")]
        [DataType(DataType.Password)]


        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı gereklidir")]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni Şifre")]
        [Compare(nameof(NewPassword), ErrorMessage = "Şifreler uyuşmuyor")]

        public string ConfirmPasswor { get; set; }

    }
}
