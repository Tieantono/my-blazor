using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazor.Models.Form
{
    public class SingleTextInputForm
    {
        public string Name { get; set; }
    }

    public class SingleTextInputFormValidator : AbstractValidator<SingleTextInputForm>
    {
        public SingleTextInputFormValidator()
        {
            RuleFor(Q => Q.Name)
                .NotEmpty();
        }
    }
}
