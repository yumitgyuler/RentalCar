using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> Get(int id);
        IDataResult<List<Rental>> GetAll();
        IResult Add(Rental color);
        IResult Update(Rental color);
        IResult Delete(Rental color);
    }
}
