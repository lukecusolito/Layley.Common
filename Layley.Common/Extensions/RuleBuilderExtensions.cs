using FluentValidation;

namespace Layley.Common.Extensions
{
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength = 7) =>
            ruleBuilder
                .NotEmpty()
                .MinimumLength(minimumLength)
                .Matches("[A-Z]").WithMessage("'{PropertyName}' must contain at least 1 uppercase letter.")
                .Matches("[a-z]").WithMessage("'{PropertyName}' must contain at least 1 lowercase letter.")
                .Matches("[0-9]").WithMessage("'{PropertyName}' must contain at least 1 number.")
                .Matches("[^a-zA-Z0-9]").WithMessage("'{PropertyName}' must contain at least 1 special character.");
    }
}
