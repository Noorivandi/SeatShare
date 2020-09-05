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
    public class HistoryValidator : AzValidator<History>
        {
            public HistoryValidator()
            {
    RuleSet(Mode.Any,true, () =>{
    SecurityRuleFor().Allowed(AllFields());
    
    RuleFor(p => p.Date).NotEmpty().NotNull();
            
    });
    //setBusinessRules();
            }
    
    	private void setBusinessRules()
    		{
    			RuleSet(Mode.OnInsert, () =>
    			{
    				SecurityRuleFor().OperationRequired("Hstry.C");
    			});
    
    			RuleSet(Mode.OnBatchRead | Mode.OnSingleRead, () =>
    			{
    				SecurityRuleFor().OperationRequired("Hstry.R");
    			});
    
    			RuleSet(Mode.OnUpdate, () =>
    			{
    				SecurityRuleFor().OperationRequired("Hstry.U");
    			});
    
    			RuleSet(Mode.OnDelete, () =>
    			{
    				SecurityRuleFor().OperationRequired("Hstry.D");
    			});
    		}
        }
    
}