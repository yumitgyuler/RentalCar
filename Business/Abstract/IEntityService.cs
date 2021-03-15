using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEntityService<T> where T:class,IEntity,new()
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T car);
        void Update(T car);
        void Delete(T car);
    }
}
