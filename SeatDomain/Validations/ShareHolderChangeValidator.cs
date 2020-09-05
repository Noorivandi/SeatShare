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
    public class ShareHolderChangeValidator : AzValidator<ShareHolderChange>
        {
            public ShareHolderChangeValidator()
            {
    RuleSet(Mode.Any,true, () =>{
    SecurityRuleFor().Allowed(AllFields());
    
    RuleFor(p => p.InstrumentID).NotNull().Length(1,12);
    RuleFor(p => p.Arrow).Length(0,1);
    RuleFor(p => p.Name).NotNull().Length(1,50);
    RuleFor(p => p.DateTime).NotEmpty().NotNull();
            
    });
    //setBusinessRules();
            }
    
    	private void setBusinessRules()
    		{
    			RuleSet(Mode.OnInsert, () =>
    			{
    				SecurityRuleFor().OperationRequired("ShrHldrChng.C");
    			});
    
    			RuleSet(Mode.OnBatchRead | Mode.OnSingleRead, () =>
    			{
    				SecurityRuleFor().OperationRequired("ShrHldrChng.R");
    			});
    
    			RuleSet(Mode.OnUpdate, () =>
    			{
    				SecurityRuleFor().OperationRequired("ShrHldrChng.U");
    			});
    
    			RuleSet(Mode.OnDelete, () =>
    			{
    				SecurityRuleFor().OperationRequired("ShrHldrChng.D");
    			});
    		}
        }
    
}
