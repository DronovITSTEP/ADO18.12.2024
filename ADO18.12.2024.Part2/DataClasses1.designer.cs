﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADO18._12._2024.Part2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Storage")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertInformations(Informations instance);
    partial void UpdateInformations(Informations instance);
    partial void DeleteInformations(Informations instance);
    partial void InsertProducts(Products instance);
    partial void UpdateProducts(Products instance);
    partial void DeleteProducts(Products instance);
    partial void InsertSuppliers(Suppliers instance);
    partial void UpdateSuppliers(Suppliers instance);
    partial void DeleteSuppliers(Suppliers instance);
    partial void InsertTypeProducts(TypeProducts instance);
    partial void UpdateTypeProducts(TypeProducts instance);
    partial void DeleteTypeProducts(TypeProducts instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ADO18._12._2024.Part2.Properties.Settings.Default.StorageConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Informations> Informations
		{
			get
			{
				return this.GetTable<Informations>();
			}
		}
		
		public System.Data.Linq.Table<Products> Products
		{
			get
			{
				return this.GetTable<Products>();
			}
		}
		
		public System.Data.Linq.Table<Suppliers> Suppliers
		{
			get
			{
				return this.GetTable<Suppliers>();
			}
		}
		
		public System.Data.Linq.Table<TypeProducts> TypeProducts
		{
			get
			{
				return this.GetTable<TypeProducts>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Informations")]
	public partial class Informations : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _ProductId;
		
		private System.Nullable<int> _TypeProductId;
		
		private System.Nullable<int> _Count;
		
		private System.Nullable<System.DateTime> _DateSupply;
		
		private System.Nullable<int> _SuppliersId;
		
		private System.Nullable<decimal> _Price;
		
		private EntityRef<Products> _Products;
		
		private EntityRef<Suppliers> _Suppliers;
		
		private EntityRef<TypeProducts> _TypeProducts;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnProductIdChanging(System.Nullable<int> value);
    partial void OnProductIdChanged();
    partial void OnTypeProductIdChanging(System.Nullable<int> value);
    partial void OnTypeProductIdChanged();
    partial void OnCountChanging(System.Nullable<int> value);
    partial void OnCountChanged();
    partial void OnDateSupplyChanging(System.Nullable<System.DateTime> value);
    partial void OnDateSupplyChanged();
    partial void OnSuppliersIdChanging(System.Nullable<int> value);
    partial void OnSuppliersIdChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    #endregion
		
		public Informations()
		{
			this._Products = default(EntityRef<Products>);
			this._Suppliers = default(EntityRef<Suppliers>);
			this._TypeProducts = default(EntityRef<TypeProducts>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int")]
		public System.Nullable<int> ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Products.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeProductId", DbType="Int")]
		public System.Nullable<int> TypeProductId
		{
			get
			{
				return this._TypeProductId;
			}
			set
			{
				if ((this._TypeProductId != value))
				{
					if (this._TypeProducts.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTypeProductIdChanging(value);
					this.SendPropertyChanging();
					this._TypeProductId = value;
					this.SendPropertyChanged("TypeProductId");
					this.OnTypeProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Count", DbType="Int")]
		public System.Nullable<int> Count
		{
			get
			{
				return this._Count;
			}
			set
			{
				if ((this._Count != value))
				{
					this.OnCountChanging(value);
					this.SendPropertyChanging();
					this._Count = value;
					this.SendPropertyChanged("Count");
					this.OnCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateSupply", DbType="Date")]
		public System.Nullable<System.DateTime> DateSupply
		{
			get
			{
				return this._DateSupply;
			}
			set
			{
				if ((this._DateSupply != value))
				{
					this.OnDateSupplyChanging(value);
					this.SendPropertyChanging();
					this._DateSupply = value;
					this.SendPropertyChanged("DateSupply");
					this.OnDateSupplyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuppliersId", DbType="Int")]
		public System.Nullable<int> SuppliersId
		{
			get
			{
				return this._SuppliersId;
			}
			set
			{
				if ((this._SuppliersId != value))
				{
					if (this._Suppliers.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSuppliersIdChanging(value);
					this.SendPropertyChanging();
					this._SuppliersId = value;
					this.SendPropertyChanged("SuppliersId");
					this.OnSuppliersIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_Informations", Storage="_Products", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true)]
		public Products Products
		{
			get
			{
				return this._Products.Entity;
			}
			set
			{
				Products previousValue = this._Products.Entity;
				if (((previousValue != value) 
							|| (this._Products.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Products.Entity = null;
						previousValue.Informations.Remove(this);
					}
					this._Products.Entity = value;
					if ((value != null))
					{
						value.Informations.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Products");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Suppliers_Informations", Storage="_Suppliers", ThisKey="SuppliersId", OtherKey="Id", IsForeignKey=true)]
		public Suppliers Suppliers
		{
			get
			{
				return this._Suppliers.Entity;
			}
			set
			{
				Suppliers previousValue = this._Suppliers.Entity;
				if (((previousValue != value) 
							|| (this._Suppliers.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Suppliers.Entity = null;
						previousValue.Informations.Remove(this);
					}
					this._Suppliers.Entity = value;
					if ((value != null))
					{
						value.Informations.Add(this);
						this._SuppliersId = value.Id;
					}
					else
					{
						this._SuppliersId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Suppliers");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TypeProducts_Informations", Storage="_TypeProducts", ThisKey="TypeProductId", OtherKey="Id", IsForeignKey=true)]
		public TypeProducts TypeProducts
		{
			get
			{
				return this._TypeProducts.Entity;
			}
			set
			{
				TypeProducts previousValue = this._TypeProducts.Entity;
				if (((previousValue != value) 
							|| (this._TypeProducts.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TypeProducts.Entity = null;
						previousValue.Informations.Remove(this);
					}
					this._TypeProducts.Entity = value;
					if ((value != null))
					{
						value.Informations.Add(this);
						this._TypeProductId = value.Id;
					}
					else
					{
						this._TypeProductId = default(Nullable<int>);
					}
					this.SendPropertyChanged("TypeProducts");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Products : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Informations> _Informations;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Products()
		{
			this._Informations = new EntitySet<Informations>(new Action<Informations>(this.attach_Informations), new Action<Informations>(this.detach_Informations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_Informations", Storage="_Informations", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<Informations> Informations
		{
			get
			{
				return this._Informations;
			}
			set
			{
				this._Informations.Assign(value);
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
		
		private void attach_Informations(Informations entity)
		{
			this.SendPropertyChanging();
			entity.Products = this;
		}
		
		private void detach_Informations(Informations entity)
		{
			this.SendPropertyChanging();
			entity.Products = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Suppliers")]
	public partial class Suppliers : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Informations> _Informations;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Suppliers()
		{
			this._Informations = new EntitySet<Informations>(new Action<Informations>(this.attach_Informations), new Action<Informations>(this.detach_Informations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Suppliers_Informations", Storage="_Informations", ThisKey="Id", OtherKey="SuppliersId")]
		public EntitySet<Informations> Informations
		{
			get
			{
				return this._Informations;
			}
			set
			{
				this._Informations.Assign(value);
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
		
		private void attach_Informations(Informations entity)
		{
			this.SendPropertyChanging();
			entity.Suppliers = this;
		}
		
		private void detach_Informations(Informations entity)
		{
			this.SendPropertyChanging();
			entity.Suppliers = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TypeProducts")]
	public partial class TypeProducts : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Informations> _Informations;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public TypeProducts()
		{
			this._Informations = new EntitySet<Informations>(new Action<Informations>(this.attach_Informations), new Action<Informations>(this.detach_Informations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TypeProducts_Informations", Storage="_Informations", ThisKey="Id", OtherKey="TypeProductId")]
		public EntitySet<Informations> Informations
		{
			get
			{
				return this._Informations;
			}
			set
			{
				this._Informations.Assign(value);
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
		
		private void attach_Informations(Informations entity)
		{
			this.SendPropertyChanging();
			entity.TypeProducts = this;
		}
		
		private void detach_Informations(Informations entity)
		{
			this.SendPropertyChanging();
			entity.TypeProducts = null;
		}
	}
}
#pragma warning restore 1591