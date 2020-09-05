//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using SeatDomain.Models;
using Exir.Framework.Common;
using FluentValidation;
using Exir.Framework.Security.DataSecurity.Support;
using Exir.Framework.Security.ObjectValidation.Support;


namespace SeatDomain.Validations
{
    public class FeedBackValidator : AzValidator<FeedBack>
        {
            public FeedBackValidator()
            {
    RuleSet(Mode.Any,true, () =>{
    SecurityRuleFor().Allowed(AllFields());
    
    RuleFor(p => p.UserName).NotNull().Length(1,50);
    RuleFor(p => p.CreateDate).NotEmpty().NotNull();
    RuleFor(p => p.Description).NotNull().Length(1,1000);
    RuleFor(p => p.LinkAddresss).NotNull().Length(1,500);
    RuleFor(p => p.Mobile).Length(0,13);
    RuleFor(p => p.Email).Length(0,100);
    RuleFor(p => p.Response).Length(0,500);
            
    });
    setBusinessRules();
            }
    		 private void setBusinessRules()
            {
                RuleSet(Mode.OnInsert | Mode.OnDelete | Mode.OnUpdate, () =>
                  {
                      SecurityRuleFor().OperationRequired("FdBck.A");
                  });
            }
    	
        }
    
}
