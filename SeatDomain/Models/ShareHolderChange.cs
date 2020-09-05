//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using Exir.Framework.Common;
using System.Linq.Expressions;
using System.Linq;
using ProtoBuf;
using System.ComponentModel.DataAnnotations.Schema;
using Exir.Framework.Common.Serialization;
using System.ComponentModel.DataAnnotations;

namespace SeatDomain.Models
{
            public interface IShareHolderChange{
    
     long ShareHolderChangePK{
      get;
      set;
      }
    
     int HolderPK{
      get;
      set;
      }
    
     string InstrumentID{
      get;
      set;
      }
    
     long Quoantity{
      get;
      set;
      }
    
     double Percent{
      get;
      set;
      }
    
     string Arrow{
      get;
      set;
      }
    
     string Name{
      get;
      set;
      }
    
     long InsCode{
      get;
      set;
      }
    
     System.DateTime DateTime{
      get;
      set;
      }
    
    }// interface
    
    [Table("ShareHolderChanges")]
    
[Serializer(typeof(ProtobufSerializer))]
    
[ProtoContract]
    
[Exir.Framework.Common.Caching.CacheableKey( new string[]{nameof(ShareHolderChangePK)} )]
    
[Entity]
    
[Serializable]
    
[DataContract(IsReference = true)]
    
public partial class ShareHolderChange:IEntityBase, IShareHolderChange,IObjectWithChangeTracker, INotifyPropertyChanged, ICloneable
    {
        #region Primitive Properties
    [Key]
    
[Required]
    
	[ProtoMember(1)]
    
    [DataMember]
    
