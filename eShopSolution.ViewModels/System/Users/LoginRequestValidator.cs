using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class LoginRequestValidator:AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("user name is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("password is required")
                .MinimumLength(6).WithMessage("password is least 6 characters");
        }
    }
}
