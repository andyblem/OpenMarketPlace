using FluentValidation;
using Stride3dMarketplace.Publisher.CQRS.AssetCQRS.Queries;

namespace Stride3dMarketplace.Publisher.Validators.AssetValidators
{
    public class GetAssetForEditQueryValidator : AbstractValidator<GetAssetForEditQuery>
    {
        public GetAssetForEditQueryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
        }
    }
}
