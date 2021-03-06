﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Burse.LinqToMSSql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="66bit_Burse")]
	public partial class BurseMSSqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBuyOrder(BuyOrder instance);
    partial void UpdateBuyOrder(BuyOrder instance);
    partial void DeleteBuyOrder(BuyOrder instance);
    partial void InsertSellOrder(SellOrder instance);
    partial void UpdateSellOrder(SellOrder instance);
    partial void DeleteSellOrder(SellOrder instance);
    partial void InsertBurseTransaction(BurseTransaction instance);
    partial void UpdateBurseTransaction(BurseTransaction instance);
    partial void DeleteBurseTransaction(BurseTransaction instance);
    #endregion
		
		public BurseMSSqlDataContext() : 
				base(global::Burse.LinqToMSSql.Properties.Settings.Default._66bit_BurseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BurseMSSqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BurseMSSqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BurseMSSqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BurseMSSqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BuyOrder> BuyOrders
		{
			get
			{
				return this.GetTable<BuyOrder>();
			}
		}
		
		public System.Data.Linq.Table<SellOrder> SellOrders
		{
			get
			{
				return this.GetTable<SellOrder>();
			}
		}
		
		public System.Data.Linq.Table<BurseTransaction> BurseTransactions
		{
			get
			{
				return this.GetTable<BurseTransaction>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BuyOrders")]
	public partial class BuyOrder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private System.Nullable<System.DateTimeOffset> _BuyDate;
		
		private System.Nullable<decimal> _BuyPrice;
		
		private System.Nullable<long> _NumbersToBuy;
		
		private string _BuyComment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnBuyDateChanging(System.Nullable<System.DateTimeOffset> value);
    partial void OnBuyDateChanged();
    partial void OnBuyPriceChanging(System.Nullable<decimal> value);
    partial void OnBuyPriceChanged();
    partial void OnNumbersToBuyChanging(System.Nullable<long> value);
    partial void OnNumbersToBuyChanged();
    partial void OnBuyCommentChanging(string value);
    partial void OnBuyCommentChanged();
    #endregion
		
		public BuyOrder()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="BigInt NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuyDate", DbType="DateTimeOffset")]
		public System.Nullable<System.DateTimeOffset> BuyDate
		{
			get
			{
				return this._BuyDate;
			}
			set
			{
				if ((this._BuyDate != value))
				{
					this.OnBuyDateChanging(value);
					this.SendPropertyChanging();
					this._BuyDate = value;
					this.SendPropertyChanged("BuyDate");
					this.OnBuyDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuyPrice", DbType="Decimal(15,2)")]
		public System.Nullable<decimal> BuyPrice
		{
			get
			{
				return this._BuyPrice;
			}
			set
			{
				if ((this._BuyPrice != value))
				{
					this.OnBuyPriceChanging(value);
					this.SendPropertyChanging();
					this._BuyPrice = value;
					this.SendPropertyChanged("BuyPrice");
					this.OnBuyPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumbersToBuy", DbType="BigInt")]
		public System.Nullable<long> NumbersToBuy
		{
			get
			{
				return this._NumbersToBuy;
			}
			set
			{
				if ((this._NumbersToBuy != value))
				{
					this.OnNumbersToBuyChanging(value);
					this.SendPropertyChanging();
					this._NumbersToBuy = value;
					this.SendPropertyChanged("NumbersToBuy");
					this.OnNumbersToBuyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuyComment", DbType="NVarChar(4000)")]
		public string BuyComment
		{
			get
			{
				return this._BuyComment;
			}
			set
			{
				if ((this._BuyComment != value))
				{
					this.OnBuyCommentChanging(value);
					this.SendPropertyChanging();
					this._BuyComment = value;
					this.SendPropertyChanged("BuyComment");
					this.OnBuyCommentChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SellOrders")]
	public partial class SellOrder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private System.Nullable<System.DateTimeOffset> _SellDate;
		
		private System.Nullable<decimal> _SellPrice;
		
		private System.Nullable<long> _NumbersToSell;
		
		private string _SellComment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnSellDateChanging(System.Nullable<System.DateTimeOffset> value);
    partial void OnSellDateChanged();
    partial void OnSellPriceChanging(System.Nullable<decimal> value);
    partial void OnSellPriceChanged();
    partial void OnNumbersToSellChanging(System.Nullable<long> value);
    partial void OnNumbersToSellChanged();
    partial void OnSellCommentChanging(string value);
    partial void OnSellCommentChanged();
    #endregion
		
		public SellOrder()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="BigInt NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellDate", DbType="DateTimeOffset")]
		public System.Nullable<System.DateTimeOffset> SellDate
		{
			get
			{
				return this._SellDate;
			}
			set
			{
				if ((this._SellDate != value))
				{
					this.OnSellDateChanging(value);
					this.SendPropertyChanging();
					this._SellDate = value;
					this.SendPropertyChanged("SellDate");
					this.OnSellDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellPrice", DbType="Decimal(15,2)")]
		public System.Nullable<decimal> SellPrice
		{
			get
			{
				return this._SellPrice;
			}
			set
			{
				if ((this._SellPrice != value))
				{
					this.OnSellPriceChanging(value);
					this.SendPropertyChanging();
					this._SellPrice = value;
					this.SendPropertyChanged("SellPrice");
					this.OnSellPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumbersToSell", DbType="BigInt")]
		public System.Nullable<long> NumbersToSell
		{
			get
			{
				return this._NumbersToSell;
			}
			set
			{
				if ((this._NumbersToSell != value))
				{
					this.OnNumbersToSellChanging(value);
					this.SendPropertyChanging();
					this._NumbersToSell = value;
					this.SendPropertyChanged("NumbersToSell");
					this.OnNumbersToSellChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellComment", DbType="NVarChar(4000)")]
		public string SellComment
		{
			get
			{
				return this._SellComment;
			}
			set
			{
				if ((this._SellComment != value))
				{
					this.OnSellCommentChanging(value);
					this.SendPropertyChanging();
					this._SellComment = value;
					this.SendPropertyChanged("SellComment");
					this.OnSellCommentChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BurseTransactions")]
	public partial class BurseTransaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private System.Nullable<System.DateTimeOffset> _CompleteDate;
		
		private System.Nullable<long> _NumbersToTransaction;
		
		private System.Nullable<decimal> _TransactionPrice;
		
		private System.Nullable<System.DateTimeOffset> _BuyDate;
		
		private System.Nullable<System.DateTimeOffset> _SellDate;
		
		private string _BuyComment;
		
		private string _SellComment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnCompleteDateChanging(System.Nullable<System.DateTimeOffset> value);
    partial void OnCompleteDateChanged();
    partial void OnNumbersToTransactionChanging(System.Nullable<long> value);
    partial void OnNumbersToTransactionChanged();
    partial void OnTransactionPriceChanging(System.Nullable<decimal> value);
    partial void OnTransactionPriceChanged();
    partial void OnBuyDateChanging(System.Nullable<System.DateTimeOffset> value);
    partial void OnBuyDateChanged();
    partial void OnSellDateChanging(System.Nullable<System.DateTimeOffset> value);
    partial void OnSellDateChanged();
    partial void OnBuyCommentChanging(string value);
    partial void OnBuyCommentChanged();
    partial void OnSellCommentChanging(string value);
    partial void OnSellCommentChanged();
    #endregion
		
		public BurseTransaction()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompleteDate", DbType="DateTimeOffset")]
		public System.Nullable<System.DateTimeOffset> CompleteDate
		{
			get
			{
				return this._CompleteDate;
			}
			set
			{
				if ((this._CompleteDate != value))
				{
					this.OnCompleteDateChanging(value);
					this.SendPropertyChanging();
					this._CompleteDate = value;
					this.SendPropertyChanged("CompleteDate");
					this.OnCompleteDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumbersToTransaction", DbType="BigInt")]
		public System.Nullable<long> NumbersToTransaction
		{
			get
			{
				return this._NumbersToTransaction;
			}
			set
			{
				if ((this._NumbersToTransaction != value))
				{
					this.OnNumbersToTransactionChanging(value);
					this.SendPropertyChanging();
					this._NumbersToTransaction = value;
					this.SendPropertyChanged("NumbersToTransaction");
					this.OnNumbersToTransactionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionPrice", DbType="Decimal(15,2)")]
		public System.Nullable<decimal> TransactionPrice
		{
			get
			{
				return this._TransactionPrice;
			}
			set
			{
				if ((this._TransactionPrice != value))
				{
					this.OnTransactionPriceChanging(value);
					this.SendPropertyChanging();
					this._TransactionPrice = value;
					this.SendPropertyChanged("TransactionPrice");
					this.OnTransactionPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuyDate", DbType="DateTimeOffset")]
		public System.Nullable<System.DateTimeOffset> BuyDate
		{
			get
			{
				return this._BuyDate;
			}
			set
			{
				if ((this._BuyDate != value))
				{
					this.OnBuyDateChanging(value);
					this.SendPropertyChanging();
					this._BuyDate = value;
					this.SendPropertyChanged("BuyDate");
					this.OnBuyDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellDate", DbType="DateTimeOffset")]
		public System.Nullable<System.DateTimeOffset> SellDate
		{
			get
			{
				return this._SellDate;
			}
			set
			{
				if ((this._SellDate != value))
				{
					this.OnSellDateChanging(value);
					this.SendPropertyChanging();
					this._SellDate = value;
					this.SendPropertyChanged("SellDate");
					this.OnSellDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuyComment", DbType="NVarChar(4000)")]
		public string BuyComment
		{
			get
			{
				return this._BuyComment;
			}
			set
			{
				if ((this._BuyComment != value))
				{
					this.OnBuyCommentChanging(value);
					this.SendPropertyChanging();
					this._BuyComment = value;
					this.SendPropertyChanged("BuyComment");
					this.OnBuyCommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellComment", DbType="NVarChar(4000)")]
		public string SellComment
		{
			get
			{
				return this._SellComment;
			}
			set
			{
				if ((this._SellComment != value))
				{
					this.OnSellCommentChanging(value);
					this.SendPropertyChanging();
					this._SellComment = value;
					this.SendPropertyChanged("SellComment");
					this.OnSellCommentChanged();
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
#pragma warning restore 1591
