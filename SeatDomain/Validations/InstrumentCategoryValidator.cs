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
    public class InstrumentCategoryValidator : AzValidator<InstrumentCategory>
        {
            public InstrumentCategoryValidator()
            {
    RuleSet(Mode.Any,true, () =>{
    SecurityRuleFor().Allowed(AllFields());
    
    RuleFor(p => p.Name).NotNull().Length(1,200);
    RuleFor(p => p.CSecVal).NotNull().Length(1,2);
            
    });
    //setBusinessRules();
            }
    
    	private void setBusinessRules()
    		{
    			RuleSet(Mode.OnInsert, () =>
    			{
    				SecurityRuleFor().OperationRequired("InstrmntCtgry.C");
    			});
    
    			RuleSet(Mode.OnBatchRead | Mode.OnSingleRead, () =>
    			{
    				SecurityRuleFor().OperationRequired("InstrmntCtgry.R");
    			});
    
    			RuleSet(Mode.OnUpdate, () =>
    			{
    				SecurityRuleFor().OperationRequired("InstrmntCtgry.U");
    			});
    
    			RuleSet(Mode.OnDelete, () =>
    			{
    				SecurityRuleFor().OperationRequired("InstrmntCtgry.D");
    			});
    		}
        }
    
}
