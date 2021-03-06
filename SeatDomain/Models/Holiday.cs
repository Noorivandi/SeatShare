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
            public interface IHoliday{
    
     int Id{
      get;
      set;
      }
    
     System.DateTime Date{
      get;
      set;
      }
    
     short HolidayType{
      get;
      set;
      }
    
     string HolidayTitle{
      get;
      set;
      }
    
     System.DateTime Audit_CreateDate{
      get;
      set;
      }
    
     string Audit_CreatorUserName{
      get;
      set;
      }
    
     string Audit_CreatorIP{
      get;
      set;
      }
    
     System.DateTime Audit_LastModifyDate{
      get;
      set;
      }
    
     string Audit_LastModifierUserName{
      get;
      set;
      }
    
     string Audit_LastModifierIP{
      get;
      set;
      }
    
    }// interface
    
    [Table("Holidays")]
    [Serializer(typeof(ProtobufSerializer))]
    [ProtoContract]
    [Exir.Framework.Common.Caching.CacheableKey( new string[]{nameof(Id)} )]
    [Entity]
    [Serializable]
    [DataContract(IsReference = true)]
    public partial class Holiday:IEntityBase, IHoliday,IObjectWithChangeTracker, INotifyPropertyChanged, ICloneable
    {
        #region Primitive Properties
    [Key]
    [Required]
    	[ProtoMember(1)]
        [DataMember]
        public virtual int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && !Typing.IsEquals(_id,Typing.GetDefaultValue(typeof(int))))
                    {
                        throw new InvalidOperationException("The property 'Id' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        protected int _id;
    [Required]
    	[ProtoMember(2)]
        [DataMember]
        public virtual System.DateTime Date
        {
            get { return _date; }
            set
            {
                if (_date != value)
                {
                    ChangeTracker.RecordOriginalValue("Date", _date);
                        if (!ChangeTracker.OriginalValues.ContainsKey("Date"))
                            ChangeTracker.RecordOriginalValue("Date", _date);
                            
                    _date = value;
                    OnPropertyChanged("Date");
                }
            }
        }
        protected System.DateTime _date;
    [Required]
    	[ProtoMember(3)]
        [DataMember]
        public virtual short HolidayType
        {
            get { return _holidayType; }
            set
            {
                if (_holidayType != value)
                {
                    ChangeTracker.RecordOriginalValue("HolidayType", _holidayType);
                        if (!ChangeTracker.OriginalValues.ContainsKey("HolidayType"))
                            ChangeTracker.RecordOriginalValue("HolidayType", _holidayType);
                            
                    _holidayType = value;
                    OnPropertyChanged("HolidayType");
                }
            }
        }
        protected short _holidayType;
    [MaxLength(200)]
    [Required]
    	[ProtoMember(4)]
        [DataMember]
        public virtual string HolidayTitle
        {
            get { return _holidayTitle; }
            set
            {
                if (_holidayTitle != value)
                {
                    ChangeTracker.RecordOriginalValue("HolidayTitle", _holidayTitle);
                        if (!ChangeTracker.OriginalValues.ContainsKey("HolidayTitle"))
                            ChangeTracker.RecordOriginalValue("HolidayTitle", _holidayTitle);
                            
                    _holidayTitle = value;
                    OnPropertyChanged("HolidayTitle");
                }
            }
        }
        protected string _holidayTitle;
    [Required]
    [RestfullIgnore]
    	[ProtoMember(5)]
        [DataMember]
        public virtual System.DateTime Audit_CreateDate
        {
            get { return _audit_CreateDate; }
            set
            {
                if (_audit_CreateDate != value)
                {
                    ChangeTracker.RecordOriginalValue("Audit_CreateDate", _audit_CreateDate);
                        if (!ChangeTracker.OriginalValues.ContainsKey("Audit_CreateDate"))
                            ChangeTracker.RecordOriginalValue("Audit_CreateDate", _audit_CreateDate);
                            
                    _audit_CreateDate = value;
                    OnPropertyChanged("Audit_CreateDate");
                }
            }
        }
        protected System.DateTime _audit_CreateDate;
    [MaxLength(50)]
    [Required]
    [RestfullIgnore]
    	[ProtoMember(6)]
        [DataMember]
        public virtual string Audit_CreatorUserName
        {
            get { return _audit_CreatorUserName; }
            set
            {
                if (_audit_CreatorUserName != value)
                {
                    ChangeTracker.RecordOriginalValue("Audit_CreatorUserName", _audit_CreatorUserName);
                        if (!ChangeTracker.OriginalValues.ContainsKey("Audit_CreatorUserName"))
                            ChangeTracker.RecordOriginalValue("Audit_CreatorUserName", _audit_CreatorUserName);
                            
                    _audit_CreatorUserName = value;
                    OnPropertyChanged("Audit_CreatorUserName");
                }
            }
        }
        protected string _audit_CreatorUserName;
    [MaxLength(50)]
    [Required]
    [RestfullIgnore]
    	[ProtoMember(7)]
        [DataMember]
        public virtual string Audit_CreatorIP
        {
            get { return _audit_CreatorIP; }
            set
            {
                if (_audit_CreatorIP != value)
                {
                    ChangeTracker.RecordOriginalValue("Audit_CreatorIP", _audit_CreatorIP);
                        if (!ChangeTracker.OriginalValues.ContainsKey("Audit_CreatorIP"))
                            ChangeTracker.RecordOriginalValue("Audit_CreatorIP", _audit_CreatorIP);
                            
                    _audit_CreatorIP = value;
                    OnPropertyChanged("Audit_CreatorIP");
                }
            }
        }
        protected string _audit_CreatorIP;
    [Required]
    [RestfullIgnore]
    	[ProtoMember(8)]
        [DataMember]
        public virtual System.DateTime Audit_LastModifyDate
        {
            get { return _audit_LastModifyDate; }
            set
            {
                if (_audit_LastModifyDate != value)
                {
                    ChangeTracker.RecordOriginalValue("Audit_LastModifyDate", _audit_LastModifyDate);
                        if (!ChangeTracker.OriginalValues.ContainsKey("Audit_LastModifyDate"))
                            ChangeTracker.RecordOriginalValue("Audit_LastModifyDate", _audit_LastModifyDate);
                            
                    _audit_LastModifyDate = value;
                    OnPropertyChanged("Audit_LastModifyDate");
                }
            }
        }
        protected System.DateTime _audit_LastModifyDate;
    [MaxLength(50)]
    [Required]
    [RestfullIgnore]
    	[ProtoMember(9)]
        [DataMember]
        public virtual string Audit_LastModifierUserName
        {
            get { return _audit_LastModifierUserName; }
            set
            {
                if (_audit_LastModifierUserName != value)
                {
                    ChangeTracker.RecordOriginalValue("Audit_LastModifierUserName", _audit_LastModifierUserName);
                        if (!ChangeTracker.OriginalValues.ContainsKey("Audit_LastModifierUserName"))
                            ChangeTracker.RecordOriginalValue("Audit_LastModifierUserName", _audit_LastModifierUserName);
                            
                    _audit_LastModifierUserName = value;
                    OnPropertyChanged("Audit_LastModifierUserName");
                }
            }
        }
        protected string _audit_LastModifierUserName;
    [MaxLength(50)]
    [Required]
    [RestfullIgnore]
    	[ProtoMember(10)]
        [DataMember]
        public virtual string Audit_LastModifierIP
        {
            get { return _audit_LastModifierIP; }
            set
            {
                if (_audit_LastModifierIP != value)
                {
                    ChangeTracker.RecordOriginalValue("Audit_LastModifierIP", _audit_LastModifierIP);
                        if (!ChangeTracker.OriginalValues.ContainsKey("Audit_LastModifierIP"))
                            ChangeTracker.RecordOriginalValue("Audit_LastModifierIP", _audit_LastModifierIP);
                            
                    _audit_LastModifierIP = value;
                    OnPropertyChanged("Audit_LastModifierIP");
                }
            }
        }
        protected string _audit_LastModifierIP;

        #endregion

    
    		public virtual object Clone(){
    			return Clone(new Dictionary<object,object>(),true);
    		}
    
    public   virtual object Clone(Dictionary<object,object> clonedObjects,bool includePrimaryKey)
    {
        Holiday cloned = new Holiday();
                clonedObjects.Add(this, cloned);
        				if(includePrimaryKey)
    				     cloned._id=this._id;
             cloned._date=this._date;
             cloned._holidayType=this._holidayType;
             cloned._holidayTitle=this._holidayTitle;
             cloned._audit_CreateDate=this._audit_CreateDate;
             cloned._audit_CreatorUserName=this._audit_CreatorUserName;
             cloned._audit_CreatorIP=this._audit_CreatorIP;
             cloned._audit_LastModifyDate=this._audit_LastModifyDate;
             cloned._audit_LastModifierUserName=this._audit_LastModifierUserName;
             cloned._audit_LastModifierIP=this._audit_LastModifierIP;
            
    
        return cloned;
    }
    
    
    public virtual long ComputeHashCode()
    	{
    		var sb = new System.Text.StringBuilder();
    
    						sb.Append(this._id.ToString());
    					// Id
    			sb.Append("`");
    
    						sb.Append(this._date.ToString());
    					// Date
    			sb.Append("`");
    
    						sb.Append(this._holidayType.ToString());
    					// HolidayType
    			sb.Append("`");
    
    						sb.Append(this._holidayTitle.ToString());
    					// HolidayTitle
    			sb.Append("`");
    
    						sb.Append(this._audit_CreateDate.ToString());
    					// Audit_CreateDate
    			sb.Append("`");
    
    						sb.Append(this._audit_CreatorUserName.ToString());
    					// Audit_CreatorUserName
    			sb.Append("`");
    
    						sb.Append(this._audit_CreatorIP.ToString());
    					// Audit_CreatorIP
    			sb.Append("`");
    
    						sb.Append(this._audit_LastModifyDate.ToString());
    					// Audit_LastModifyDate
    			sb.Append("`");
    
    						sb.Append(this._audit_LastModifierUserName.ToString());
    					// Audit_LastModifierUserName
    			sb.Append("`");
    
    						sb.Append(this._audit_LastModifierIP.ToString());
    					// Audit_LastModifierIP
    			sb.Append("`");
    
    		
    		return sb.ToString().ToLower().FarmhashCode64();
    }
            public virtual T CreateService<T>() 
    				 where T : IService
    		         {
                if (ObjectRegistry.ContainsObject("MMP-ServiceFactory"))
                {
                    var service_factory = (IServiceFactory)ObjectRegistry.GetObject("MMP-ServiceFactory",true);
                    return (T)service_factory.CreateByModel<Holiday>();
                }
                else
                   {
    					return (T)StaticServiceFactory.CreateByModel<Holiday>();			   
    				}
            }
    	protected const int LAST_PROTOBUF_MEMBER_INDEX=11;
    
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
    
        Holiday casted_other = other as Holiday;
    
    	if(casted_other==null) {
    		checked_objects.Remove(this);
    		return false;
    	}
    
             if(!Typing.IsEquals(this.Id,casted_other.Id))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.Date,casted_other.Date))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.HolidayType,casted_other.HolidayType))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.HolidayTitle,casted_other.HolidayTitle))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.Audit_CreateDate,casted_other.Audit_CreateDate))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.Audit_CreatorUserName,casted_other.Audit_CreatorUserName))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.Audit_CreatorIP,casted_other.Audit_CreatorIP))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.Audit_LastModifyDate,casted_other.Audit_LastModifyDate))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.Audit_LastModifierUserName,casted_other.Audit_LastModifierUserName))
    {
    		checked_objects.Remove(this);
    		return false;
    	}         if(!Typing.IsEquals(this.Audit_LastModifierIP,casted_other.Audit_LastModifierIP))
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
          yield return new BaseField{Name= "Id", Kind = FieldKinds.Primitive,PropertyType =typeof(int),
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
            yield return new BaseField{Name= "Id", Kind = FieldKinds.PrimaryKey,PropertyType =typeof(int) ,Nullable=false,TargetType =null,
    	IsIdentity=true
        
         };
              yield return new BaseField{Name= "Date", Kind = FieldKinds.Primitive,PropertyType =typeof(System.DateTime) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        
         };
              yield return new BaseField{Name= "HolidayType", Kind = FieldKinds.Primitive,PropertyType =typeof(short) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        
         };
              yield return new BaseField{Name= "HolidayTitle", Kind = FieldKinds.Primitive,PropertyType =typeof(string) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        ,Size=200
    	,Unicode=true
    	,FixedLength=false
    	,DefaultValue=""
        
         };
              yield return new BaseField{Name= "Audit_CreateDate", Kind = FieldKinds.Primitive,PropertyType =typeof(System.DateTime) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        
         };
              yield return new BaseField{Name= "Audit_CreatorUserName", Kind = FieldKinds.Primitive,PropertyType =typeof(string) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        ,Size=50
    	,Unicode=false
    	,FixedLength=false
    	,DefaultValue=""
        
         };
              yield return new BaseField{Name= "Audit_CreatorIP", Kind = FieldKinds.Primitive,PropertyType =typeof(string) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        ,Size=50
    	,Unicode=false
    	,FixedLength=false
    	,DefaultValue=""
        
         };
              yield return new BaseField{Name= "Audit_LastModifyDate", Kind = FieldKinds.Primitive,PropertyType =typeof(System.DateTime) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        
         };
              yield return new BaseField{Name= "Audit_LastModifierUserName", Kind = FieldKinds.Primitive,PropertyType =typeof(string) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        ,Size=50
    	,Unicode=false
    	,FixedLength=false
    	,DefaultValue=""
        
         };
              yield return new BaseField{Name= "Audit_LastModifierIP", Kind = FieldKinds.Primitive,PropertyType =typeof(string) ,Nullable=false,TargetType =null,
    	IsIdentity=null
        ,Size=50
    	,Unicode=false
    	,FixedLength=false
    	,DefaultValue=""
        
         };
          	
        }
    
    
    
    private static IEnumerable<IField> GetNavigationFields()
    {
                return Enumerable.Empty<IField>();
                 
    }
    
    public virtual Expression GetPrimaryKeyPrediacate()
    {
        var vId=(int)this.GetValue("Id");
        Expression<Func<Holiday,bool>> exp = p => p.Id == vId ;
        return exp;        
    
    }
    
    public virtual object GetValue(string propertyName)
    {
        object retVal = null;
        switch(propertyName.ToLower())
        {
            case "id":
                retVal = this.Id;
                break;
            case "date":
                retVal = this.Date;
                break;
            case "holidaytype":
                retVal = this.HolidayType;
                break;
            case "holidaytitle":
                retVal = this.HolidayTitle;
                break;
            case "audit_createdate":
                retVal = this.Audit_CreateDate;
                break;
            case "audit_creatorusername":
                retVal = this.Audit_CreatorUserName;
                break;
            case "audit_creatorip":
                retVal = this.Audit_CreatorIP;
                break;
            case "audit_lastmodifydate":
                retVal = this.Audit_LastModifyDate;
                break;
            case "audit_lastmodifierusername":
                retVal = this.Audit_LastModifierUserName;
                break;
            case "audit_lastmodifierip":
                retVal = this.Audit_LastModifierIP;
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
    			
    			return _id!=default(int);
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
            case "id":
                this.Id =(int)value;
            break;
            case "date":
                this.Date =(System.DateTime)value;
            break;
            case "holidaytype":
                this.HolidayType =(short)value;
            break;
            case "holidaytitle":
                this.HolidayTitle =(string)value;
            break;
            case "audit_createdate":
                this.Audit_CreateDate =(System.DateTime)value;
            break;
            case "audit_creatorusername":
                this.Audit_CreatorUserName =(string)value;
            break;
            case "audit_creatorip":
                this.Audit_CreatorIP =(string)value;
            break;
            case "audit_lastmodifydate":
                this.Audit_LastModifyDate =(System.DateTime)value;
            break;
            case "audit_lastmodifierusername":
                this.Audit_LastModifierUserName =(string)value;
            break;
            case "audit_lastmodifierip":
                this.Audit_LastModifierIP =(string)value;
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
