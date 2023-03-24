using FluentValidation;
using OpenMarketPlace.Publisher.CQRS.PublisherCQRS.Queries;

namespace OpenMarketPlace.Publisher.Validators.PublisherValidators
{
    public class GetUserPublisherIdQueryValidator : AbstractValidator<GetUserPublisherIdQuery>
    {
        public GetUserPublisherIdQueryValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}
