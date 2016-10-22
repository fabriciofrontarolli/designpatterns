using Builder.Entity;
using System;

namespace Builder
{
    public class ContractBuilder
    {
        private Contract Contract { get; set; }

        public ContractBuilder()
        {
            Contract = new Contract();
        }

        public ContractBuilder WithStartDate(DateTime startDate)
        {
            Contract.StartDate = startDate;
            return this;
        }

        public ContractBuilder WithEndDate(DateTime endDate)
        {
            Contract.EndDate = endDate;
            return this;
        }

        public ContractBuilder WithCode(int code)
        {
            Contract.Code = code;
            return this;
        }

        public ContractBuilder WithIdentification(string identification)
        {
            Contract.Identification = identification;
            return this;
        }

        public Contract GetContract()
        {
            return Contract;
        }
    }
}