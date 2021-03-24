using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService

    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(User color)
        {
            _userDal.Delete(color);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<User> Get(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Id == id));
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
