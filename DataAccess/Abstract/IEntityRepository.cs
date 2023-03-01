using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{

    // generic constraint : where <T>  gibi durumlar icin sartlanmalar saglar
    // where: T nin alabilecegi degerleri ozellikleri tasir
    // class: class lari yazabiliriz
    // IEntity : ientity ve ientity ozelliklerini tasiyan buna bagli classlari alabilir
    // new() : newlenebilen bir nesne olmali bu durumda IEntity i disliyoruz ve soyut nesneler dislanir
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T,bool>> filter);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
