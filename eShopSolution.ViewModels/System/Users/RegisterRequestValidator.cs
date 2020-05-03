using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirtName).NotEmpty().WithMessage("Firt name is required")
                .MaximumLength(200).WithMessage("Firt Name can not over 200 charactors");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required")
                .MaximumLength(200).WithMessage("Last name can not over 200 charactors");
            RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Birthday can not greater than 100 years");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Email format not match");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone number is required");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("user name is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("password is required")
                .MinimumLength(6).WithMessage("password is least 6 characters");
            RuleFor(x => x).Custom((request, context) => {
                if (request.Password  != request.ConfirmPassword)
                {
                    context.AddFailure("confirm password is not match");
                }
            });
        }
    }
}
