﻿using Core.DataAccess;
using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerDao:IEntityRepository<CustomerDto>
    {
        //veri tabanı için sorguları yazdığım alan
    }
}