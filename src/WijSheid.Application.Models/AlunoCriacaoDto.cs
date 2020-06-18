using System.ComponentModel.DataAnnotations;

namespace WijSheid.Application.Models
{
    public  class AlunoCriacaoDto
    {
        [Required]
        public string Nome { get; set; }
    }
}
