using Airlines.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Business.Repositories
{
    public class OfficeRepository
    {
        Session1Entities session1;

        public OfficeRepository()
        {
            session1 = new Session1Entities();
        }

        public List<string> GetListOffice()
        {
            List<string> result = new List<string>();
            Office office = new Office();
            foreach(Office o in session1.Offices)
            {
                result.Add(o.Title);
            }
            return result;
        }
    }
}
