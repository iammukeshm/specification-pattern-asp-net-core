using Core.Entities;

namespace Core.Specification
{
    public class DeveloperByIncomeSpecification : BaseSpecifcation<Developer>
    {
        public DeveloperByIncomeSpecification()
        {
            AddOrderByDescending(x => x.EstimatedIncome);
        }
    }
}