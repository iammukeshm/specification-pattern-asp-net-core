using Core.Entities;

namespace Core.Specification
{
    public class DeveloperWithAddressSpecification : BaseSpecifcation<Developer>
    {
        public DeveloperWithAddressSpecification(int years) : base(x => x.EstimatedIncome > years)
        {
            AddInclude(x => x.Address);
        }
    }
}