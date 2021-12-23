using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItServiceApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage="Kullanıcı adı alanı gereklidir")]
        public string UserName { get; set; }
        [Display(Name ="Ad")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad alanı gereklidir")]
        [Display(Name = "Soyad")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "E-mail alanı gereklidir")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre alanı gereklidir")]
        [StringLength(100,MinimumLength=6,ErrorMessage ="Şifreniz minumum 6 karakterli olmalıdır!" )]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre alanı gereklidir")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        [Compare(nameof(Password),ErrorMessage ="Şifre uyuşmuyor")]
        public string ConfirmPassword { get; set; }

    }
}
