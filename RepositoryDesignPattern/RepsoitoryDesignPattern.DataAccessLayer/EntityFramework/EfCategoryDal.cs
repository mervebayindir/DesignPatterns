using RepositoryDesignPattern.EntityLayer.Concrete;
using RepsoitoryDesignPattern.DataAccessLayer.Abstract;
using RepsoitoryDesignPattern.DataAccessLayer.Concrete;
using RepsoitoryDesignPattern.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepsoitoryDesignPattern.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {

        }
    }
}
