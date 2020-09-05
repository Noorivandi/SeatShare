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
    public class ShortLinkValidator : AzValidator<ShortLink>
        {
            public ShortLinkValidator()
            {
    RuleSet(Mode.Any,true, () =>{
    SecurityRuleFor().Allowed(AllFields());
    
    RuleFor(p => p.OrginalLink).NotNull().Length(1,1000);
    RuleFor(p => p.Title).Length(0,50);
    RuleFor(p => p.Code).NotNull().Length(1,50);
    RuleFor(p => p.CreateDate).NotEmpty().NotNull();
            
    });
    setBusinessRules();
            }
    		 private void setBusinessRules()
            {
                RuleSet(Mode.OnInsert | Mode.OnDelete | Mode.OnUpdate, () =>
                  {
                      SecurityRuleFor().OperationRequired("ShrtLnk.A");
                  });
            }
    	
        }
    
}
