using System;

namespace Wijsheid.Domain
{
    public class Aluno
    {
        public string Nome { get; set; }

        public bool IsValid()
        {
            return !(string.IsNullOrEmpty(Nome) || string.IsNullOrWhiteSpace(Nome));
        }
    }
}
