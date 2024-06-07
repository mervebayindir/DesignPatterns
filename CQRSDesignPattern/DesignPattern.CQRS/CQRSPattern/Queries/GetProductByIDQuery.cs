using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIDQuery
    {
        public int Id { get; set; }

        public GetProductByIDQuery(int id)
        {
            Id = id;
        }
    }
}
