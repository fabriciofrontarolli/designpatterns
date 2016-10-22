using Builder.Entity;
using System;

namespace Builder
{
    public class ContractBuilderDirector
    {
        public Contract Construct()
        {
            var contractBuilder = new ContractBuilder();
            var contract = contractBuilder.WithStartDate(DateTime.Now)
                                          .WithEndDate(DateTime.Now.AddDays(10))
                                          .WithCode(10)
                                          .WithIdentification("Built with Director")
                                          .GetContract();

            return contract;
        }
    }
}
