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
    public class KeyValueValidator : AzValidator<KeyValue>
        {
            public KeyValueValidator()
            {
    RuleSet(Mode.Any,true, () =>{
    SecurityRuleFor().Allowed(AllFields());
    
    RuleFor(p => p.SetKey).NotNull().Length(1,50);
    RuleFor(p => p.Path).Length(0,1000);
    RuleFor(p => p.Key).NotNull().Length(1,50);
    RuleFor(p => p.Type).LessThanOrEqual(Byte.MaxValue).GreaterThanOrEqual(Byte.MinValue).NotEmpty();
            
    });
    setBusinessRules();
            }
    		 private void setBusinessRules()
            {
                RuleSet(Mode.OnInsert | Mode.OnDelete | Mode.OnUpdate, () =>
                  {
                      SecurityRuleFor().OperationRequired("KyVl.A");
                  });
            }
    	
        }
    
}
