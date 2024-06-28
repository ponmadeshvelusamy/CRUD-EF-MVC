using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAppLibrary.Model
{
    public class Constitutemodel
    {
        [Key]
        public long Constituteid { get; set; }
        public string Constitutename { get; set; }
        public string Totalofconstitute { get; set; }
        public string Totalofmale { get; set; }
        public string Totaloffemale { get; set; }
      
    }
}
