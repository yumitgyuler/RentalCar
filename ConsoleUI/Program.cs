using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            //Customer test = new Customer();


            //IUserService user = new UserManager(new EFUserDal());

            //var addUser = new User { FirstName = "Yumit", LastName = "Gyuler", Email = "yumit@yumit.se", Password ="12346679" };
            //user.Add(addUser);
            ICustomerService customer = new CustomerManager(new EFCustomerDal());

            var addCustomer = new Customer { UserId = 1, CompanyName = "Ps Creative" };
            customer.Add(addCustomer);

        }
    }
}
