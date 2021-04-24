using Core.Entities;

namespace Core.Specification
{
    public class DeveloperWithAddressSpecification : BaseSpecifcation<Developer>
    {
        public DeveloperWithAddressSpecification()
        {
            AddInclude(x => x.Address);
        }
    }
}
