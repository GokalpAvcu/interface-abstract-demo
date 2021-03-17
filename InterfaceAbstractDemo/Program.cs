using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1999,2,27), FirstName = "Gökalp" , LastName = "Avcu", NationalityId = "20838784512"});
        }

    }
}
