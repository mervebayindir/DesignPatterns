﻿using DesignPattern.ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover(Employee SuperVisor)
        {
            NextApprover = SuperVisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
