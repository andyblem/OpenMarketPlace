using FluentValidation;
using Stride3DMarketPlace.Seller.CQRS.AssetCQRS.Queries;

namespace Stride3DMarketPlace.Seller.Validators.AssetValidators
{
    public class GetAssetForEditQueryValidator : AbstractValidator<GetAssetForEditQuery>
    {
        public GetAssetForEditQueryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
        }
    }
}
