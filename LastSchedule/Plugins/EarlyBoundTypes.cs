//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]

namespace FixRM.LastSchedule.Plugins.Entities
{
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public enum fixrm_RecurringJobState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public enum fixrm_recurringjob_statuscode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Draft = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Published = 378280000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 2,
	}
	
	/// <summary>
	/// Record to store Recurring Job definitions
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("fixrm_recurringjob")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class fixrm_RecurringJob : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public fixrm_RecurringJob() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "fixrm_recurringjob";
		
		public const int EntityTypeCode = 10046;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Last job execution
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_lastrun")]
		public System.Nullable<System.DateTime> fixrm_LastRun
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("fixrm_lastrun");
			}
			set
			{
				this.OnPropertyChanging("fixrm_LastRun");
				this.SetAttributeValue("fixrm_lastrun", value);
				this.OnPropertyChanged("fixrm_LastRun");
			}
		}
		
		/// <summary>
		/// The name of the Recurring Job entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_name")]
		public string fixrm_Name
		{
			get
			{
				return this.GetAttributeValue<string>("fixrm_name");
			}
			set
			{
				this.OnPropertyChanging("fixrm_Name");
				this.SetAttributeValue("fixrm_name", value);
				this.OnPropertyChanged("fixrm_Name");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_nextrun")]
		public System.Nullable<System.DateTime> fixrm_NextRun
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("fixrm_nextrun");
			}
			set
			{
				this.OnPropertyChanging("fixrm_NextRun");
				this.SetAttributeValue("fixrm_nextrun", value);
				this.OnPropertyChanged("fixrm_NextRun");
			}
		}
		
		/// <summary>
		/// Unique identifier for Process associated with Recurring Job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_processid")]
		public Microsoft.Xrm.Sdk.EntityReference fixrm_ProcessId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("fixrm_processid");
			}
			set
			{
				this.OnPropertyChanging("fixrm_ProcessId");
				this.SetAttributeValue("fixrm_processid", value);
				this.OnPropertyChanged("fixrm_ProcessId");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_query")]
		public string fixrm_Query
		{
			get
			{
				return this.GetAttributeValue<string>("fixrm_query");
			}
			set
			{
				this.OnPropertyChanging("fixrm_Query");
				this.SetAttributeValue("fixrm_query", value);
				this.OnPropertyChanged("fixrm_Query");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_recurringjobid")]
		public System.Nullable<System.Guid> fixrm_RecurringJobId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("fixrm_recurringjobid");
			}
			set
			{
				this.OnPropertyChanging("fixrm_RecurringJobId");
				this.SetAttributeValue("fixrm_recurringjobid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("fixrm_RecurringJobId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_recurringjobid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.fixrm_RecurringJobId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier for Recurring Job Schedule associated with Recurring Job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_scheduleid")]
		public Microsoft.Xrm.Sdk.EntityReference fixrm_ScheduleId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("fixrm_scheduleid");
			}
			set
			{
				this.OnPropertyChanging("fixrm_ScheduleId");
				this.SetAttributeValue("fixrm_scheduleid", value);
				this.OnPropertyChanged("fixrm_ScheduleId");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Status of the Recurring Job
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobState)(System.Enum.ToObject(typeof(FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Recurring Job
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<FixRM.LastSchedule.Plugins.Entities.fixrm_recurringjob_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((FixRM.LastSchedule.Plugins.Entities.fixrm_recurringjob_statuscode)(System.Enum.ToObject(typeof(FixRM.LastSchedule.Plugins.Entities.fixrm_recurringjob_statuscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				if ((value == null))
				{
					this.SetAttributeValue("statuscode", null);
				}
				else
				{
					this.SetAttributeValue("statuscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 fixrm_recurringjobschedule_recurringjob
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_scheduleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fixrm_recurringjobschedule_recurringjob")]
		public FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobSchedule fixrm_recurringjobschedule_recurringjob
		{
			get
			{
				return this.GetRelatedEntity<FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobSchedule>("fixrm_recurringjobschedule_recurringjob", null);
			}
			set
			{
				this.OnPropertyChanging("fixrm_recurringjobschedule_recurringjob");
				this.SetRelatedEntity<FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobSchedule>("fixrm_recurringjobschedule_recurringjob", null, value);
				this.OnPropertyChanged("fixrm_recurringjobschedule_recurringjob");
			}
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public enum fixrm_RecurringJobScheduleState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public enum fixrm_recurringjobschedule_statuscode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 2,
	}
	
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("fixrm_recurringjobschedule")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class fixrm_RecurringJobSchedule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public fixrm_RecurringJobSchedule() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "fixrm_recurringjobschedule";
		
		public const int EntityTypeCode = 10060;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_interval")]
		public System.Nullable<int> fixrm_Interval
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("fixrm_interval");
			}
			set
			{
				this.OnPropertyChanging("fixrm_Interval");
				this.SetAttributeValue("fixrm_interval", value);
				this.OnPropertyChanged("fixrm_Interval");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_name")]
		public string fixrm_Name
		{
			get
			{
				return this.GetAttributeValue<string>("fixrm_name");
			}
			set
			{
				this.OnPropertyChanging("fixrm_Name");
				this.SetAttributeValue("fixrm_name", value);
				this.OnPropertyChanged("fixrm_Name");
			}
		}
		
		/// <summary>
		/// Recurrence pattern string in iCalendar format
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_pattern")]
		public string fixrm_Pattern
		{
			get
			{
				return this.GetAttributeValue<string>("fixrm_pattern");
			}
			set
			{
				this.OnPropertyChanging("fixrm_Pattern");
				this.SetAttributeValue("fixrm_pattern", value);
				this.OnPropertyChanged("fixrm_Pattern");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_patternstartdate")]
		public System.Nullable<System.DateTime> fixrm_PatternStartDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("fixrm_patternstartdate");
			}
			set
			{
				this.OnPropertyChanging("fixrm_PatternStartDate");
				this.SetAttributeValue("fixrm_patternstartdate", value);
				this.OnPropertyChanged("fixrm_PatternStartDate");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_recurringjobscheduleid")]
		public System.Nullable<System.Guid> fixrm_RecurringJobScheduleId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("fixrm_recurringjobscheduleid");
			}
			set
			{
				this.OnPropertyChanging("fixrm_RecurringJobScheduleId");
				this.SetAttributeValue("fixrm_recurringjobscheduleid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("fixrm_RecurringJobScheduleId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_recurringjobscheduleid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.fixrm_RecurringJobScheduleId = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fixrm_scheduletype")]
		public Microsoft.Xrm.Sdk.OptionSetValue fixrm_ScheduleType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fixrm_scheduletype");
			}
			set
			{
				this.OnPropertyChanging("fixrm_ScheduleType");
				this.SetAttributeValue("fixrm_scheduletype", value);
				this.OnPropertyChanged("fixrm_ScheduleType");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Status of the Recurring Job Schedule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobScheduleState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobScheduleState)(System.Enum.ToObject(typeof(FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobScheduleState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Recurring Job Schedule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public System.Nullable<FixRM.LastSchedule.Plugins.Entities.fixrm_recurringjobschedule_statuscode> statuscode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				if ((optionSet != null))
				{
					return ((FixRM.LastSchedule.Plugins.Entities.fixrm_recurringjobschedule_statuscode)(System.Enum.ToObject(typeof(FixRM.LastSchedule.Plugins.Entities.fixrm_recurringjobschedule_statuscode), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				if ((value == null))
				{
					this.SetAttributeValue("statuscode", null);
				}
				else
				{
					this.SetAttributeValue("statuscode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N fixrm_recurringjobschedule_recurringjob
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fixrm_recurringjobschedule_recurringjob")]
		public System.Collections.Generic.IEnumerable<FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJob> fixrm_recurringjobschedule_recurringjob
		{
			get
			{
				return this.GetRelatedEntities<FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJob>("fixrm_recurringjobschedule_recurringjob", null);
			}
			set
			{
				this.OnPropertyChanging("fixrm_recurringjobschedule_recurringjob");
				this.SetRelatedEntities<FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJob>("fixrm_recurringjobschedule_recurringjob", null, value);
				this.OnPropertyChanged("fixrm_recurringjobschedule_recurringjob");
			}
		}
	}
	
	/// <summary>
	/// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class XrmSvc : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		
		/// <summary>
		/// Constructor.
		/// </summary>
		public XrmSvc(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJob"/> entities.
		/// </summary>
		public System.Linq.IQueryable<FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJob> fixrm_RecurringJobSet
		{
			get
			{
				return this.CreateQuery<FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJob>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobSchedule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobSchedule> fixrm_RecurringJobScheduleSet
		{
			get
			{
				return this.CreateQuery<FixRM.LastSchedule.Plugins.Entities.fixrm_RecurringJobSchedule>();
			}
		}
	}
}
