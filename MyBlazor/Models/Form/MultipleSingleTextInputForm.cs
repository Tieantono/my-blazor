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

        public List<SingleTextInputForm> SecondarySingleForms { get; set; }
    }

    public class MultipleSingleTextInputFormValidator : AbstractValidator<MultipleSingleTextInputForm>
    {
        public MultipleSingleTextInputFormValidator()
        {
            RuleForEach(Q => Q.SingleForms).SetValidator(new SingleTextInputFormValidator());

            RuleForEach(Q => Q.SecondarySingleForms).SetValidator(new SingleTextInputFormValidator());
        }
    }
}
