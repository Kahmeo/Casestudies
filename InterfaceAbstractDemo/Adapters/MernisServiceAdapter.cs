using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(
                Convert.ToInt64(customer.NationalityId), customer.FirsName.ToUpper(), customer.LastName.ToUpper(), 
                customer.DateOfBirth.Year);
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
