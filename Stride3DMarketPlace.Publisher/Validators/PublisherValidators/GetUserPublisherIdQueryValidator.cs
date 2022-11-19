using FluentValidation;
using Stride3DMarketPlace.Seller.CQRS.PublisherCQRS.Queries;

namespace Stride3DMarketPlace.Seller.Validators.PublisherValidators
{
    public class GetUserPublisherIdQueryValidator : AbstractValidator<GetUserPublisherIdQuery>
    {
        public GetUserPublisherIdQueryValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}
