using FluentValidation;
using OpenMarketPlace.Publisher.CQRS.AssetCQRS.Commands;

namespace OpenMarketPlace.Publisher.Validators.AssetValidators
{
    public class UpdateAssetDescriptionDetailsValidator : AbstractValidator<UpdateAssetDescriptionDetailsCommand>
    {
        public UpdateAssetDescriptionDetailsValidator()
        {
            RuleFor(x => x.AssetDescriptionDetails.Name).NotEmpty().NotNull();
            RuleFor(x => x.AssetDescriptionDetails.AssetCategoryId).NotEmpty().NotNull();

            // make sure description is long enough
            When(x => x.AssetDescriptionDetails.Description.Length > 0, () =>
            {
                RuleFor(x => x.AssetDescriptionDetails.Description).MinimumLength(1000);
            });
        }
    }
}
