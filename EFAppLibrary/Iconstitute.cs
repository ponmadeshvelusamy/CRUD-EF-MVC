using EFAppLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAppLibrary
{
    public interface Iconstitute
    {
        public IEnumerable<Constitutemodel> Listall();
        public void Inserting(Constitutemodel Obj);
    }
}
