﻿using FluentValidation;

namespace KatlaSport.Services.HiveManagement
{
    public class UpdateHiveSectionRequestValidator : AbstractValidator<UpdateHiveSectionRequest>
    {
        public UpdateHiveSectionRequestValidator()
        {
            RuleFor(r => r.Name).Length(4,16);
            RuleFor(r => r.Code).Length(5);
        }
    }
}
