﻿using KursivProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursivProject.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
