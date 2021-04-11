using FluentValidation;

namespace DigitalAssetManager.Api.Features
{
    public class DigitalAssetValidator : AbstractValidator<DigitalAssetDto> {
        public DigitalAssetValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
        }
    }
}
