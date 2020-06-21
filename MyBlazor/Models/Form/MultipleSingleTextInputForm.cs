using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazor.Models.Form
{
    public class MultipleSingleTextInputForm
    {
        public List<SingleTextInputForm> SingleForms { get; set; }

    }

    public class MultipleSingleTextInputFormValidator : AbstractValidator<MultipleSingleTextInputForm>
    {
        public MultipleSingleTextInputFormValidator(IValidator<SingleTextInputForm> singleFormValidator)
        {
            RuleForEach(Q => Q.SingleForms).SetValidator(singleFormValidator);
        }
    }
}
