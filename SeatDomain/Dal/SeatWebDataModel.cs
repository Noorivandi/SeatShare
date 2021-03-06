﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Exir.Framework.Common;
using Exir.Framework.DataAccess;
using Exir.Framework.DataAccess.EntityFramework;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using SeatDomain.Models;

namespace SeatDomain.Dal
{
    public partial class SeatDBEntities1DbContext : EntityDbContext
    {
    	    	public SeatDBEntities1DbContext(string databaseName, string connectionString)
        			:base(new SeatDBEntities1ObjectContext(databaseName,connectionString),true)
        	{
        	Configuration.ValidateOnSaveEnabled = false;
        	}
    }
    
    public partial class SeatDBEntities1ObjectContext : ObjectContextBase
    {
        public const string ConnectionString = "name=SeatDBEntities1";
        public const string ContainerName = "SeatDBEntities1";
    
        #region Constructors
    
              public SeatDBEntities1ObjectContext(string databaseName, string connectionStringName)
                    : base(databaseName, CreateEntityConnection(connectionStringName, typeof(SeatDBEntities1ObjectContext).Assembly), ContainerName)
            {
                Initialize();
            }
    
    
        private void Initialize()
        {
            // Creating proxies requires the use of the ProxyDataContractResolver and
            // may allow lazy loading which can expand the loaded graph during serialization.
            ContextOptions.ProxyCreationEnabled = false;
            ObjectMaterialized += new ObjectMaterializedEventHandler(HandleObjectMaterialized);
        }
    
        private void HandleObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var entity = e.Entity as IObjectWithChangeTracker;
            if (entity != null)
            {
                bool changeTrackingEnabled = entity.ChangeTracker.ChangeTrackingEnabled;
                try
                {
                    entity.MarkAsUnchanged();
                }
                finally
                {
                    entity.ChangeTracker.ChangeTrackingEnabled = changeTrackingEnabled;
                }
                this.StoreReferenceKeyValues(entity);
            }
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<BackstageJob> BackstageJobs
        {
            get { return _backstageJobs  ?? (_backstageJobs = CreateObjectSet<BackstageJob>("SeatDBEntities1.BackstageJobs")); }
        }
        private ObjectSet<BackstageJob> _backstageJobs;
    
        public ObjectSet<HardLog> HardLogs
        {
            get { return _hardLogs  ?? (_hardLogs = CreateObjectSet<HardLog>("SeatDBEntities1.HardLogs")); }
        }
        private ObjectSet<HardLog> _hardLogs;
    
        public ObjectSet<Holiday> Holidays
        {
            get { return _holidays  ?? (_holidays = CreateObjectSet<Holiday>("SeatDBEntities1.Holidays")); }
        }
        private ObjectSet<Holiday> _holidays;
    
        public ObjectSet<UserActivity> UserActivities
        {
            get { return _userActivities  ?? (_userActivities = CreateObjectSet<UserActivity>("SeatDBEntities1.UserActivities")); }
        }
        private ObjectSet<UserActivity> _userActivities;
    
        public ObjectSet<DashboardNote> DashboardNotes
        {
            get { return _dashboardNotes  ?? (_dashboardNotes = CreateObjectSet<DashboardNote>("SeatDBEntities1.DashboardNotes")); }
        }
        private ObjectSet<DashboardNote> _dashboardNotes;
    
        public ObjectSet<DashboardUserNote> DashboardUserNotes
        {
            get { return _dashboardUserNotes  ?? (_dashboardUserNotes = CreateObjectSet<DashboardUserNote>("SeatDBEntities1.DashboardUserNotes")); }
        }
        private ObjectSet<DashboardUserNote> _dashboardUserNotes;
    
        public ObjectSet<FeedBack> FeedBacks
        {
            get { return _feedBacks  ?? (_feedBacks = CreateObjectSet<FeedBack>("SeatDBEntities1.FeedBacks")); }
        }
        private ObjectSet<FeedBack> _feedBacks;
    
        public ObjectSet<HelpInformation> HelpInformations
        {
            get { return _helpInformations  ?? (_helpInformations = CreateObjectSet<HelpInformation>("SeatDBEntities1.HelpInformations")); }
        }
        private ObjectSet<HelpInformation> _helpInformations;
    
        public ObjectSet<News> News
        {
            get { return _news  ?? (_news = CreateObjectSet<News>("SeatDBEntities1.News")); }
        }
        private ObjectSet<News> _news;
    
        public ObjectSet<NewsCategory> NewsCategories
        {
            get { return _newsCategories  ?? (_newsCategories = CreateObjectSet<NewsCategory>("SeatDBEntities1.NewsCategories")); }
        }
        private ObjectSet<NewsCategory> _newsCategories;
    
        public ObjectSet<UserProfile> UserProfiles
        {
            get { return _userProfiles  ?? (_userProfiles = CreateObjectSet<UserProfile>("SeatDBEntities1.UserProfiles")); }
        }
        private ObjectSet<UserProfile> _userProfiles;
    
        public ObjectSet<ShortLink> ShortLinks
        {
            get { return _shortLinks  ?? (_shortLinks = CreateObjectSet<ShortLink>("SeatDBEntities1.ShortLinks")); }
        }
        private ObjectSet<ShortLink> _shortLinks;
    
        public ObjectSet<KeyValue> KeyValues
        {
            get { return _keyValues  ?? (_keyValues = CreateObjectSet<KeyValue>("SeatDBEntities1.KeyValues")); }
        }
        private ObjectSet<KeyValue> _keyValues;
    
        public ObjectSet<SystemMessage> SystemMessages
        {
            get { return _systemMessages  ?? (_systemMessages = CreateObjectSet<SystemMessage>("SeatDBEntities1.SystemMessages")); }
        }
        private ObjectSet<SystemMessage> _systemMessages;
    
        public ObjectSet<AspNetRole> AspNetRoles
        {
            get { return _aspNetRoles  ?? (_aspNetRoles = CreateObjectSet<AspNetRole>("SeatDBEntities1.AspNetRoles")); }
        }
        private ObjectSet<AspNetRole> _aspNetRoles;
    
        public ObjectSet<AspNetUser> AspNetUsers
        {
            get { return _aspNetUsers  ?? (_aspNetUsers = CreateObjectSet<AspNetUser>("SeatDBEntities1.AspNetUsers")); }
        }
        private ObjectSet<AspNetUser> _aspNetUsers;
    
        public ObjectSet<JobLog> JobLogs
        {
            get { return _jobLogs  ?? (_jobLogs = CreateObjectSet<JobLog>("SeatDBEntities1.JobLogs")); }
        }
        private ObjectSet<JobLog> _jobLogs;

        #endregion

    }
}
