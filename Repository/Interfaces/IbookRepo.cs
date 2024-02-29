using apiSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IbookRepo : IGenericRepo<book>
    {
        //Task<bool> isthere(book book);
    }
}
