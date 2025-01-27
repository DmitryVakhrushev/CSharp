﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1378
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _5_Objectville_Promotion
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="A10F6F2E3E1061E852871A0867696476_RATOR\\LOCAL SETTINGS\\APPLICATION DATA\\TEMPORARY " +
		"PROJECTS\\15 OBJECTVILLE PROMOTION\\CONTACTDB.MDF")]
	public partial class ContactDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPeople(People instance);
    partial void UpdatePeople(People instance);
    partial void DeletePeople(People instance);
    #endregion
		
		static ContactDBDataContext()
		{
		}
		
		public ContactDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContactDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContactDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContactDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContactDBDataContext() : 
				base(global::_5_Objectville_Promotion.Properties.Settings.Default.ContactDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<People> Peoples
		{
			get
			{
				return this.GetTable<People>();
			}
		}
	}
	
	[Table(Name="dbo.People")]
	public partial class People : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ContactID;
		
		private string _Name;
		
		private string _Company;
		
		private string _Telephone;
		
		private string _Email;
		
		private System.Nullable<bool> _Client;
		
		private System.Nullable<System.DateTime> _LastCall;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    partial void OnContactIDChanging(int value);
    partial void OnContactIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnTelephoneChanging(string value);
    partial void OnTelephoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnClientChanging(System.Nullable<bool> value);
    partial void OnClientChanged();
    partial void OnLastCallChanging(System.Nullable<System.DateTime> value);
    partial void OnLastCallChanged();
    #endregion
		
		public People()
		{
			OnCreated();
		}
		
		[Column(Storage="_ContactID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ContactID
		{
			get
			{
				return this._ContactID;
			}
			set
			{
				if ((this._ContactID != value))
				{
					this.OnContactIDChanging(value);
					this.SendPropertyChanging();
					this._ContactID = value;
					this.SendPropertyChanged("ContactID");
					this.OnContactIDChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_Company", DbType="NVarChar(50)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._Company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[Column(Storage="_Telephone", DbType="NVarChar(50)")]
		public string Telephone
		{
			get
			{
				return this._Telephone;
			}
			set
			{
				if ((this._Telephone != value))
				{
					this.OnTelephoneChanging(value);
					this.SendPropertyChanging();
					this._Telephone = value;
					this.SendPropertyChanged("Telephone");
					this.OnTelephoneChanged();
				}
			}
		}
		
		[Column(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[Column(Storage="_Client", DbType="Bit")]
		public System.Nullable<bool> Client
		{
			get
			{
				return this._Client;
			}
			set
			{
				if ((this._Client != value))
				{
					this.OnClientChanging(value);
					this.SendPropertyChanging();
					this._Client = value;
					this.SendPropertyChanged("Client");
					this.OnClientChanged();
				}
			}
		}
		
		[Column(Storage="_LastCall", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastCall
		{
			get
			{
				return this._LastCall;
			}
			set
			{
				if ((this._LastCall != value))
				{
					this.OnLastCallChanging(value);
					this.SendPropertyChanging();
					this._LastCall = value;
					this.SendPropertyChanged("LastCall");
					this.OnLastCallChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
