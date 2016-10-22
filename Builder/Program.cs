using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Builder directly
            var contractBuilder = new ContractBuilder();
            var contract = contractBuilder.WithStartDate(DateTime.Now)
                                          .WithEndDate(DateTime.Now.AddDays(10))
                                          .WithCode(10)
                                          .WithIdentification("0001")
                                          .GetContract();

            Console.WriteLine(contract.Identification);
            

            //Alternatively, you can use a Director, to abstract the details
            var contractBuilderDirector = new ContractBuilderDirector();
            var contract2 = contractBuilderDirector.Construct();

            Console.WriteLine(contract.Identification);


            Console.ReadKey();
        }
    }
}