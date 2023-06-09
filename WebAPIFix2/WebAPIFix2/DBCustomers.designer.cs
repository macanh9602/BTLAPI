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

namespace WebAPIFix2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DuLieu")]
	public partial class DBCustomersDataContext : System.Data.Linq.DataContext
	{
        public DBCustomersDataContext() :
                base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DuLieuConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttAnhSP(tAnhSP instance);
    partial void UpdatetAnhSP(tAnhSP instance);
    partial void DeletetAnhSP(tAnhSP instance);
    partial void InserttblAdmin(tblAdmin instance);
    partial void UpdatetblAdmin(tblAdmin instance);
    partial void DeletetblAdmin(tblAdmin instance);
    partial void InserttblKhach(tblKhach instance);
    partial void UpdatetblKhach(tblKhach instance);
    partial void DeletetblKhach(tblKhach instance);
    partial void InserttblTaiKhoan(tblTaiKhoan instance);
    partial void UpdatetblTaiKhoan(tblTaiKhoan instance);
    partial void DeletetblTaiKhoan(tblTaiKhoan instance);
    partial void InserttDanhMucSP(tDanhMucSP instance);
    partial void UpdatetDanhMucSP(tDanhMucSP instance);
    partial void DeletetDanhMucSP(tDanhMucSP instance);
    partial void InserttHangSX(tHangSX instance);
    partial void UpdatetHangSX(tHangSX instance);
    partial void DeletetHangSX(tHangSX instance);
    partial void InserttMauSac(tMauSac instance);
    partial void UpdatetMauSac(tMauSac instance);
    partial void DeletetMauSac(tMauSac instance);
    #endregion
		
		public DBCustomersDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBCustomersDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBCustomersDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBCustomersDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tAnhSP> tAnhSPs
		{
			get
			{
				return this.GetTable<tAnhSP>();
			}
		}
		
		public System.Data.Linq.Table<tblAdmin> tblAdmins
		{
			get
			{
				return this.GetTable<tblAdmin>();
			}
		}
		
		public System.Data.Linq.Table<tblKhach> tblKhaches
		{
			get
			{
				return this.GetTable<tblKhach>();
			}
		}
		
		public System.Data.Linq.Table<tblTaiKhoan> tblTaiKhoans
		{
			get
			{
				return this.GetTable<tblTaiKhoan>();
			}
		}
		
		public System.Data.Linq.Table<tDanhMucSP> tDanhMucSPs
		{
			get
			{
				return this.GetTable<tDanhMucSP>();
			}
		}
		
		public System.Data.Linq.Table<tHangSX> tHangSXes
		{
			get
			{
				return this.GetTable<tHangSX>();
			}
		}
		
		public System.Data.Linq.Table<tMauSac> tMauSacs
		{
			get
			{
				return this.GetTable<tMauSac>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tAnhSP")]
	public partial class tAnhSP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSP;
		
		private string _TenFileAnh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(string value);
    partial void OnMaSPChanged();
    partial void OnTenFileAnhChanging(string value);
    partial void OnTenFileAnhChanged();
    #endregion
		
		public tAnhSP()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenFileAnh", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenFileAnh
		{
			get
			{
				return this._TenFileAnh;
			}
			set
			{
				if ((this._TenFileAnh != value))
				{
					this.OnTenFileAnhChanging(value);
					this.SendPropertyChanging();
					this._TenFileAnh = value;
					this.SendPropertyChanged("TenFileAnh");
					this.OnTenFileAnhChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblAdmin")]
	public partial class tblAdmin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID_Admin;
		
		private string _Ten_Admin;
		
		private EntitySet<tblTaiKhoan> _tblTaiKhoans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_AdminChanging(string value);
    partial void OnID_AdminChanged();
    partial void OnTen_AdminChanging(string value);
    partial void OnTen_AdminChanged();
    #endregion
		
		public tblAdmin()
		{
			this._tblTaiKhoans = new EntitySet<tblTaiKhoan>(new Action<tblTaiKhoan>(this.attach_tblTaiKhoans), new Action<tblTaiKhoan>(this.detach_tblTaiKhoans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Admin", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID_Admin
		{
			get
			{
				return this._ID_Admin;
			}
			set
			{
				if ((this._ID_Admin != value))
				{
					this.OnID_AdminChanging(value);
					this.SendPropertyChanging();
					this._ID_Admin = value;
					this.SendPropertyChanged("ID_Admin");
					this.OnID_AdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten_Admin", DbType="VarChar(255)")]
		public string Ten_Admin
		{
			get
			{
				return this._Ten_Admin;
			}
			set
			{
				if ((this._Ten_Admin != value))
				{
					this.OnTen_AdminChanging(value);
					this.SendPropertyChanging();
					this._Ten_Admin = value;
					this.SendPropertyChanged("Ten_Admin");
					this.OnTen_AdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblAdmin_tblTaiKhoan", Storage="_tblTaiKhoans", ThisKey="ID_Admin", OtherKey="ID_Admin")]
		public EntitySet<tblTaiKhoan> tblTaiKhoans
		{
			get
			{
				return this._tblTaiKhoans;
			}
			set
			{
				this._tblTaiKhoans.Assign(value);
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
		
		private void attach_tblTaiKhoans(tblTaiKhoan entity)
		{
			this.SendPropertyChanging();
			entity.tblAdmin = this;
		}
		
		private void detach_tblTaiKhoans(tblTaiKhoan entity)
		{
			this.SendPropertyChanging();
			entity.tblAdmin = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblKhach")]
	public partial class tblKhach : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Makhach;
		
		private string _Tenkhach;
		
		private string _Diachi;
		
		private string _Dienthoai;
		
		private EntitySet<tblTaiKhoan> _tblTaiKhoans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMakhachChanging(string value);
    partial void OnMakhachChanged();
    partial void OnTenkhachChanging(string value);
    partial void OnTenkhachChanged();
    partial void OnDiachiChanging(string value);
    partial void OnDiachiChanged();
    partial void OnDienthoaiChanging(string value);
    partial void OnDienthoaiChanged();
    #endregion
		
		public tblKhach()
		{
			this._tblTaiKhoans = new EntitySet<tblTaiKhoan>(new Action<tblTaiKhoan>(this.attach_tblTaiKhoans), new Action<tblTaiKhoan>(this.detach_tblTaiKhoans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Makhach", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Makhach
		{
			get
			{
				return this._Makhach;
			}
			set
			{
				if ((this._Makhach != value))
				{
					this.OnMakhachChanging(value);
					this.SendPropertyChanging();
					this._Makhach = value;
					this.SendPropertyChanged("Makhach");
					this.OnMakhachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tenkhach", DbType="VarChar(20)")]
		public string Tenkhach
		{
			get
			{
				return this._Tenkhach;
			}
			set
			{
				if ((this._Tenkhach != value))
				{
					this.OnTenkhachChanging(value);
					this.SendPropertyChanging();
					this._Tenkhach = value;
					this.SendPropertyChanged("Tenkhach");
					this.OnTenkhachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diachi", DbType="VarChar(20)")]
		public string Diachi
		{
			get
			{
				return this._Diachi;
			}
			set
			{
				if ((this._Diachi != value))
				{
					this.OnDiachiChanging(value);
					this.SendPropertyChanging();
					this._Diachi = value;
					this.SendPropertyChanged("Diachi");
					this.OnDiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dienthoai", DbType="VarChar(20)")]
		public string Dienthoai
		{
			get
			{
				return this._Dienthoai;
			}
			set
			{
				if ((this._Dienthoai != value))
				{
					this.OnDienthoaiChanging(value);
					this.SendPropertyChanging();
					this._Dienthoai = value;
					this.SendPropertyChanged("Dienthoai");
					this.OnDienthoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblKhach_tblTaiKhoan", Storage="_tblTaiKhoans", ThisKey="Makhach", OtherKey="Makhach")]
		public EntitySet<tblTaiKhoan> tblTaiKhoans
		{
			get
			{
				return this._tblTaiKhoans;
			}
			set
			{
				this._tblTaiKhoans.Assign(value);
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
		
		private void attach_tblTaiKhoans(tblTaiKhoan entity)
		{
			this.SendPropertyChanging();
			entity.tblKhach = this;
		}
		
		private void detach_tblTaiKhoans(tblTaiKhoan entity)
		{
			this.SendPropertyChanging();
			entity.tblKhach = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblTaiKhoan")]
	public partial class tblTaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TaiKhoan;
		
		private string _MatKhau;
		
		private string _Makhach;
		
		private string _XacNhanMatKhau;
		
		private string _ID_Admin;
		
		private EntityRef<tblAdmin> _tblAdmin;
		
		private EntityRef<tblKhach> _tblKhach;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnMakhachChanging(string value);
    partial void OnMakhachChanged();
    partial void OnXacNhanMatKhauChanging(string value);
    partial void OnXacNhanMatKhauChanged();
    partial void OnID_AdminChanging(string value);
    partial void OnID_AdminChanged();
    #endregion
		
		public tblTaiKhoan()
		{
			this._tblAdmin = default(EntityRef<tblAdmin>);
			this._tblKhach = default(EntityRef<tblKhach>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="VarChar(255)")]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(255)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Makhach", DbType="VarChar(20)")]
		public string Makhach
		{
			get
			{
				return this._Makhach;
			}
			set
			{
				if ((this._Makhach != value))
				{
					if (this._tblKhach.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMakhachChanging(value);
					this.SendPropertyChanging();
					this._Makhach = value;
					this.SendPropertyChanged("Makhach");
					this.OnMakhachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XacNhanMatKhau", DbType="VarChar(255)")]
		public string XacNhanMatKhau
		{
			get
			{
				return this._XacNhanMatKhau;
			}
			set
			{
				if ((this._XacNhanMatKhau != value))
				{
					this.OnXacNhanMatKhauChanging(value);
					this.SendPropertyChanging();
					this._XacNhanMatKhau = value;
					this.SendPropertyChanged("XacNhanMatKhau");
					this.OnXacNhanMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Admin", DbType="VarChar(20)")]
		public string ID_Admin
		{
			get
			{
				return this._ID_Admin;
			}
			set
			{
				if ((this._ID_Admin != value))
				{
					if (this._tblAdmin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_AdminChanging(value);
					this.SendPropertyChanging();
					this._ID_Admin = value;
					this.SendPropertyChanged("ID_Admin");
					this.OnID_AdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblAdmin_tblTaiKhoan", Storage="_tblAdmin", ThisKey="ID_Admin", OtherKey="ID_Admin", IsForeignKey=true)]
		public tblAdmin tblAdmin
		{
			get
			{
				return this._tblAdmin.Entity;
			}
			set
			{
				tblAdmin previousValue = this._tblAdmin.Entity;
				if (((previousValue != value) 
							|| (this._tblAdmin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblAdmin.Entity = null;
						previousValue.tblTaiKhoans.Remove(this);
					}
					this._tblAdmin.Entity = value;
					if ((value != null))
					{
						value.tblTaiKhoans.Add(this);
						this._ID_Admin = value.ID_Admin;
					}
					else
					{
						this._ID_Admin = default(string);
					}
					this.SendPropertyChanged("tblAdmin");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblKhach_tblTaiKhoan", Storage="_tblKhach", ThisKey="Makhach", OtherKey="Makhach", IsForeignKey=true)]
		public tblKhach tblKhach
		{
			get
			{
				return this._tblKhach.Entity;
			}
			set
			{
				tblKhach previousValue = this._tblKhach.Entity;
				if (((previousValue != value) 
							|| (this._tblKhach.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblKhach.Entity = null;
						previousValue.tblTaiKhoans.Remove(this);
					}
					this._tblKhach.Entity = value;
					if ((value != null))
					{
						value.tblTaiKhoans.Add(this);
						this._Makhach = value.Makhach;
					}
					else
					{
						this._Makhach = default(string);
					}
					this.SendPropertyChanged("tblKhach");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tDanhMucSP")]
	public partial class tDanhMucSP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSP;
		
		private string _TenSP;
		
		private string _MaMau;
		
		private System.Nullable<double> _Gia;
		
		private System.Nullable<double> _SoLuong;
		
		private string _MaHangSX;
		
		private string _ThoiGianBH;
		
		private string _GioiThieu;
		
		private string _MaAnh;
		
		private string _Anh;
		
		private EntityRef<tHangSX> _tHangSX;
		
		private EntityRef<tMauSac> _tMauSac;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(string value);
    partial void OnMaSPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnMaMauChanging(string value);
    partial void OnMaMauChanged();
    partial void OnGiaChanging(System.Nullable<double> value);
    partial void OnGiaChanged();
    partial void OnSoLuongChanging(System.Nullable<double> value);
    partial void OnSoLuongChanged();
    partial void OnMaHangSXChanging(string value);
    partial void OnMaHangSXChanged();
    partial void OnThoiGianBHChanging(string value);
    partial void OnThoiGianBHChanged();
    partial void OnGioiThieuChanging(string value);
    partial void OnGioiThieuChanged();
    partial void OnMaAnhChanging(string value);
    partial void OnMaAnhChanged();
    partial void OnAnhChanging(string value);
    partial void OnAnhChanged();
    #endregion
		
		public tDanhMucSP()
		{
			this._tHangSX = default(EntityRef<tHangSX>);
			this._tMauSac = default(EntityRef<tMauSac>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="VarChar(50)")]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMau", DbType="VarChar(50)")]
		public string MaMau
		{
			get
			{
				return this._MaMau;
			}
			set
			{
				if ((this._MaMau != value))
				{
					if (this._tMauSac.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaMauChanging(value);
					this.SendPropertyChanging();
					this._MaMau = value;
					this.SendPropertyChanged("MaMau");
					this.OnMaMauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Float")]
		public System.Nullable<double> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Float")]
		public System.Nullable<double> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHangSX", DbType="VarChar(50)")]
		public string MaHangSX
		{
			get
			{
				return this._MaHangSX;
			}
			set
			{
				if ((this._MaHangSX != value))
				{
					if (this._tHangSX.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHangSXChanging(value);
					this.SendPropertyChanging();
					this._MaHangSX = value;
					this.SendPropertyChanged("MaHangSX");
					this.OnMaHangSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThoiGianBH", DbType="VarChar(50)")]
		public string ThoiGianBH
		{
			get
			{
				return this._ThoiGianBH;
			}
			set
			{
				if ((this._ThoiGianBH != value))
				{
					this.OnThoiGianBHChanging(value);
					this.SendPropertyChanging();
					this._ThoiGianBH = value;
					this.SendPropertyChanged("ThoiGianBH");
					this.OnThoiGianBHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiThieu", DbType="VarChar(500)")]
		public string GioiThieu
		{
			get
			{
				return this._GioiThieu;
			}
			set
			{
				if ((this._GioiThieu != value))
				{
					this.OnGioiThieuChanging(value);
					this.SendPropertyChanging();
					this._GioiThieu = value;
					this.SendPropertyChanged("GioiThieu");
					this.OnGioiThieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaAnh", DbType="VarChar(50)")]
		public string MaAnh
		{
			get
			{
				return this._MaAnh;
			}
			set
			{
				if ((this._MaAnh != value))
				{
					this.OnMaAnhChanging(value);
					this.SendPropertyChanging();
					this._MaAnh = value;
					this.SendPropertyChanged("MaAnh");
					this.OnMaAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anh", DbType="VarChar(50)")]
		public string Anh
		{
			get
			{
				return this._Anh;
			}
			set
			{
				if ((this._Anh != value))
				{
					this.OnAnhChanging(value);
					this.SendPropertyChanging();
					this._Anh = value;
					this.SendPropertyChanged("Anh");
					this.OnAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tHangSX_tDanhMucSP", Storage="_tHangSX", ThisKey="MaHangSX", OtherKey="MaHangSX", IsForeignKey=true)]
		public tHangSX tHangSX
		{
			get
			{
				return this._tHangSX.Entity;
			}
			set
			{
				tHangSX previousValue = this._tHangSX.Entity;
				if (((previousValue != value) 
							|| (this._tHangSX.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tHangSX.Entity = null;
						previousValue.tDanhMucSPs.Remove(this);
					}
					this._tHangSX.Entity = value;
					if ((value != null))
					{
						value.tDanhMucSPs.Add(this);
						this._MaHangSX = value.MaHangSX;
					}
					else
					{
						this._MaHangSX = default(string);
					}
					this.SendPropertyChanged("tHangSX");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tMauSac_tDanhMucSP", Storage="_tMauSac", ThisKey="MaMau", OtherKey="MaMau", IsForeignKey=true)]
		public tMauSac tMauSac
		{
			get
			{
				return this._tMauSac.Entity;
			}
			set
			{
				tMauSac previousValue = this._tMauSac.Entity;
				if (((previousValue != value) 
							|| (this._tMauSac.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tMauSac.Entity = null;
						previousValue.tDanhMucSPs.Remove(this);
					}
					this._tMauSac.Entity = value;
					if ((value != null))
					{
						value.tDanhMucSPs.Add(this);
						this._MaMau = value.MaMau;
					}
					else
					{
						this._MaMau = default(string);
					}
					this.SendPropertyChanged("tMauSac");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tHangSX")]
	public partial class tHangSX : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHangSX;
		
		private string _HangSX;
		
		private EntitySet<tDanhMucSP> _tDanhMucSPs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHangSXChanging(string value);
    partial void OnMaHangSXChanged();
    partial void OnHangSXChanging(string value);
    partial void OnHangSXChanged();
    #endregion
		
		public tHangSX()
		{
			this._tDanhMucSPs = new EntitySet<tDanhMucSP>(new Action<tDanhMucSP>(this.attach_tDanhMucSPs), new Action<tDanhMucSP>(this.detach_tDanhMucSPs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHangSX", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHangSX
		{
			get
			{
				return this._MaHangSX;
			}
			set
			{
				if ((this._MaHangSX != value))
				{
					this.OnMaHangSXChanging(value);
					this.SendPropertyChanging();
					this._MaHangSX = value;
					this.SendPropertyChanged("MaHangSX");
					this.OnMaHangSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HangSX", DbType="VarChar(50)")]
		public string HangSX
		{
			get
			{
				return this._HangSX;
			}
			set
			{
				if ((this._HangSX != value))
				{
					this.OnHangSXChanging(value);
					this.SendPropertyChanging();
					this._HangSX = value;
					this.SendPropertyChanged("HangSX");
					this.OnHangSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tHangSX_tDanhMucSP", Storage="_tDanhMucSPs", ThisKey="MaHangSX", OtherKey="MaHangSX")]
		public EntitySet<tDanhMucSP> tDanhMucSPs
		{
			get
			{
				return this._tDanhMucSPs;
			}
			set
			{
				this._tDanhMucSPs.Assign(value);
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
		
		private void attach_tDanhMucSPs(tDanhMucSP entity)
		{
			this.SendPropertyChanging();
			entity.tHangSX = this;
		}
		
		private void detach_tDanhMucSPs(tDanhMucSP entity)
		{
			this.SendPropertyChanging();
			entity.tHangSX = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tMauSac")]
	public partial class tMauSac : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaMau;
		
		private string _TenMau;
		
		private EntitySet<tDanhMucSP> _tDanhMucSPs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaMauChanging(string value);
    partial void OnMaMauChanged();
    partial void OnTenMauChanging(string value);
    partial void OnTenMauChanged();
    #endregion
		
		public tMauSac()
		{
			this._tDanhMucSPs = new EntitySet<tDanhMucSP>(new Action<tDanhMucSP>(this.attach_tDanhMucSPs), new Action<tDanhMucSP>(this.detach_tDanhMucSPs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMau", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMau
		{
			get
			{
				return this._MaMau;
			}
			set
			{
				if ((this._MaMau != value))
				{
					this.OnMaMauChanging(value);
					this.SendPropertyChanging();
					this._MaMau = value;
					this.SendPropertyChanged("MaMau");
					this.OnMaMauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMau", DbType="VarChar(50)")]
		public string TenMau
		{
			get
			{
				return this._TenMau;
			}
			set
			{
				if ((this._TenMau != value))
				{
					this.OnTenMauChanging(value);
					this.SendPropertyChanging();
					this._TenMau = value;
					this.SendPropertyChanged("TenMau");
					this.OnTenMauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tMauSac_tDanhMucSP", Storage="_tDanhMucSPs", ThisKey="MaMau", OtherKey="MaMau")]
		public EntitySet<tDanhMucSP> tDanhMucSPs
		{
			get
			{
				return this._tDanhMucSPs;
			}
			set
			{
				this._tDanhMucSPs.Assign(value);
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
		
		private void attach_tDanhMucSPs(tDanhMucSP entity)
		{
			this.SendPropertyChanging();
			entity.tMauSac = this;
		}
		
		private void detach_tDanhMucSPs(tDanhMucSP entity)
		{
			this.SendPropertyChanging();
			entity.tMauSac = null;
		}
	}
}
#pragma warning restore 1591
