using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunescapeCalculators.Models.RunescapeViewModels
{
    public class RunescapeUserFormViewModel
    {

        public Guid Id { get; set; }
        [DisplayName("Runescape Username")]
        [Required]
        public string UserName { get; set; }

        [DisplayName("Maxed account")]
        public bool IsMaxxed { get; set; }

    }
}
