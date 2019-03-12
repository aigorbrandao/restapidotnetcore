using System;
using System.Collections.Generic;

namespace BackEndAdvOnline.Models
{
    public partial class TblTelefone
    {
        public int NIdTelefone { get; set; }
        public string SDdd { get; set; }
        public string SFone { get; set; }
        public string SObs { get; set; }
        public int? NTipoFone { get; set; }
        public int? NIdPessoa { get; set; }

        public TblPessoa NIdPessoaNavigation { get; set; }
    }
}
