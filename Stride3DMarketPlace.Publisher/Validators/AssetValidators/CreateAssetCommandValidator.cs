using FluentValidation;
using Stride3DMarketPlace.Seller.CQRS.AssetCQRS.Commands;

namespace Stride3DMarketPlace.Seller.Validators.AssetValidators
{
    public class CreateAssetCommandValidator : AbstractValidator<CreateAssetCommand>
    {
        public CreateAssetCommandValidator()
        {
            RuleFor(x => x.Asset.Name).NotEmpty().NotNull();
            RuleFor(x => x.Asset.PublisherId).GreaterThan(0);
            RuleFor(x => x.Asset.CreatedById).NotEmpty().NotNull();
            RuleFor(x => x.Asset.PublisherId).GreaterThan(0);
        }
    }
}
