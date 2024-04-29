using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.DAL.Data.Repos.Generic
{
    public interface IGenericRepo<TEntity>
    where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity? GetById(int id);
        void Add(TEntity entity);
        
    }
}
