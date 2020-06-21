using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazor.Models.Form
{
    public class NestedTextInputForm
    {
        public string MyText { get; set; }
    }

    public class NestedTextInputFormValidator : AbstractValidator<NestedTextInputForm>
    {
        public NestedTextInputFormValidator()
        {
            RuleFor(Q => Q.MyText)
                .NotEmpty();
        }
    }
}
