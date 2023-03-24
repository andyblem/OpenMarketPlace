using FluentValidation;
using OpenMarketPlace.Publisher.CQRS.AssetCQRS.Commands;

namespace OpenMarketPlace.Publisher.Validators.AssetValidators
{
    public class CreateAssetCommandValidator : AbstractValidator<CreateAssetCommand>
    {
        public CreateAssetCommandValidator()
        {
            RuleFor(x => x.Asset.Name).NotEmpty().NotNull();
            RuleFor(x => x.Asset.PublisherId).GreaterThan(0);
            RuleFor(x => x.Asset.CreatedById).NotEmpty().NotNull();
            RuleFor(x => x.Asset.PublisherId).GreaterThan(0);
            RuleFor(x => x.Asset.Version).NotEmpty().NotNull(); 
        }
    }
}
