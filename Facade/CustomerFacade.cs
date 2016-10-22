using Facade.Repository;
using Facade.Service;

namespace Facade
{
    public class CustomerFacade
    {
        public void AddCustomer()
        {
            var customerRepository = new CustomerRepository();
            customerRepository.AddCustomerToDB();

            var emailSvc = new EmailService();
            emailSvc.SendEmail("customer@email.com");
        }
    }
}