    public virtual long ShareHolderChangePK
        {
            get { return _shareHolderChangePK; }
            set
            {
                if (_shareHolderChangePK != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && !Typing.IsEquals(_shareHolderChangePK,Typing.GetDefaultValue(typeof(long))))
                    {
                        throw new InvalidOperationException("The property 'ShareHolderChangePK' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _shareHolderChangePK = value;
                    OnPropertyChanged("ShareHolderChangePK");
                }
            }
        }
        protected long _shareHolderChangePK;
    [Required]
    
	[ProtoMember(2)]
    
    [DataMember]
    
    public virtual int HolderPK
        {
            get { return _holderPK; }
            set
            {
                if (_holderPK != value)
                {
                    ChangeTracker.RecordOriginalValue("HolderPK", _holderPK);
                        if (!ChangeTracker.OriginalValues.ContainsKey("HolderPK"))
                            ChangeTracker.RecordOriginalValue("HolderPK", _holderPK);
                            
                    _holderPK = value;
                    OnPropertyChanged("HolderPK");
                }
            }
        }
        protected int _holderPK;
    [MaxLength(12)]
    
[Required]
    
	[ProtoMember(3)]
    
    [DataMember]
    
    public virtual string InstrumentID
        {
            get { return _instrumentID; }
            set
            {
                if (_instrumentID != value)
                {
                    ChangeTracker.RecordOriginalValue("InstrumentID", _instrumentID);
                        if (!ChangeTracker.OriginalValues.ContainsKey("InstrumentID"))
                            ChangeTracker.RecordOriginalValue("InstrumentID", _instrumentID);
                            
                    _instrumentID = value;
                    OnPropertyChanged("InstrumentID");
                }
            }
        }
        protected string _instrumentID;
    [Required]
    
	[ProtoMember(4)]
    
    [DataMember]
    
    public virtual long Quoantity
        {
            get { return _quoantity; }
            set
            {
                if (_quoantity != value)
                {
                    ChangeTracker.RecordOriginalValue("Quoantity", _quoantity);
                        if (!ChangeTracker.OriginalValues.ContainsKey("Quoantity"))
                            ChangeTracker.RecordOriginalValue("Quoantity", _quoantity);
                            
                    _quoantity = value;
                    OnPropertyChanged("Quoantity");
                }
            }
        }
        protected long _quoantity;
    [Required]
    
	[ProtoMember(5)]
    
    [DataMember]
    
    public virtual double Percent
        {
            get { return _percent; }
            set
            {
                if (_percent != value)
                {
                    ChangeTracker.RecordOriginalValue("Percent", _percent);
                        if (!ChangeTracker.OriginalValues.ContainsKey("Percent"))
                            ChangeTracker.RecordOriginalValue("Percent", _percent);
                            
                    _percent = value;
                    OnPropertyChanged("Percent");
                }
            }
        }
        protected double _percent;
    [MaxLength(1)]
    
	[ProtoMember(6)]
    
    [DataMember]
    
    public virtual string Arrow
        {
            get { return _arrow; }
            set
            {
                if (_arrow != value)
                {
                    ChangeTracker.RecordOriginalValue("Arrow", _arrow);
                        if (!ChangeTracker.OriginalValues.ContainsKey("Arrow"))
                            ChangeTracker.RecordOriginalValue("Arrow", _arrow);
                            
                    _arrow = value;
                    OnPropertyChanged("Arrow");
                }
            }
        }
        protected string _arrow;
    [MaxLength(50)]
    
[Required]
    
	[ProtoMember(7)]
    
    [DataMember]
    
    public virtual string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    ChangeTracker.RecordOriginalValue("Name", _name);
                        if (!ChangeTracker.OriginalValues.ContainsKey("Name"))
                            ChangeTracker.RecordOriginalValue("Name", _name);
                            
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        protected string _name;
    [Required]
    
	[ProtoMember(8)]
    
    [DataMember]
    
    public virtual long InsCode
        {
            get { return _insCode; }
            set
            {
                if (_insCode != value)
                {
                    ChangeTracker.RecordOriginalValue("InsCode", _insCode);
                        if (!ChangeTracker.OriginalValues.ContainsKey("InsCode"))
                            ChangeTracker.RecordOriginalValue("InsCode", _insCode);
                            
                    _insCode = value;
                    OnPropertyChanged("InsCode");
                }
            }
        }
        protected long _insCode;
    [Required]
    
	[ProtoMember(9)]
    
    [DataMember]
    
    public virtual System.DateTime DateTime
        {
            get { return _dateTime; }
            set
            {
                if (_dateTime != value)
                {
                    ChangeTracker.RecordOriginalValue("DateTime", _dateTime);
                        if (!ChangeTracker.OriginalValues.ContainsKey("DateTime"))
                            ChangeTracker.RecordOriginalValue("DateTime", _dateTime);
                            
                    _dateTime = value;
                    OnPropertyChanged("DateTime");
                }
            }
        }
        protected System.DateTime _dateTime;

        #endregion

    
    		public virtual object Clone(){
    			return Clone(new Dictionary<object,object>(),true);
    		}
    
    public   virtual object Clone(Dictionary<object,object> clonedObjects,bool includePrimaryKey)
    {
        ShareHolderChange cloned = new ShareHolderChange();
                clonedObjects.Add(this, cloned);
        				if(includePrimaryKey)
    				     cloned._shareHolderChangePK=this._shareHolderChangePK;
             cloned._holderPK=this._holderPK;
             cloned._instrumentID=this._instrumentID;
             cloned._quoantity=this._quoantity;
             cloned._percent=this._percent;
             cloned._arrow=this._arrow;
             cloned._name=this._name;
             cloned._insCode=this._insCode;
             cloned._dateTime=this._dateTime;
            
    
        return cloned;
    }
    
    
    public virtual long ComputeHashCode()
    	{
    		var sb = new System.Text.StringBuilder();
    
    						sb.Append(this._shareHolderChangePK.ToString());
    					// ShareHolderChangePK
    			sb.Append("`");
    
    						sb.Append(this._holderPK.ToString());
    					// HolderPK
    			sb.Append("`");
    
    						sb.Append(this._instrumentID.ToString());
    					// InstrumentID
    			sb.Append("`");
    
    						sb.Append(this._quoantity.ToString());
    					// Quoantity
    			sb.Append("`");
    
    						sb.Append(this._percent.ToString());
    					// Percent
    			sb.Append("`");
    
    						sb.Append(this._arrow?.ToString());
    						// Arrow
    			sb.Append("`");
    
    						sb.Append(this._name.ToString());
    					// Name
    			sb.Append("`");
    
    						sb.Append(this._insCode.ToString());
    					// InsCode
    			sb.Append("`");
    
    						sb.Append(this._dateTime.ToString());
    					// DateTime
    			sb.Append("`");
    
    		
    		return sb.ToString().ToLower().FarmhashCode64();
    }
            public virtual T CreateService<T>() 
    				 where T : IService
    		         {
                if (ObjectRegistry.ContainsObject("MMP-ServiceFactory"))
                {
                    var service_factory = (IServiceFactory)ObjectRegistry.GetObject("MMP-ServiceFactory",true);
                    return (T)service_factory.CreateByModel<ShareHolderChange>();
                }
                else
                   {
    					return (T)StaticServiceFactory.CreateByModel<ShareHolderChange>();			   
    				}
            }
    	protected const int LAST_PROTOBUF_MEMBER_INDEX=10;
    
    public virtual void ResetChanges(bool includeNavigations=false)
    {
        if(!includeNavigations){
            ChangeTracker.ResetChanges();
            return;
        }
    
        ResetChanges(new List<object>(), includeNavigations);
    }
    public virtual void ResetChanges(List<object> reseted_objects, bool includeNavigations=false)
    {
        if(reseted_objects.Contains(this)) return;
    
        ChangeTracker.ResetChanges();
         
        reseted_objects.Add(this);
    
       }
    
    public virtual bool Equals(IEntityBase obj)
        {
    		bool result= this.Equals(obj, new List<object>());
    
    	return result;
    }   
    
    public virtual bool Equals(object other,List<object> checked_objects)
    {
    	if(checked_objects.Contains(this)) return true;
    	
    	checked_objects.Add(this);
    
        ShareHolderChange casted_other = other as ShareHolderChange;
    
    	if(casted_other==null) {
    		checked_objects.Remove(this);
    		return false;
    	}
    
             if(!Typing.IsEquals(this.ShareHolderChangePK,casted_other.ShareHolderChangePK))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.HolderPK,casted_other.HolderPK))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.InstrumentID,casted_other.InstrumentID))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.Quoantity,casted_other.Quoantity))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.Percent,casted_other.Percent))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.Arrow,casted_other.Arrow))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.Name,casted_other.Name))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.InsCode,casted_other.InsCode))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.DateTime,casted_other.DateTime))
    {
    		checked_objects.Remove(this);
    		return false;
    	}    
    checked_objects.Remove(this);
    
    return true;
    }
    
        #region Metadata section
            [NotMapped]
    
        [ProtoIgnore]
    
        [Newtonsoft.Json.JsonIgnore]
    
        [Jil.JilDirective(Ignore =true)]
    
	    [System.Xml.Serialization.XmlIgnore]
    
        public virtual IEnumerable<IField> PrimaryKeys { get{ return GetPrimaryKeys(); } }
    
        public virtual IEnumerable<IField> GetFields ()
        {
                var array1 = GetPrimitiveFields();
                var array2 = GetNavigationFields();
                if(array1.Any() && array2.Any()) return array1.Union(array2);
                else if(array1.Any()) return array1;
                else if(array2.Any()) return array2;
                return null;
        }
    
        public virtual IEnumerable<IField> GetPrimaryKeys()
    {
          yield return new BaseField{Name= "ShareHolderChangePK", Kind = FieldKinds.Primitive,PropertyType =typeof(long),
    	IsIdentity=true
    	 };
    }
    
    public virtual Type GetFieldType(string propertyName)
    {
        var field = GetFields().Where(x => x.Name == propertyName).FirstOrDefault();
        return field != null ? field.PropertyType: null;
    }
    
    public virtual bool HasField(string propertyName)
    {
        var field = GetFields().Where(x => x.Name == propertyName).FirstOrDefault();
        return field != null;
    }
    
    
        private static IEnumerable<IField> GetPrimitiveFields()
        {
            yield return new BaseField{Name= "ShareHolderChangePK", Kind = FieldKinds.PrimaryKey,PropertyType =typeof(long) ,Nullable=false,TargetType =null,
    	IsIdentity=true
        
         };
              yield return new BaseField{Name= "HolderPK", Kind = FieldKinds.Primitive,PropertyType =typeof(int) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        
         };
              yield return new BaseField{Name= "InstrumentID", Kind = FieldKinds.Primitive,PropertyType =typeof(string) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        ,Size=12
    	,Unicode=false
    	,FixedLength=true
    	,DefaultValue=""
        
         };
              yield return new BaseField{Name= "Quoantity", Kind = FieldKinds.Primitive,PropertyType =typeof(long) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        
         };
              yield return new BaseField{Name= "Percent", Kind = FieldKinds.Primitive,PropertyType =typeof(double) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        
         };
              yield return new BaseField{Name= "Arrow", Kind = FieldKinds.Primitive,PropertyType =typeof(string) ,Nullable=true,TargetType =null,
    	IsIdentity=null
        ,Size=1
    	,Unicode=false
    	,FixedLength=true
    	,DefaultValue=""
        
         };
              yield return new BaseField{Name= "Name", Kind = FieldKinds.Primitive,PropertyType =typeof(string) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        ,Size=50
    	,Unicode=true
    	,FixedLength=false
    	,DefaultValue=""
        
         };
              yield return new BaseField{Name= "InsCode", Kind = FieldKinds.Primitive,PropertyType =typeof(long) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        
         };
              yield return new BaseField{Name= "DateTime", Kind = FieldKinds.Primitive,PropertyType =typeof(System.DateTime) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        
         };
          	
        }
    
    
    
    private static IEnumerable<IField> GetNavigationFields()
    {
                return Enumerable.Empty<IField>();
                 
    }
    
    public virtual Expression GetPrimaryKeyPrediacate()
    {
        var vShareHolderChangePK=(long)this.GetValue("ShareHolderChangePK");
        Expression<Func<ShareHolderChange,bool>> exp = p => p.ShareHolderChangePK == vShareHolderChangePK ;
        return exp;        
    
    }
    
    public virtual object GetValue(string propertyName)
    {
        object retVal = null;
        switch(propertyName.ToLower())
        {
            case "shareholderchangepk":
                retVal = this.ShareHolderChangePK;
                break;
            case "holderpk":
                retVal = this.HolderPK;
                break;
            case "instrumentid":
                retVal = this.InstrumentID;
                break;
            case "quoantity":
                retVal = this.Quoantity;
                break;
            case "percent":
                retVal = this.Percent;
                break;
            case "arrow":
                retVal = this.Arrow;
                break;
            case "name":
                retVal = this.Name;
                break;
            case "inscode":
                retVal = this.InsCode;
                break;
            case "datetime":
                retVal = this.DateTime;
                break;
        	
                        default:
    							retVal=null;
    			            break;
        }
        return retVal;
    }
    
    		private Dictionary<string,object> __tags;
    		public virtual void AddTag(string key, object value)
            {
                if(__tags==null)__tags=new Dictionary<string,object>();
    			if(!__tags.ContainsKey(key)) __tags.Add(key,value);
            }  
    
    		public virtual object GetTag(string key)
            {
                if(__tags==null)return null;
    			if(!__tags.ContainsKey(key))return null;
    			return __tags[key];
            }
    
            public virtual object RemoveTag(string key)
            {
                if (__tags == null) return null;
                if (__tags.ContainsKey(key)){
    			var result= __tags[key];
                    __tags.Remove(key);
    				return result;
    			}
    			return  null;
            }
            public virtual bool HasKey()
            {
    			
    			return _shareHolderChangePK!=default(long);
            }
      
     public virtual void StartTracking()
            {
    		if(ChangeTracker.ChangeTrackingEnabled) return;
    		            ChangeTracker.ChangeTrackingEnabled = true;
                        }
    
            public virtual void StopTracking()
            {
    		         ChangeTracker.ChangeTrackingEnabled = false;
                       }
    
    public virtual bool SetValue(string propertyName, object value)
    {
        switch(propertyName.ToLower())
        {
            case "shareholderchangepk":
                this.ShareHolderChangePK =(long)value;
            break;
            case "holderpk":
                this.HolderPK =(int)value;
            break;
            case "instrumentid":
                this.InstrumentID =(string)value;
            break;
            case "quoantity":
                this.Quoantity =(long)value;
            break;
            case "percent":
                this.Percent =(double)value;
            break;
            case "arrow":
                this.Arrow =(string)value;
            break;
            case "name":
                this.Name =(string)value;
            break;
            case "inscode":
                this.InsCode =(long)value;
            break;
            case "datetime":
                this.DateTime =(System.DateTime)value;
            break;
    	
                    default:
                                   return Exir.Framework.Common.Fasterflect.PropertyExtensions.TrySetPropertyValue(this, propertyName, value);
    			            break;
       }   
       return true;
    }
            
        #endregion

        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
     	[NonSerialized]
    
   private ObjectChangeTracker _changeTracker;
    	  [NotMapped]
    
        [ProtoIgnore]
    
        [Newtonsoft.Json.JsonIgnore]
    
        [Jil.JilDirective(Ignore =true)]
    
    [System.Xml.Serialization.XmlIgnore]
    
    public virtual ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                              _propertyChanged += new PropertyChangedEventHandler(delegate(object sender, PropertyChangedEventArgs e)
                        {
                        if(ChangeTracker.ChangeTrackingEnabled)
                            ChangeTracker.RecordPropertyChange(e.PropertyName);
                        });
          }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
           
    
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    	[NotMapped]
    
    protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
    
    public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
    
    public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
        }

        #endregion

    }
}
