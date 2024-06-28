using EFAppLibrary.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAppLibrary
{
    public class ConstituteRepos: Iconstitute
    {
        private readonly ConstituteEFW Refer;
       public ConstituteRepos(ConstituteEFW reference)
       {
            Refer= reference;
       }
        public IEnumerable<Constitutemodel> Listall()
        {
            try
            {
               return Refer.Constitutemodel.ToList();

            }catch (Exception )
            {
                throw;
            }
        }
        public void Inserting(Constitutemodel Obj)
        {
            try
            {
                Refer.Add<Constitutemodel>(Obj);
                Refer.SaveChanges();
            }
            catch (Exception )
            {
                throw;
            }
        }
    }
}
