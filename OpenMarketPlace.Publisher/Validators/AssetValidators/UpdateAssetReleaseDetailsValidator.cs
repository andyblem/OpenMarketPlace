using FluentValidation;
using OpenMarketPlace.Publisher.CQRS.AssetCQRS.Commands;

namespace OpenMarketPlace.Publisher.Validators.AssetValidators
{
    public class UpdateAssetReleaseDetailsValidator : AbstractValidator<UpdateAssetReleaseDetailsCommand>
    {
        public UpdateAssetReleaseDetailsValidator()
        {
            RuleFor(x => x.AssetReleaseDetails.EngineCompatibility).NotEmpty().NotNull();
            RuleFor(x => x.AssetReleaseDetails.License).NotEmpty().NotNull();
            RuleFor(x => x.AssetReleaseDetails.Version).NotEmpty().NotNull();

            // make sure Release is long enough
            When(x => x.AssetReleaseDetails.ReleaseNotes.Length > 0, () =>
            {
                RuleFor(x => x.AssetReleaseDetails.ReleaseNotes).MinimumLength(1000);
            });
        }
    }
}
