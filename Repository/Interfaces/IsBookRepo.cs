using apiSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IsBookRepo : IGenericRepo<sBooks>
    {
        Task<bool> isExist(sBooks book);
    }
}
