using System;
using System.Collections.Generic;

namespace BackEndAdvOnline.Models
{
    public partial class TblEndereco
    {
        public int NIdEndereco { get; set; }
        public int? NIdPessoa { get; set; }
        public string SCep { get; set; }
        public int? NNumero { get; set; }
        public string SComplemento { get; set; }
    }
}
