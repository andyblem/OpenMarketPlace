using FluentValidation;
using Stride3dMarketplace.Publisher.CQRS.PublisherCQRS.Queries;

namespace Stride3dMarketplace.Publisher.Validators.PublisherValidators
{
    public class GetUserPublisherIdQueryValidator : AbstractValidator<GetUserPublisherIdQuery>
    {
        public GetUserPublisherIdQueryValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}
