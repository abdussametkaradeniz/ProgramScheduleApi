using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICustomerService
    {
        //apiden expression gönderme durumunu yapmamam gerekli servis tarafında saf operasyonlar yapmalıyız
        IDataResult<CustomerDto> GetById(int CustomerId);
        IDataResult<List<CustomerDto>> getList();
        IDataResult<List<CustomerDto>> getListByName(string CustomerName);
        IDataResult<List<CustomerDto>> getListBySurname(string CustomerSurname);
        IDataResult<List<CustomerDto>> getListByEmail(string CustomerEmail);
        IDataResult<List<CustomerDto>> getListByRegistryDate(DateTime CustomerRegistryDate);
        IResult Add(CustomerDto customer);
        IResult Delete(CustomerDto customer);
        IResult Update(CustomerDto customer);

    }
}
