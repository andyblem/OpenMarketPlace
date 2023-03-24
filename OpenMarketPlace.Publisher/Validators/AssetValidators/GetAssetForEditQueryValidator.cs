using FluentValidation;
using OpenMarketPlace.Publisher.CQRS.AssetCQRS.Queries;

namespace OpenMarketPlace.Publisher.Validators.AssetValidators
{
    public class GetAssetForEditQueryValidator : AbstractValidator<GetAssetForEditQuery>
    {
        public GetAssetForEditQueryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
        }
    }
}
