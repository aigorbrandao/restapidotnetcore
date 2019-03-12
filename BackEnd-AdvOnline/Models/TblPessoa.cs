using System;
using System.Collections.Generic;

namespace BackEndAdvOnline.Models
{
    public partial class TblPessoa
    {
        public TblPessoa()
        {
            TblTelefone = new HashSet<TblTelefone>();
        }

        public int NIdPessoa { get; set; }
        public string SNome { get; set; }
        public string SCpfpj { get; set; }
        public string SIdentidade { get; set; }
        public string SMae { get; set; }
        public string SNomeApelido { get; set; }
        public string SLogin { get; set; }
        public string SSenha { get; set; }

        public ICollection<TblTelefone> TblTelefone { get; set; }
    }
}
