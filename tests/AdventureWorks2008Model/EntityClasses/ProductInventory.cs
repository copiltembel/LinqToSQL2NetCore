﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace ReadTestsAdventureWorks2008.EntityClasses
{
	/// <summary>Class which represents the entity 'ProductInventory', mapped on table 'AdventureWorks.Production.ProductInventory'.</summary>
	public partial class ProductInventory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Byte	_bin;
		private System.Int16	_locationId;
		private System.DateTime	_modifiedDate;
		private System.Int32	_productId;
		private System.Int16	_quantity;
		private System.Guid	_rowguid;
		private System.String	_shelf;
		private EntityRef <Location> _location;
		private EntityRef <Product> _product;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnBinChanging(System.Byte value);
		partial void OnBinChanged();
		partial void OnLocationIdChanging(System.Int16 value);
		partial void OnLocationIdChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnProductIdChanging(System.Int32 value);
		partial void OnProductIdChanged();
		partial void OnQuantityChanging(System.Int16 value);
		partial void OnQuantityChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		partial void OnShelfChanging(System.String value);
		partial void OnShelfChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="ProductInventory"/> class.</summary>
		public ProductInventory()
		{
			_location = default(EntityRef<Location>);
			_product = default(EntityRef<Product>);
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the Bin field. Mapped on target field 'Bin'. </summary>
		public System.Byte Bin
		{
			get	{ return _bin; }
			set
			{
				if((_bin != value))
				{
					OnBinChanging(value);
					SendPropertyChanging("Bin");
					_bin = value;
					SendPropertyChanged("Bin");
					OnBinChanged();
				}
			}
		}

		/// <summary>Gets or sets the LocationId field. Mapped on target field 'LocationID'. </summary>
		public System.Int16 LocationId
		{
			get	{ return _locationId; }
			set
			{
				if((_locationId != value))
				{
					if(_location.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnLocationIdChanging(value);
					SendPropertyChanging("LocationId");
					_locationId = value;
					SendPropertyChanged("LocationId");
					OnLocationIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the ProductId field. Mapped on target field 'ProductID'. </summary>
		public System.Int32 ProductId
		{
			get	{ return _productId; }
			set
			{
				if((_productId != value))
				{
					if(_product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnProductIdChanging(value);
					SendPropertyChanging("ProductId");
					_productId = value;
					SendPropertyChanged("ProductId");
					OnProductIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the Quantity field. Mapped on target field 'Quantity'. </summary>
		public System.Int16 Quantity
		{
			get	{ return _quantity; }
			set
			{
				if((_quantity != value))
				{
					OnQuantityChanging(value);
					SendPropertyChanging("Quantity");
					_quantity = value;
					SendPropertyChanged("Quantity");
					OnQuantityChanged();
				}
			}
		}

		/// <summary>Gets or sets the Rowguid field. Mapped on target field 'rowguid'. </summary>
		public System.Guid Rowguid
		{
			get	{ return _rowguid; }
			set
			{
				if((_rowguid != value))
				{
					OnRowguidChanging(value);
					SendPropertyChanging("Rowguid");
					_rowguid = value;
					SendPropertyChanged("Rowguid");
					OnRowguidChanged();
				}
			}
		}

		/// <summary>Gets or sets the Shelf field. Mapped on target field 'Shelf'. </summary>
		public System.String Shelf
		{
			get	{ return _shelf; }
			set
			{
				if((_shelf != value))
				{
					OnShelfChanging(value);
					SendPropertyChanging("Shelf");
					_shelf = value;
					SendPropertyChanged("Shelf");
					OnShelfChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'ProductInventory.Location - Location.ProductInventories (m:1)'</summary>
		public Location Location
		{
			get { return _location.Entity; }
			set
			{
				Location previousValue = _location.Entity;
				if((previousValue != value) || (_location.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Location");
					if(previousValue != null)
					{
						_location.Entity = null;
						previousValue.ProductInventories.Remove(this);
					}
					_location.Entity = value;
					if(value == null)
					{
						_locationId = default(System.Int16);
					}
					else
					{
						value.ProductInventories.Add(this);
						_locationId = value.LocationId;
					}
					this.SendPropertyChanged("Location");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'ProductInventory.Product - Product.ProductInventories (m:1)'</summary>
		public Product Product
		{
			get { return _product.Entity; }
			set
			{
				Product previousValue = _product.Entity;
				if((previousValue != value) || (_product.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Product");
					if(previousValue != null)
					{
						_product.Entity = null;
						previousValue.ProductInventories.Remove(this);
					}
					_product.Entity = value;
					if(value == null)
					{
						_productId = default(System.Int32);
					}
					else
					{
						value.ProductInventories.Add(this);
						_productId = value.ProductId;
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649