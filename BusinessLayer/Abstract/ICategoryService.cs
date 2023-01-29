using EntityLayer.Concrete; //entityLayer.Conrete kullanmamız için ilgili referansı önceden dahil edilmiş olması gerekiyor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {
        
    }
}
