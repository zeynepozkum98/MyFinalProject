using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {

       //List<Customer> GetAll();

       // void Add(Customer customer);
       // void Update(Customer customer);
       // void Delete(Customer customer);

       // List<Customer> GetByProductId(int productId);
    }
}
