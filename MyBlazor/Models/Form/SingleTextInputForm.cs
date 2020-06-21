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

        public List<NestedTextInputForm> NestedForms { get; set; } = new List<NestedTextInputForm>();
    }

    public class SingleTextInputFormValidator : AbstractValidator<SingleTextInputForm>
    {
        public SingleTextInputFormValidator(IValidator<NestedTextInputForm> nestedFormValidator)
        {
            RuleFor(Q => Q.Name)
                .NotEmpty();

            RuleForEach(Q => Q.NestedForms).SetValidator(nestedFormValidator);
        }
    }
}
