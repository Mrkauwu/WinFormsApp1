using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class PetModel
    {
        [DisplayName("Pet ID")]
        public int Id { get; set; }

        [DisplayName("Pet Name")]
        [Required(ErrorMessage = "Pet name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet type is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet type must be between 3 and 50 characters")]
        public string Type { get; set; }

        [DisplayName("Pet Colour")]
        [Required(ErrorMessage = "Pet colour is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet colour must be between 3 and 50 characters")]
        public string Colour { get; set; }
    }

}
